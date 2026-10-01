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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplate operation. Creates a template in
    /// the Cases domain. This template is used to define the case object model (that is,
    /// to define what data can be captured on cases) in a Cases domain. A template must have
    /// a unique name within a domain, and it must reference existing field IDs and layout
    /// IDs. Additionally, multiple fields with same IDs are not allowed within the same Template.
    /// A template can be either Active or Inactive, as indicated by its status. Inactive
    /// templates cannot be used to create cases. <para> Other template APIs are: </para>
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetTemplate.html">GetTemplate</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_ListTemplates.html">ListTemplates</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_UpdateTemplate.html">UpdateTemplate</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class CreateTemplateRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property LayoutConfiguration. 
        /// <para>
        /// Configuration of layouts associated to the template.
        /// </para>
        /// </summary>
        public LayoutConfiguration LayoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LayoutConfiguration property is set.
        /// </summary>
        internal bool IsSetLayoutConfiguration() => this.LayoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the template. It must be unique per domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequiredFields. 
        /// <para>
        /// A list of fields that must contain a value for a case to be successfully created with
        /// this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<RequiredField> RequiredFields { get; set; } = AWSConfigs.InitializeCollections ? new List<RequiredField>() : null;

        /// <summary>
        /// Checks to see if the RequiredFields property is set.
        /// </summary>
        internal bool IsSetRequiredFields() => this.RequiredFields != null && (this.RequiredFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// A list of case rules (also known as <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">case
        /// field conditions</a>) on a template. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<TemplateRule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<TemplateRule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the template.
        /// </para>
        /// </summary>
        public TemplateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagPropagationConfigurations. 
        /// <para>
        /// Defines tag propagation configuration for resources created within a domain. Tags
        /// specified here will be automatically applied to resources being created for the specified
        /// resource type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<TagPropagationConfiguration> TagPropagationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TagPropagationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TagPropagationConfigurations property is set.
        /// </summary>
        internal bool IsSetTagPropagationConfigurations() => this.TagPropagationConfigurations != null && (this.TagPropagationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
