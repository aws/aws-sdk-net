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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The scope configuration for a GCP connector, defining the organization or project
    /// scope.
    /// </summary>
    public partial class GcpScopeConfiguration
    {
        /// <summary>
        /// Gets and sets the property ScopeType. 
        /// <para>
        /// The type of scope. Valid values are <c>ORGANIZATION</c> and <c>PROJECT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GcpScopeType ScopeType { get; set; }

        /// <summary>
        /// Checks to see if the ScopeType property is set.
        /// </summary>
        internal bool IsSetScopeType() => this.ScopeType != null;

        /// <summary>
        /// Gets and sets the property ScopeValues. 
        /// <para>
        /// The list of scope values. Use an organization ID when the scope type is <c>ORGANIZATION</c>,
        /// or project IDs when the scope type is <c>PROJECT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ScopeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScopeValues property is set.
        /// </summary>
        internal bool IsSetScopeValues() => this.ScopeValues != null && (this.ScopeValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
