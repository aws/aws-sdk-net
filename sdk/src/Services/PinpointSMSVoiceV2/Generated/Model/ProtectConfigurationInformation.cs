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
    /// Provides information on the specified protect configuration.
    /// </summary>
    public partial class ProtectConfigurationInformation
    {
        private bool? _accountDefault;
        private DateTime? _createdTimestamp;
        private bool? _deletionProtectionEnabled;
        private string _protectConfigurationArn;
        private string _protectConfigurationId;

        /// <summary>
        /// Gets and sets the property AccountDefault. 
        /// <para>
        /// This is true if the protect configuration is set as your account default protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AccountDefault
        {
            get { return this._accountDefault; }
            set { this._accountDefault = value; }
        }

        // Check to see if AccountDefault property is set
        internal bool IsSetAccountDefault()
        {
            return this._accountDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the protect configuration was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// The status of deletion protection for the protect configuration. When set to true
        /// deletion protection is enabled. By default this is set to false. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtectConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProtectConfigurationArn
        {
            get { return this._protectConfigurationArn; }
            set { this._protectConfigurationArn = value; }
        }

        // Check to see if ProtectConfigurationArn property is set
        internal bool IsSetProtectConfigurationArn()
        {
            return this._protectConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProtectConfigurationId
        {
            get { return this._protectConfigurationId; }
            set { this._protectConfigurationId = value; }
        }

        // Check to see if ProtectConfigurationId property is set
        internal bool IsSetProtectConfigurationId()
        {
            return this._protectConfigurationId != null;
        }

    }
}