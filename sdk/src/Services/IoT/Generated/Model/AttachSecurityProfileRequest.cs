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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the AttachSecurityProfile operation.
    /// Associates a Device Defender security profile with a thing group or with this account.
    /// Each thing group or account can have up to five security profiles associated with
    /// it.
    /// </summary>
    public partial class AttachSecurityProfileRequest : AmazonIoTRequest
    {
        private string _securityProfileName;
        private string _securityProfileTargetArn;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The security profile that is attached.
        /// </para>
        /// </summary>
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileTargetArn. 
        /// <para>
        /// The ARN of the target (thing group) to which the security profile is attached.
        /// </para>
        /// </summary>
        public string SecurityProfileTargetArn
        {
            get { return this._securityProfileTargetArn; }
            set { this._securityProfileTargetArn = value; }
        }

        // Check to see if SecurityProfileTargetArn property is set
        internal bool IsSetSecurityProfileTargetArn()
        {
            return this._securityProfileTargetArn != null;
        }

    }
}