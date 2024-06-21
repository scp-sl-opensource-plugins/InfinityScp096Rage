using Exiled.API.Features;
using InfinityScp096Rage.EventHandlers;

namespace InfinityScp096Rage
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin plugin;
        public override string Prefix => "InfinityScp096Rage";
        public override string Name => "InfinityScp096Rage";
        public override string Author => "[OPENSOURCE PLUGIN] [https://github.com/scp-sl-opensource-plugins]";
        public override void OnEnabled()
        {
            plugin = this;
            Exiled.Events.Handlers.Scp096.CalmingDown += Scp096Handlers.OnCalmingDown;
            Exiled.Events.Handlers.Server.RoundStarted += ServerHandlers.OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            plugin = null;
            Exiled.Events.Handlers.Scp096.CalmingDown -= Scp096Handlers.OnCalmingDown;
            Exiled.Events.Handlers.Server.RoundStarted -= ServerHandlers.OnRoundStarted;
            base.OnDisabled();
        }
    }
}
