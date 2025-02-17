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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An object that defines how Security Hub is configured. It includes whether Security
    /// Hub is enabled or disabled, a list of enabled security standards, a list of enabled
    /// or disabled security controls, and a list of custom parameter values for specified
    /// controls. If you provide a list of security controls that are enabled in the configuration
    /// policy, Security Hub disables all other controls (including newly released controls).
    /// If you provide a list of security controls that are disabled in the configuration
    /// policy, Security Hub enables all other controls (including newly released controls).
    /// </summary>
    public partial class Policy
    {
        private SecurityHubPolicy _securityHub;

        /// <summary>
        /// Gets and sets the property SecurityHub. 
        /// <para>
        ///  The Amazon Web Services service that the configuration policy applies to. 
        /// </para>
        /// </summary>
        public SecurityHubPolicy SecurityHub
        {
            get { return this._securityHub; }
            set { this._securityHub = value; }
        }

        // Check to see if SecurityHub property is set
        internal bool IsSetSecurityHub()
        {
            return this._securityHub != null;
        }

    }
}