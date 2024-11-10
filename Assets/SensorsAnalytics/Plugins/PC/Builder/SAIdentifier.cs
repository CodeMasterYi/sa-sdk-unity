﻿//
using SensorsAnalyticsPCSDK.Database;
using SensorsAnalyticsPCSDK.Utils;

	public class SAIdentifier
	{

		// Id 信息本地存储
		// 登录 Id
		private readonly string kSAIdentitiesLoginId = "$identity_login_id";

		// 匿名 Id
		private readonly string kSAIdentitiesAnonymousId = @"$identity_anonymous_id";

		// 完整 Id 信息 json 存储文件名
		private readonly string kSAIdentitiesJsonFileName = @"SensorsData_Identities";

		// 完整用户 id 信息
		private Dictionary<string, string> _identities = new Dictionary<string, string>();

		public SAIdentifier()
		{
			// anonymous_id 为空则重置
			if (!_identities.ContainsKey(kSAIdentitiesAnonymousId))
		}

		/// <summary>
		public string LoginId()

		/// <summary>
		public string AnonymousId()


		/// <summary>
		public string DistinctId()

		/// <summary>
		public bool Login(string loginId)
		public bool Identify(string anonymousId)

		/// <summary>
		public void Logout()

		/// <summary>
		private bool IsValidLoginId(string loginId)

		// 本地解析 Identities
		private Dictionary<string, string>UnarchiveIdentities()
			if(!SAValidator.IsValidDictionary(identitiesObject))
			Dictionary<string, string> identitiesDic = identitiesObject.ToDictionary(kv => kv.Key, kv => kv.Value.ToString());
			return identitiesDic;

		// Identities 本地保存
		private void ArchiveIdentities(Dictionary<string, string> identities)
	}

}