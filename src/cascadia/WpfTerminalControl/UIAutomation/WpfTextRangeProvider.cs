using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Provider;
using System.Windows.Automation.Text;

namespace Microsoft.Terminal.Wpf
{
    internal class WpfTextRangeProvider : ITextRangeProvider
    {
        public void AddToSelection()
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider Clone()
        {
            throw new NotImplementedException();
        }

        public bool Compare(ITextRangeProvider range)
        {
            throw new NotImplementedException();
        }

        public int CompareEndpoints(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint)
        {
            throw new NotImplementedException();
        }

        public void ExpandToEnclosingUnit(TextUnit unit)
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider FindAttribute(int attribute, object value, bool backward)
        {
            throw new NotImplementedException();
        }

        public ITextRangeProvider FindText(string text, bool backward, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public object GetAttributeValue(int attribute)
        {
            throw new NotImplementedException();
        }

        public double[] GetBoundingRectangles()
        {
            throw new NotImplementedException();
        }

        public IRawElementProviderSimple[] GetChildren()
        {
            throw new NotImplementedException();
        }

        public IRawElementProviderSimple GetEnclosingElement()
        {
            throw new NotImplementedException();
        }

        public string GetText(int maxLength)
        {
            throw new NotImplementedException();
        }

        public int Move(TextUnit unit, int count)
        {
            throw new NotImplementedException();
        }

        public void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint)
        {
            throw new NotImplementedException();
        }

        public int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromSelection()
        {
            throw new NotImplementedException();
        }

        public void ScrollIntoView(bool alignToTop)
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }
    }
}
