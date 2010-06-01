// /**
// ********
// *
// * ORIGINAL CODE BASE IS Copyright (C) 2006-2010 by Alphons van der Heijden
// * The code was donated on 4/28/2010 by Alphons van der Heijden
// * To Brandon'Dimentox Travanti' Husbands & Malcolm J. Kudra which in turn Liscense under the GPLv2.
// * In agreement to Alphons van der Heijden wishes.
// *
// * The community would like to thank Alphons for all of his hard work, blood sweat and tears.
// * Without his work the community would be stuck with crappy editors.
// *
// * The source code in this file ("Source Code") is provided by The LSLEditor Group
// * to you under the terms of the GNU General Public License, version 2.0
// * ("GPL"), unless you have obtained a separate licensing agreement
// * ("Other License"), formally executed by you and The LSLEditor Group.  Terms of
// * the GPL can be found in the gplv2.txt document.
// *
// ********
// * GPLv2 Header
// ********
// * LSLEditor, a External editor for the LSL Language.
// * Copyright (C) 2010 The LSLEditor Group.
// 
// * This program is free software; you can redistribute it and/or
// * modify it under the terms of the GNU General Public License
// * as published by the Free Software Foundation; either version 2
// * of the License, or (at your option) any later version.
// *
// * This program is distributed in the hope that it will be useful,
// * but WITHOUT ANY WARRANTY; without even the implied warranty of
// * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// * GNU General Public License for more details.
// *
// * You should have received a copy of the GNU General Public License
// * along with this program; if not, write to the Free Software
// * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// ********
// *
// * The above copyright notice and this permission notice shall be included in all 
// * copies or substantial portions of the Software.
// *
// ********
// */
using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace LSLEditor.Plugins
{
	class Particles
	{
		public Particles(LSLEditorForm parent)
		{
            string strPluginName = "Particles";

            string strDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string strPluginsDirectory = Path.Combine(strDirectory, "Plugins");
            string strProgram = Path.Combine(strPluginsDirectory, strPluginName + ".exe");

            Assembly assembly = Assembly.LoadFrom(strProgram);
            Form frmMain = assembly.CreateInstance("Particles.frmMain") as Form;

			if (parent.IsMdiContainer)
			{
				parent.AddForm(frmMain);
			}
			else
			{
				//MessageBox.Show("This plugin does not run in tabbed mode", "Particles plugin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmMain.Show();
			}
		}
	}
}
