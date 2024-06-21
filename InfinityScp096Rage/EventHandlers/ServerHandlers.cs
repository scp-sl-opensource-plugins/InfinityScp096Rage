using Exiled.API.Features;
using Exiled.API.Features.Roles;
using MEC;
using PlayerRoles;
using System.Collections.Generic;
using System.Linq;

namespace InfinityScp096Rage.EventHandlers
{
    internal class ServerHandlers
    {
        internal static IEnumerator<float> OnRoundStarted()
        {
            while (!Round.IsLobby)
            {
                foreach (Player player in Player.List.Where(x => x.Role.Type is RoleTypeId.Scp096))
                {
                    Scp096Role role = player.Role as Scp096Role;
                    if (role.Targets.Any()) role.EnragedTimeLeft = float.MaxValue;
                    else if (!role.Targets.Any() && role.EnragedTimeLeft > 0) role.EnragedTimeLeft = 0;
                }

                yield return Timing.WaitForSeconds(5);
            }
        }
    }
}
