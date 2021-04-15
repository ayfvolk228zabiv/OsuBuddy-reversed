﻿using System;
using OsuParsers.Enums.Beatmaps;

namespace OsuParsers.Beatmaps.Objects
{
	// Token: 0x02000077 RID: 119
	public class Extras
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0000390A File Offset: 0x0000390A
		public Extras()
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003914 File Offset: 0x00003914
		public Extras(SampleSet sampleSet, SampleSet additionSet, int customIndex, int volume, string sampleFileName)
		{
			this.SampleSet = sampleSet;
			this.AdditionSet = additionSet;
			this.CustomIndex = customIndex;
			this.Volume = volume;
			this.SampleFileName = sampleFileName;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00003948 File Offset: 0x00003948
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003950 File Offset: 0x00003950
		public SampleSet SampleSet { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00003959 File Offset: 0x00003959
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003961 File Offset: 0x00003961
		public SampleSet AdditionSet { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000396A File Offset: 0x0000396A
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00003972 File Offset: 0x00003972
		public int CustomIndex { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000397B File Offset: 0x0000397B
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00003983 File Offset: 0x00003983
		public int Volume { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000398C File Offset: 0x0000398C
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00003994 File Offset: 0x00003994
		public string SampleFileName { get; set; }
	}
}