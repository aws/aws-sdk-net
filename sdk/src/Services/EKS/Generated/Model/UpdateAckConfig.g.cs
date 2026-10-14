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
    /// Configuration updates for an ACK (Amazon Web Services Controllers for Kubernetes)
    /// capability. You only need to specify the fields that you want to update.
    /// </summary>
    public partial class UpdateAckConfig
    {
        /// <summary>
        /// Gets and sets the property DisabledServices. 
        /// <para>
        /// An updated list of ACK service names whose controllers are turned off for this capability.
        /// This list replaces the previous list instead of merging with it, so specify the complete
        /// set of services that you want turned off. If you omit this field, the previous list
        /// is unchanged. To turn all services back on, specify an empty list.
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
        /// Specifies whether ACK controllers resolve resource references to resources in a different
        /// Kubernetes namespace. Set this value to <c>false</c> to require references to remain
        /// within the same namespace, or <c>true</c> to allow cross-namespace references. If
        /// you omit this field, the current value is unchanged.
        /// </para>
        /// </summary>
        public bool? EnableCrossNamespace { get; set; }

        /// <summary>
        /// Checks to see if the EnableCrossNamespace property is set.
        /// </summary>
        internal bool IsSetEnableCrossNamespace() => this.EnableCrossNamespace.HasValue;
    }
}
