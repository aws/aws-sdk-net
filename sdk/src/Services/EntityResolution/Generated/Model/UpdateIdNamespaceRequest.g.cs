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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIdNamespace operation. Updates an existing
    /// ID namespace.
    /// </summary>
    public partial class UpdateIdNamespaceRequest : AmazonEntityResolutionRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdMappingWorkflowProperties. 
        /// <para>
        /// Determines the properties of <c>IdMappingWorkflow</c> where this <c>IdNamespace</c>
        /// can be used as a <c>Source</c> or a <c>Target</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IdNamespaceIdMappingWorkflowProperties> IdMappingWorkflowProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<IdNamespaceIdMappingWorkflowProperties>() : null;

        /// <summary>
        /// Checks to see if the IdMappingWorkflowProperties property is set.
        /// </summary>
        internal bool IsSetIdMappingWorkflowProperties() => this.IdMappingWorkflowProperties != null && (this.IdMappingWorkflowProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdNamespaceName. 
        /// <para>
        /// The name of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string IdNamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the IdNamespaceName property is set.
        /// </summary>
        internal bool IsSetIdNamespaceName() => this.IdNamespaceName != null;

        /// <summary>
        /// Gets and sets the property InputSourceConfig. 
        /// <para>
        /// A list of <c>InputSource</c> objects, which have the fields <c>InputSourceARN</c>
        /// and <c>SchemaName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<IdNamespaceInputSource> InputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<IdNamespaceInputSource>() : null;

        /// <summary>
        /// Checks to see if the InputSourceConfig property is set.
        /// </summary>
        internal bool IsSetInputSourceConfig() => this.InputSourceConfig != null && (this.InputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to access the resources defined in this <c>IdNamespace</c> on your behalf as part
        /// of a workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
