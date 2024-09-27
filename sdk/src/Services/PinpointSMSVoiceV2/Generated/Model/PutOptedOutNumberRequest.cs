/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutOptedOutNumber operation.
    /// Creates an opted out destination phone number in the opt-out list.
    /// 
    ///  
    /// <para>
    /// If the destination phone number isn't valid or if the specified opt-out list doesn't
    /// exist, an error is returned.
    /// </para>
    /// </summary>
    public partial class PutOptedOutNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _optedOutNumber;
        private string _optOutListName;

        /// <summary>
        /// Gets and sets the property OptedOutNumber. 
        /// <para>
        /// The phone number to add to the OptOutList in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string OptedOutNumber
        {
            get { return this._optedOutNumber; }
            set { this._optedOutNumber = value; }
        }

        // Check to see if OptedOutNumber property is set
        internal bool IsSetOptedOutNumber()
        {
            return this._optedOutNumber != null;
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutListName or OptOutListArn to add the phone number to.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

    }
}