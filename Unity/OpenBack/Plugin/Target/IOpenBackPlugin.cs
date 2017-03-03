﻿using System;

namespace OpenBackUnity
{
	public interface IOpenBackPlugin
	{
		bool setUserInfo (OpenBackUserInfo userInfo);
		bool setCustomTrigger (OpenBackTrigger trigger, string value);
		bool setCustomTrigger (OpenBackTrigger trigger, int value);
		bool setCustomTrigger (OpenBackTrigger trigger, long value);
		bool setCustomTrigger (OpenBackTrigger trigger, float value);
		bool setCustomTrigger (OpenBackTrigger trigger, double value);

		string getSdkVersion ();
	}
}
