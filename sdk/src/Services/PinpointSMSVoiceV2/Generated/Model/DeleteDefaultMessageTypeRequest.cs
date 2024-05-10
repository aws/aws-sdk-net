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
    /// Container for the parameters to the DeleteDefaultMessageType operation.
    /// Deletes an existing default message type on a configuration set.
    /// 
    ///  
    /// <para>
    ///  A message type is a type of messages that you plan to send. If you send account-related
    /// messages or time-sensitive messages such as one-time passcodes, choose <b>Transactional</b>.
    /// If you plan to send messages that contain marketing material or other promotional
    /// content, choose <b>Promotional</b>. This setting applies to your entire Amazon Web
    /// Services account. 
    /// </para>
    /// </summary>
    public partial class DeleteDefaultMessageTypeRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _configurationSetName;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set or the configuration set Amazon Resource Name (ARN)
        /// to delete the default message type from. The ConfigurationSetName and ConfigurationSetArn
        /// can be found using the <a>DescribeConfigurationSets</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}