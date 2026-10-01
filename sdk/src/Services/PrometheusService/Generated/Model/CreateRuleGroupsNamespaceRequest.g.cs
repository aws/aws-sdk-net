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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRuleGroupsNamespace operation. The <c>CreateRuleGroupsNamespace</c>
    /// operation creates a rule groups namespace within a workspace. A rule groups namespace
    /// is associated with exactly one rules file. A workspace can have multiple rule groups
    /// namespaces. <important> <para> The combined length of a rule group namespace and a
    /// rule group name cannot exceed 721 UTF-8 bytes. </para> </important> <para> Use this
    /// operation only to create new rule groups namespaces. To update an existing rule groups
    /// namespace, use <c>PutRuleGroupsNamespace</c>. </para>
    /// </summary>
    public partial class CreateRuleGroupsNamespaceRequest : AmazonPrometheusServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you can provide to ensure the idempotency of the request.
        /// Case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The rules file to use in the new namespace.
        /// </para>
        ///  
        /// <para>
        /// Contains the base64-encoded version of the YAML rules file.
        /// </para>
        ///  
        /// <para>
        /// For details about the rule groups namespace structure, see <a href="https://docs.aws.amazon.com/prometheus/latest/APIReference/yaml-RuleGroupsNamespaceData.html">RuleGroupsNamespaceData</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new rule groups namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tag keys and values to associate with the rule groups namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to add the rule groups namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
