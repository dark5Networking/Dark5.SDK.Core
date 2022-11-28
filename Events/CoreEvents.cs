using JetBrains.Annotations;

namespace Dark5.SDK.Core.Events
{
	/// <summary>
	/// Core dark5 events.
	/// </summary>
	[PublicAPI]
	public static class CoreEvents
	{
		/// <summary>
		/// The event that is fired as soon as a client initializes.
		/// </summary>
		public const string ClientInitialize = "dark5:core:clientInitialize";

		/// <summary>
		/// The event that is fired as soon as a client has initialized.
		/// </summary>
		public const string ClientInitialized = "dark5:core:clientInitialized";

		/// <summary>
		/// The event that is fired after client initialization to request plugin information.
		/// </summary>
		public const string ClientPlugins = "dark5:core:clientPlugins";

		public const string CommandDispatch = "dark5:command:dispatch";

		/// <summary>
		/// The event that is fired when the client is relaying a log message to the server.
		/// </summary>
		public const string LogMirror = "dark5:log:mirror";
	}
}
