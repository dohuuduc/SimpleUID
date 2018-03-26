using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Simple_UID.Properties
{
	// Token: 0x0200001F RID: 31
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00009690 File Offset: 0x00007890
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000CF RID: 207
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
