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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The custom permissions profile.
    /// </summary>
    public partial class CustomPermissions
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom permissions profile.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A set of actions in the custom permissions profile.
        /// </para>
        /// </summary>
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// The name of the custom permissions profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CustomPermissionsName { get; set; }

        /// <summary>
        /// Checks to see if the CustomPermissionsName property is set.
        /// </summary>
        internal bool IsSetCustomPermissionsName() => this.CustomPermissionsName != null;

        /// <summary>
        /// Gets and sets the property Governance. 
        /// <para>
        /// The governance configuration for the custom permissions profile. When you enable governance
        /// for a category, Amazon Quick denies access to any current or new capability in that
        /// category unless you explicitly set that capability to <c>ALLOW</c> in <c>Capabilities</c>.
        /// </para>
        /// </summary>
        public Governance Governance { get; set; }

        /// <summary>
        /// Checks to see if the Governance property is set.
        /// </summary>
        internal bool IsSetGovernance() => this.Governance != null;
    }
}
