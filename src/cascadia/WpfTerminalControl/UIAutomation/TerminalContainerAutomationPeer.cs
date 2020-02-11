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

        protected override string GetClassNameCore()
        {
            return "TerminalContainerHost";
        }

        override protected AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Pane;
        }

        override protected bool IsHwndHost { get { return true; }}

        protected override HostedWindowWrapper GetHostRawElementProviderCore()
        {
            HostedWindowWrapper host = null;
            
            TerminalContainer wfh = (TerminalContainer)Owner;
            IntPtr hwnd = wfh.Hwnd;
 
            if(hwnd != IntPtr.Zero)
            {
                host = new HostedWindowWrapper(hwnd);
            }
 
            return host;
        }

        internal IRawElementProviderSimple GetProvider()
        {
            return ProviderFromPeer(this);
        }
    }
}
