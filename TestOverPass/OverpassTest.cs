namespace TestOverPass
{
    using OverPass;

    [TestClass]
    public class OverpassTest
    {
        [TestMethod]
        public void ExampleFromGithub()
        {
            string BBox = "41.926785246437,12.462970018387,41.927633354446,12.464384883642"; // Rome

            Dictionary<string, List<string>>? Query = new()
            {
                { "highway", new List<string>() { "residential" } },
                { "amenity", new List<string>() { "place_of_worship" } },
                { "religion", new List<string>() { "christian", "jewish" } },
                { "tourism", new List<string>() { "bed_and_breakfast", "hotel" } }
            };

            var op = new OverPassAPI();
            op.SetFilter(new OverPassParameters() { BBox = BBox, Query = Query });
            var task = Task.Run(op.Features);
            var r = task.Result;
        }
    }
}
