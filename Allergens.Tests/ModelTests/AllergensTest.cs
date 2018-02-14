using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergens;
using System.Collections.Generic;
using Allergens.Models;

namespace Allergens.Tests
{
  [TestClass]
  public class ScoreTest
  {
    [TestMethod]
    public void GetAndSetInputScore_ReturnScore_Int()
    {
      Score newScore = new Score();
      newScore.SetInputScore(5);
      Assert.AreEqual(5, newScore.GetInputScore());
    }
  }
  [TestClass]
  public class AllergyTest
  {
    [TestMethod]
    public void GetAllergyName_ReturnName_String()
    {
      Allergy newAllergy = new Allergy("pollen", 64);
      Assert.AreEqual("pollen", newAllergy.GetAllergyName());
    }
    [TestMethod]
    public void GetAllergyNumber_ReturnNumber_Int()
    {
      Allergy newAllergy = new Allergy("pollen", 64);
      Assert.AreEqual(64, newAllergy.GetAllergyNumber());
    }
  }
}
