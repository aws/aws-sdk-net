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
    /// This is the response object from the DeleteOptedOutNumber operation.
    /// </summary>
    public partial class DeleteOptedOutNumberResponse : AmazonWebServiceResponse
    {
        private bool? _endUserOptedOut;
        private string _optedOutNumber;
        private DateTime? _optedOutTimestamp;
        private string _optOutListArn;
        private string _optOutListName;

        /// <summary>
        /// Gets and sets the property EndUserOptedOut. 
        /// <para>
        /// This is true if it was the end user who requested their phone number be removed. 
        /// </para>
        /// </summary>
        public bool? EndUserOptedOut
        {
            get { return this._endUserOptedOut; }
            set { this._endUserOptedOut = value; }
        }

        // Check to see if EndUserOptedOut property is set
        internal bool IsSetEndUserOptedOut()
        {
            return this._endUserOptedOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptedOutNumber. 
        /// <para>
        /// The phone number that was removed from the OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property OptedOutTimestamp. 
        /// <para>
        /// The time that the number was removed at, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? OptedOutTimestamp
        {
            get { return this._optedOutTimestamp; }
            set { this._optedOutTimestamp = value; }
        }

        // Check to see if OptedOutTimestamp property is set
        internal bool IsSetOptedOutTimestamp()
        {
            return this._optedOutTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptOutListArn. 
        /// <para>
        /// The OptOutListArn that the phone number was removed from.
        /// </para>
        /// </summary>
        public string OptOutListArn
        {
            get { return this._optOutListArn; }
            set { this._optOutListArn = value; }
        }

        // Check to see if OptOutListArn property is set
        internal bool IsSetOptOutListArn()
        {
            return this._optOutListArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutListName that the phone number was removed from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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