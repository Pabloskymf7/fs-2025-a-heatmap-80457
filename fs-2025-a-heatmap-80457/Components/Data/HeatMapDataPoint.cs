namespace fs_2025_a_heatmap_80457.Components.Data
{
    public class HeatMapDataPoint
    {
        public string Day { get; set; } = string.Empty;    // Monday, Tuesday...
        public int Week { get; set; }                      // 1..52
        public int Value { get; set; }                     // 0,5,10,15,20
    }
}
