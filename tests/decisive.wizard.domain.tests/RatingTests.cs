using Decisive.Wizard.Domain.Catalog;
using Decisive.Wizard.Domain.Orders;

namespace decisive.wizard.domain.tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        var rating = new Rating(1, "Mike", "Great fit!");

        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        var rating = new Rating(0, "Mike", "Great fit!");
    }

    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");

        item.AddRating(rating);

        Assert.AreEqual(rating, item.Ratings[0]);

    }
}