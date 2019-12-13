using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace Microsoft.Terminal.Wpf
{
    internal class TerminalContainerAutomationPeer : FrameworkElementAutomationPeer
    {
        private TerminalControlUiaProvider uiaProvider;

        public TerminalContainerAutomationPeer(FrameworkElement owner) : base(owner)
        {
        }

        internal IRawElementProviderSimple GetProvider()
        {
            return ProviderFromPeer(this);
        }

        protected override string GetClassNameCore()
        {
            return "TerminalControl";
        }

        protected override HostedWindowWrapper GetHostRawElementProviderCore()
        {
            if (this.Owner is TerminalContainer container
                && container.Hwnd != IntPtr.Zero)
            {
                return new HostedWindowWrapper(container.Hwnd);
            }

            return null;
        }
    }
}
