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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGeneratedTemplate operation. Updates a generated
    /// template. This can be used to change the name, add and remove resources, refresh resources,
    /// and change the <c>DeletionPolicy</c> and <c>UpdateReplacePolicy</c> settings. You
    /// can check the status of the update to the generated template using the <c>DescribeGeneratedTemplate</c>
    /// API action.
    /// </summary>
    public partial class UpdateGeneratedTemplateRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property AddResources. 
        /// <para>
        /// An optional list of resources to be added to the generated template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<ResourceDefinition> AddResources { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceDefinition>() : null;

        /// <summary>
        /// Checks to see if the AddResources property is set.
        /// </summary>
        internal bool IsSetAddResources() => this.AddResources != null && (this.AddResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string GeneratedTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedTemplateName property is set.
        /// </summary>
        internal bool IsSetGeneratedTemplateName() => this.GeneratedTemplateName != null;

        /// <summary>
        /// Gets and sets the property NewGeneratedTemplateName. 
        /// <para>
        /// An optional new name to assign to the generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NewGeneratedTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the NewGeneratedTemplateName property is set.
        /// </summary>
        internal bool IsSetNewGeneratedTemplateName() => this.NewGeneratedTemplateName != null;

        /// <summary>
        /// Gets and sets the property RefreshAllResources. 
        /// <para>
        /// If <c>true</c>, update the resource properties in the generated template with their
        /// current live state. This feature is useful when the resource properties in your generated
        /// a template does not reflect the live state of the resource properties. This happens
        /// when a user update the resource properties after generating a template.
        /// </para>
        /// </summary>
        public bool? RefreshAllResources { get; set; }

        /// <summary>
        /// Checks to see if the RefreshAllResources property is set.
        /// </summary>
        internal bool IsSetRefreshAllResources() => this.RefreshAllResources.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveResources. 
        /// <para>
        /// A list of logical ids for resources to remove from the generated template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<string> RemoveResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveResources property is set.
        /// </summary>
        internal bool IsSetRemoveResources() => this.RemoveResources != null && (this.RemoveResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The configuration details of the generated template, including the <c>DeletionPolicy</c>
        /// and <c>UpdateReplacePolicy</c>.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TemplateConfiguration property is set.
        /// </summary>
        internal bool IsSetTemplateConfiguration() => this.TemplateConfiguration != null;
    }
}
