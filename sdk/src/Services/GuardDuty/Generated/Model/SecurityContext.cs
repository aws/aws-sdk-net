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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container security context.
    /// </summary>
    public partial class SecurityContext
    {
        private bool? _allowPrivilegeEscalation;
        private bool? _privileged;

        /// <summary>
        /// Gets and sets the property AllowPrivilegeEscalation. 
        /// <para>
        /// Whether or not a container or a Kubernetes pod is allowed to gain more privileges
        /// than its parent process.
        /// </para>
        /// </summary>
        public bool? AllowPrivilegeEscalation
        {
            get { return this._allowPrivilegeEscalation; }
            set { this._allowPrivilegeEscalation = value; }
        }

        // Check to see if AllowPrivilegeEscalation property is set
        internal bool IsSetAllowPrivilegeEscalation()
        {
            return this._allowPrivilegeEscalation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// Whether the container is privileged.
        /// </para>
        /// </summary>
        public bool? Privileged
        {
            get { return this._privileged; }
            set { this._privileged = value; }
        }

        // Check to see if Privileged property is set
        internal bool IsSetPrivileged()
        {
            return this._privileged.HasValue; 
        }

    }
}