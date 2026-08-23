using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
	[TdfStruct]
	public struct NotifyGameStateChange
	{

		[TdfMember("GID")]
		public ulong mGameId;

		[TdfMember("GSTA")]
		public GameState mNewGameState;

	}
}
