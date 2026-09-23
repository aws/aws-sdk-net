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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Configuration settings that control a deployment's behavior.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private bool? _enableCrossAccountVisibility;

        /// <summary>
        /// Gets and sets the property EnableCrossAccountVisibility. 
        /// <para>
        /// Specifies whether aggregate synchronization status details for the resources covered
        /// by this deployment are visible across accounts. Default: <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableCrossAccountVisibility
        {
            get { return this._enableCrossAccountVisibility; }
            set { this._enableCrossAccountVisibility = value; }
        }

        // Check to see if EnableCrossAccountVisibility property is set
        internal bool IsSetEnableCrossAccountVisibility()
        {
            return this._enableCrossAccountVisibility.HasValue; 
        }

    }
}