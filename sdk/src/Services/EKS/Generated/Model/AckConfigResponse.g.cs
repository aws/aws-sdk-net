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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The response object containing configuration details for an ACK (Amazon Web Services
    /// Controllers for Kubernetes) capability.
    /// </summary>
    public partial class AckConfigResponse
    {
        /// <summary>
        /// Gets and sets the property DisabledServices. 
        /// <para>
        /// The list of ACK service names whose controllers are turned off for this capability.
        /// Existing custom resource definitions remain installed, and resources of a disabled
        /// service aren't reconciled until the service is re-enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> DisabledServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DisabledServices property is set.
        /// </summary>
        internal bool IsSetDisabledServices() => this.DisabledServices != null && (this.DisabledServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableCrossNamespace. 
        /// <para>
        /// Indicates whether ACK controllers resolve resource references to resources in a different
        /// Kubernetes namespace. This value reflects the setting that's in effect, and is <c>false</c>
        /// if you never specified a value. Capabilities that were using cross-namespace references
        /// before this setting became available have this value set to <c>true</c>, so their
        /// behavior is unchanged.
        /// </para>
        /// </summary>
        public bool? EnableCrossNamespace { get; set; }

        /// <summary>
        /// Checks to see if the EnableCrossNamespace property is set.
        /// </summary>
        internal bool IsSetEnableCrossNamespace() => this.EnableCrossNamespace.HasValue;
    }
}
