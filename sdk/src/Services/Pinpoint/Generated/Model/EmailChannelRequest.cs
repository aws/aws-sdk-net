/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Email Channel Request
    /// </summary>
    public partial class EmailChannelRequest
    {
        private string _configurationSet;
        private bool? _enabled;
        private string _fromAddress;
        private string _identity;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. The configuration set that you want to
        /// use when you send email using the Pinpoint Email API.
        /// </summary>
        public string ConfigurationSet
        {
            get { return this._configurationSet; }
            set { this._configurationSet = value; }
        }

        // Check to see if ConfigurationSet property is set
        internal bool IsSetConfigurationSet()
        {
            return this._configurationSet != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. If the channel is enabled for sending messages.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromAddress. The email address used to send emails from.
        /// </summary>
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. The ARN of an identity verified with SES.
        /// </summary>
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The ARN of an IAM Role used to submit events to
        /// Mobile Analytics' event ingestion service
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}