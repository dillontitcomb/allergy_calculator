using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Allergens.Models
{
  public class Score
  {
    private int _inputScore;

    public Score (int score)
    {
      _inputScore = score;
    }

    private List<Allergy> _allergyList = new List<Allergy> {};
    private List<string> _allergyDisplay = new List<string> {};

    public int GetInputScore()
    {
      return _inputScore;
    }
    public void SetInputScore(int newScore)
    {
      _inputScore = newScore;
    }
    public List<Allergy> GetList()
    {
      return _allergyList;
    }
    public List<string> GetAllergyList(List<Allergy> list)
    {
      foreach (Allergy item in list)
      {
        if (item.GetAllergyNumber() <= _inputScore)
        {
          _allergyDisplay.Add(item.GetAllergyName());
          _inputScore -= item.GetAllergyNumber();
        }
      }
      return _allergyDisplay;
    }
  }
}
