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
    /// Stateful inspection criteria for a domain list rule group.
    /// </summary>
    public partial class RuleGroupSourceListDetails
    {
        /// <summary>
        /// Gets and sets the property GeneratedRulesType. 
        /// <para>
        /// Indicates whether to allow or deny access to the domains listed in <c>Targets</c>.
        /// </para>
        /// </summary>
        public string GeneratedRulesType { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedRulesType property is set.
        /// </summary>
        internal bool IsSetGeneratedRulesType() => this.GeneratedRulesType != null;

        /// <summary>
        /// Gets and sets the property TargetTypes. 
        /// <para>
        /// The protocols that you want to inspect. Specify <c>LS_SNI</c> for HTTPS. Specify <c>HTTP_HOST</c>
        /// for HTTP. You can specify either or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetTypes property is set.
        /// </summary>
        internal bool IsSetTargetTypes() => this.TargetTypes != null && (this.TargetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The domains that you want to inspect for in your traffic flows. You can provide full
        /// domain names, or use the '.' prefix as a wildcard. For example, <c>.example.com</c>
        /// matches all domains that end with <c>example.com</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
