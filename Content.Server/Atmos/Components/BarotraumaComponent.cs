using Content.Shared.Damage;
using Content.Shared.FixedPoint;

namespace Content.Server.Atmos.Components
{
    /// <summary>
    ///     Barotrauma: injury because of changes in air pressure.
    /// </summary>
    [RegisterComponent]
    public sealed class BarotraumaComponent : Component
    {
        [DataField("damage", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier Damage = default!;

        [DataField("maxDamage")]
        [ViewVariables(VVAccess.ReadWrite)]
        public FixedPoint2 MaxDamage = 200;

        /// <summary>
        ///     Used to keep track of when damage starts/stops. Useful for logs.
        /// </summary>
        public bool TakingDamage = false;

        /// <summary>
        ///     These are the inventory slots that are checked for pressure protection. If a slot is missing protection, no protection is applied.
        /// </summary>
        [DataField("protectionSlots")]
        public List<string> ProtectionSlots = new() { "head", "outerClothing" }; 
    }
}
