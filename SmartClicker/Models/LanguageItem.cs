using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartClicker.Models
{
    public class LanguageItem
    {
        public string Code { get; set; }        // "ru", "en", "de"
        public string DisplayName { get; set; } // "Русский", "English", "Deutsch"
        public override string ToString() => DisplayName;
    }
}
