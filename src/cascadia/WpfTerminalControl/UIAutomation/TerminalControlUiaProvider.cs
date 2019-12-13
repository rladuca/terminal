using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Provider;

namespace Microsoft.Terminal.Wpf
{
    internal class TerminalControlUiaProvider
    {
        public ITextRangeProvider[] GetSelection()
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider[] GetVisibleRanges()
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider RangeFromChild()
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider RangeFromPoint(Point point)
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider DocumentRange()
        {
            throw new NotImplementedException();
        }

        public SupportedTextSelection SupportedTextSelection { get; }
    }
}
