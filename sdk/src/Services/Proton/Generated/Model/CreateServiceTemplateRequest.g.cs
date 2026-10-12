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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceTemplate operation. Create a service
    /// template. The administrator creates a service template to define standardized infrastructure
    /// and an optional CI/CD service pipeline. Developers, in turn, select the service template
    /// from Proton. If the selected service template includes a service pipeline definition,
    /// they provide a link to their source code repository. Proton then deploys and manages
    /// the infrastructure defined by the selected service template. For more information,
    /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-templates.html">Proton
    /// templates</a> in the <i>Proton User Guide</i>.
    /// </summary>
    public partial class CreateServiceTemplateRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the service template as displayed in the developer interface.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// A customer provided encryption key that's used to encrypt data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PipelineProvisioning. 
        /// <para>
        /// By default, Proton provides a service pipeline for your service. When this parameter
        /// is included, it indicates that an Proton service pipeline <i>isn't</i> provided for
        /// your service. After it's included, it <i>can't</i> be changed. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-template-authoring.html#ag-template-bundles">Template
        /// bundles</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        public Provisioning PipelineProvisioning { get; set; }

        /// <summary>
        /// Checks to see if the PipelineProvisioning property is set.
        /// </summary>
        internal bool IsSetPipelineProvisioning() => this.PipelineProvisioning != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton service
        /// template. A tag is a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
