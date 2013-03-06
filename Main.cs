using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rhino4;
using RhinoScript4;

namespace TestRhinoAutomation
{
  public partial class Main : Form
  {
    IRhino5Application m_Rhino = null;
    IRhinoScript m_RhinoScript = null;

    public Main()
    {
      InitializeComponent();
      InitializeButtons();
    }

    private void InitializeButtons()
    {
      bool bNoRhino = (null == m_Rhino);
      buttonRun.Enabled = bNoRhino;
      buttonShow.Enabled = !bNoRhino;
      buttonOpen.Enabled = !bNoRhino;
      buttonHide.Enabled = !bNoRhino;
      buttonClose.Enabled = !bNoRhino;
    }

    private void ReleaseObjects()
    {
      if (null != m_RhinoScript)
      {
        m_RhinoScript.DocumentModified(0);
        m_RhinoScript = null;
      }

      if (null != m_Rhino)
      {
        // Release all references to Rhino by setting its reference count to 0.
        Marshal.FinalReleaseComObject(m_Rhino);
        m_Rhino = null;
      }
    }

    private void buttonRun_Click(object sender, EventArgs e)
    {
      try
      {
        Type type = Type.GetTypeFromProgID("Rhino5.Application");
        object obj = Activator.CreateInstance(type);
        m_Rhino = (IRhino5Application)obj;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Failed to create Rhino5.Application.\n\nError = {0}", ex.Message));
      }

      InitializeButtons();
    }

    private void buttonShow_Click(object sender, EventArgs e)
    {
      try
      {
        m_Rhino.Visible = 1;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Error = {0}", ex.Message));
      }
    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {
      if (null == m_RhinoScript)
      {
        try
        {
          object obj = m_Rhino.GetScriptObject();
          m_RhinoScript = (IRhinoScript)obj;
        }
        catch (Exception ex)
        {
          MessageBox.Show(string.Format("Error = {0}", ex.Message));
        }
      }

      if (null != m_RhinoScript)
      {
        m_RhinoScript.Command("_Open", 0);
      }
    }

    private void buttonHide_Click(object sender, EventArgs e)
    {
      try
      {
        m_Rhino.Visible = 0;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Error = {0}", ex.Message));
      }
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      ReleaseObjects();
      InitializeButtons();
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      ReleaseObjects();
    }
  }
}
