namespace TestOverPassAPI
{
    using OverPass;

    [TestClass]
    public class UnitTest1 : PageTest
    {
        [TestMethod]
        public async Task TestExample()
        {

            string BBox = "41.926785246437,12.462970018387,41.927633354446,12.464384883642"; // Rome

            Dictionary<string, List<string>>? Query = new()
{
    { "highway", new List<string>() { "residential" } },
    { "amenity", new List<string>() { "place_of_worship" } },
    { "religion", new List<string>() { "christian", "jewish" } },
    { "tourism", new List<string>() { "bed_and_breakfast", "hotel" } }
};

            // FeatureCollection Class
            var op = new OverPassAPI();
            op.Parameters = new OverPassParameters() { BBox = BBox, Query = Query };
            var f = op.Features();


        }
    }
}
