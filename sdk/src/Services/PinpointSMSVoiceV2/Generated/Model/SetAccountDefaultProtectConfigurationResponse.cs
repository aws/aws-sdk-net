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
    /// This is the response object from the SetAccountDefaultProtectConfiguration operation.
    /// </summary>
    public partial class SetAccountDefaultProtectConfigurationResponse : AmazonWebServiceResponse
    {
        private string _defaultProtectConfigurationArn;
        private string _defaultProtectConfigurationId;

        /// <summary>
        /// Gets and sets the property DefaultProtectConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account default protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DefaultProtectConfigurationArn
        {
            get { return this._defaultProtectConfigurationArn; }
            set { this._defaultProtectConfigurationArn = value; }
        }

        // Check to see if DefaultProtectConfigurationArn property is set
        internal bool IsSetDefaultProtectConfigurationArn()
        {
            return this._defaultProtectConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultProtectConfigurationId. 
        /// <para>
        /// The unique identifier of the account default protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DefaultProtectConfigurationId
        {
            get { return this._defaultProtectConfigurationId; }
            set { this._defaultProtectConfigurationId = value; }
        }

        // Check to see if DefaultProtectConfigurationId property is set
        internal bool IsSetDefaultProtectConfigurationId()
        {
            return this._defaultProtectConfigurationId != null;
        }

    }
}