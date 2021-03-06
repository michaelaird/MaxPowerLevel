using Destiny2;

namespace MaxPowerLevel.Services.YearThree
{
    public class Season8Recommendations : Year3Recommendations
    {
        protected override int PowerfulCap => 950;

        protected override int HardCap => 960;
        protected override uint SeasonHash => 3612906877;

        public Season8Recommendations(IManifest manifest, SeasonPass seasonPass)
            : base(manifest, seasonPass)
        {
        }
    }
}