using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = 3;
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count <= wordsToHide)
        {
            visibleWords.ForEach(word => word.Hide());
        }
        else
        {
            for (int i = 0; i < wordsToHide; i++)
            {
                var word = visibleWords[random.Next(visibleWords.Count)];
                word.Hide();
                visibleWords.Remove(word);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
