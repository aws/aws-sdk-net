using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PinpointSMSVoiceV2;
using Amazon.PinpointSMSVoiceV2.Model;

namespace AWSSDKDocSamples.Amazon.PinpointSMSVoiceV2.Generated
{
    class PinpointSMSVoiceV2Samples : ISample
    {
        public void PinpointSMSVoiceV2CarrierLookup()
        {
            #region example-1

            var client = new AmazonPinpointSMSVoiceV2Client();
            var response = client.CarrierLookup(new CarrierLookupRequest 
            {
                PhoneNumber = "+1 (555) 555-5333"
            });

            string carrier = response.Carrier;
            string country = response.Country;
            string dialingCountryCode = response.DialingCountryCode;
            string e164PhoneNumber = response.E164PhoneNumber;
            string isoCountryCode = response.IsoCountryCode;
            string mcc = response.MCC;
            string mnc = response.MNC;
            string phoneNumberType = response.PhoneNumberType;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}