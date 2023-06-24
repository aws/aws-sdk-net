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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The information for all OptOutList in an Amazon Web Services account.
    /// </summary>
    public partial class OptOutListInformation
    {
        private DateTime? _createdTimestamp;
        private string _optOutListArn;
        private string _optOutListName;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the OutOutList was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptOutListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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