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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
    /// Container for the parameters to the UpdateGeneratedTemplate operation.
    /// Updates a generated template. This can be used to change the name, add and remove
    /// resources, refresh resources, and change the <c>DeletionPolicy</c> and <c>UpdateReplacePolicy</c>
    /// settings. You can check the status of the update to the generated template using the
    /// <c>DescribeGeneratedTemplate</c> API action.
    /// </summary>
    public partial class UpdateGeneratedTemplateRequest : AmazonCloudFormationRequest
    {
        private List<ResourceDefinition> _addResources = AWSConfigs.InitializeCollections ? new List<ResourceDefinition>() : null;
        private string _generatedTemplateName;
        private string _newGeneratedTemplateName;
        private bool? _refreshAllResources;
        private List<string> _removeResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TemplateConfiguration _templateConfiguration;

        /// <summary>
        /// Gets and sets the property AddResources. 
        /// <para>
        /// An optional list of resources to be added to the generated template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<ResourceDefinition> AddResources
        {
            get { return this._addResources; }
            set { this._addResources = value; }
        }

        // Check to see if AddResources property is set
        internal bool IsSetAddResources()
        {
            return this._addResources != null && (this._addResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GeneratedTemplateName
        {
            get { return this._generatedTemplateName; }
            set { this._generatedTemplateName = value; }
        }

        // Check to see if GeneratedTemplateName property is set
        internal bool IsSetGeneratedTemplateName()
        {
            return this._generatedTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property NewGeneratedTemplateName. 
        /// <para>
        /// An optional new name to assign to the generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NewGeneratedTemplateName
        {
            get { return this._newGeneratedTemplateName; }
            set { this._newGeneratedTemplateName = value; }
        }

        // Check to see if NewGeneratedTemplateName property is set
        internal bool IsSetNewGeneratedTemplateName()
        {
            return this._newGeneratedTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshAllResources. 
        /// <para>
        /// If <c>true</c>, update the resource properties in the generated template with their
        /// current live state. This feature is useful when the resource properties in your generated
        /// a template does not reflect the live state of the resource properties. This happens
        /// when a user update the resource properties after generating a template.
        /// </para>
        /// </summary>
        public bool? RefreshAllResources
        {
            get { return this._refreshAllResources; }
            set { this._refreshAllResources = value; }
        }

        // Check to see if RefreshAllResources property is set
        internal bool IsSetRefreshAllResources()
        {
            return this._refreshAllResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveResources. 
        /// <para>
        /// A list of logical ids for resources to remove from the generated template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> RemoveResources
        {
            get { return this._removeResources; }
            set { this._removeResources = value; }
        }

        // Check to see if RemoveResources property is set
        internal bool IsSetRemoveResources()
        {
            return this._removeResources != null && (this._removeResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The configuration details of the generated template, including the <c>DeletionPolicy</c>
        /// and <c>UpdateReplacePolicy</c>.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

    }
}