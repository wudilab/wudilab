using Ingenico.PosGate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace winrtTest
{
    public sealed class Example
    {
        private EventWaitHandle clearCount = new EventWaitHandle(false, EventResetMode.AutoReset);
        public string GetStatus(string result)
        {
            PosGate gate = new PosGate("127.0.0.1", 7077);//PosGate.getInstance();
            gate.InitialiseComplete += posGate_InitialiseComplete;
            gate.GetStatusComplete += posGate_GetStatusComplete;

            gate.Initialise();
            gate.GetStatus();

            clearCount.WaitOne();
            //bool flag = clearCount.WaitOne(5000);
            //if (flag == false) return "Fail to get response in 5000 seconds";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Success=" + gate.Success);
            sb.AppendLine("Response Code=" + gate.ResponseCode);
            sb.AppendLine("Response Text=" + gate.ResponseText);
            sb.AppendLine("Catid=" + gate.Catid);
            sb.AppendLine("Caid=" + gate.Caid);
            sb.AppendLine("Aiic=" + gate.Aiic);
            sb.AppendLine("Nii=" + gate.Nii);
            sb.AppendLine("Timeout=" + gate.Timeout);
            sb.AppendLine("PinPadVersion=" + gate.PinPadVersion);
            sb.AppendLine("PinPadManufactureDate=" + gate.PinPadManufactureDate);
            sb.AppendLine("PinPadSerialNumber=" + gate.PinPadSerialNumber);
            sb.AppendLine("EftposNetwork=" + gate.EftposNetwork);
            sb.AppendLine("MerchantName=" + gate.MerchantName);
            sb.AppendLine("KeyScheme=" + gate.KeyScheme);
            sb.AppendLine("LoggedOn=" + gate.LoggedOn);
            sb.AppendLine("LoggedOnTms=" + gate.LoggedOnTms);
            sb.AppendLine("MerchantConfigured=" + gate.MerchantConfigured);
            sb.AppendLine("Ppid=" + gate.Ppid);
            sb.AppendLine("CpatVersion=" + gate.CpatVersion);
            sb.AppendLine("CntVersion=" + gate.CntVersion);
            sb.AppendLine("LimitOfflineCredit=" + gate.LimitOfflineCredit);
            sb.AppendLine("LimitOfflineDebit=" + gate.LimitOfflineDebit);
            sb.AppendLine("LimitCash=" + gate.LimitCash);
            sb.AppendLine("LimitRefund=" + gate.LimitRefund);
            sb.AppendLine("PendingReversalCount=" + gate.PendingReversalCount);
            sb.AppendLine("PendingAdviceCount=" + gate.PendingAdviceCount);
            sb.AppendLine("SignalStrength=" + gate.SignalStrength);

            gate.Dispose();
            return sb.ToString();
        }

        private void posGate_GetStatusComplete(object sender, EventArgs e)
        {
            clearCount.Set();
        }

        private void posGate_InitialiseComplete(object sender, EventArgs e)
        {
        }

        public string rt()
        {
            return "Inside RT";
        }
    }
}
