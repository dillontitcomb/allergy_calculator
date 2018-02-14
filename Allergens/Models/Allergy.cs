using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Allergens.Models
{
  public class Allergy
  {
    private string _name;
    private int _number;
    public Allergy (string name, int number)
    {
      _name = name;
      _number = number;
    }

    private static List<Allergy> _allAllergies = new List<Allergy>()
    {
        new Allergy("eggs", 1),
        new Allergy("peanuts", 2),
        new Allergy("shellfish", 4),
        new Allergy("strawberries", 8),
        new Allergy("tomatoes", 16),
        new Allergy("chocolate", 32),
        new Allergy("pollen", 64),
        new Allergy("cats", 128)
    };

    public string GetAllergyName()
    {
      return _name;
    }
    public void SetAllergyName(string newName)
    {
      _name = newName;
    }
    public int GetAllergyNumber()
    {
      return _number;
    }
    public void SetAllergyNumber(int newNumber)
    {
      _number = newNumber;
    }
    public static List<Allergy> GetAllAllergies()
    {
      return _allAllergies;
    }
  }
}
