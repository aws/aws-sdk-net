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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A target SIP media application and other details, such as priority and AWS Region,
    /// to be specified in the SIP rule. Only one SIP rule per AWS Region can be provided.
    /// </summary>
    public partial class SipRuleTargetApplication
    {
        private string _awsRegion;
        private int? _priority;
        private string _sipMediaApplicationId;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region of a rule's target SIP media application.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority setting of a rule's target SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The ID of a rule's target SIP media application.
        /// </para>
        /// </summary>
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

    }
}