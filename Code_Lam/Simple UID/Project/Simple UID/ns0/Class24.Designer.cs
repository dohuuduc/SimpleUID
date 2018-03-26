using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200001E RID: 30
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class Class24
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002273 File Offset: 0x00000473
		internal Class24()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000963C File Offset: 0x0000783C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class24.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("ns0.Class24", typeof(Class24).Assembly);
					Class24.resourceManager_0 = resourceManager;
				}
				return Class24.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000967C File Offset: 0x0000787C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000023DE File Offset: 0x000005DE
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class24.cultureInfo_0;
			}
			set
			{
				Class24.cultureInfo_0 = value;
			}
		}

		// Token: 0x040000CD RID: 205
		private static ResourceManager resourceManager_0;

		// Token: 0x040000CE RID: 206
		private static CultureInfo cultureInfo_0;
	}
}
