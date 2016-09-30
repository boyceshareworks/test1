using System;

namespace WeChat.Portal.Model.Signature
{
    public class SignatureAuthRequest
    {
        public string Signature { get; set; }
        public string TimeStamp { get; set; }
        public string Nonce { get; set; }
        public string EchoStr { get; set; }
    }
}
