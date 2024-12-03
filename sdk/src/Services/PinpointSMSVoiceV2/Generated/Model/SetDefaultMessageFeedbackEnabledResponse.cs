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
    /// This is the response object from the SetDefaultMessageFeedbackEnabled operation.
    /// </summary>
    public partial class SetDefaultMessageFeedbackEnabledResponse : AmazonWebServiceResponse
    {
        private string _configurationSetArn;
        private string _configurationSetName;
        private bool? _messageFeedbackEnabled;

        /// <summary>
        /// Gets and sets the property ConfigurationSetArn. 
        /// <para>
        /// The arn of the configuration set.
        /// </para>
        /// </summary>
        public string ConfigurationSetArn
        {
            get { return this._configurationSetArn; }
            set { this._configurationSetArn = value; }
        }

        // Check to see if ConfigurationSetArn property is set
        internal bool IsSetConfigurationSetArn()
        {
            return this._configurationSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property MessageFeedbackEnabled. 
        /// <para>
        /// True if message feedback is enabled.
        /// </para>
        /// </summary>
        public bool? MessageFeedbackEnabled
        {
            get { return this._messageFeedbackEnabled; }
            set { this._messageFeedbackEnabled = value; }
        }

        // Check to see if MessageFeedbackEnabled property is set
        internal bool IsSetMessageFeedbackEnabled()
        {
            return this._messageFeedbackEnabled.HasValue; 
        }

    }
}