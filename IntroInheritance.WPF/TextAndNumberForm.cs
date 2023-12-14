﻿using IntroInheritance.WPF.Model;

namespace IntroInheritance.WPF
{
    internal class TextAndNumberForm : MultiForm<TextAndNumber>
    {
        public TextAndNumberForm()
        {
            AddField<string>("Tekst", false);
            AddField<int>("Tall", true);
        }
    }
}
