using Exiled.Events.EventArgs.Scp096;
using System.Linq;

namespace InfinityScp096Rage.EventHandlers
{
    internal class Scp096Handlers
    {
        internal static void OnCalmingDown(CalmingDownEventArgs ev)
        {
            if (ev.Player is null || ev.Scp096 is null || !ev.Scp096.Targets.Any()) return;
            ev.IsAllowed = false;
        }
    }
}
