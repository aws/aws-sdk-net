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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about a security profile and the target associated with it.
    /// </summary>
    public partial class SecurityProfileTargetMapping
    {
        private SecurityProfileIdentifier _securityProfileIdentifier;
        private SecurityProfileTarget _target;

        /// <summary>
        /// Gets and sets the property SecurityProfileIdentifier. 
        /// <para>
        /// Information that identifies the security profile.
        /// </para>
        /// </summary>
        public SecurityProfileIdentifier SecurityProfileIdentifier
        {
            get { return this._securityProfileIdentifier; }
            set { this._securityProfileIdentifier = value; }
        }

        // Check to see if SecurityProfileIdentifier property is set
        internal bool IsSetSecurityProfileIdentifier()
        {
            return this._securityProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Information about the target (thing group) associated with the security profile.
        /// </para>
        /// </summary>
        public SecurityProfileTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}