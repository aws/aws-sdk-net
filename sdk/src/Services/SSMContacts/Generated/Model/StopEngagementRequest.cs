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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the StopEngagement operation.
    /// Stops an engagement before it finishes the final stage of the escalation plan or engagement
    /// plan. Further contacts aren't engaged.
    /// </summary>
    public partial class StopEngagementRequest : AmazonSSMContactsRequest
    {
        private string _engagementId;
        private string _reason;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EngagementId
        {
            get { return this._engagementId; }
            set { this._engagementId = value; }
        }

        // Check to see if EngagementId property is set
        internal bool IsSetEngagementId()
        {
            return this._engagementId != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason that you're stopping the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}