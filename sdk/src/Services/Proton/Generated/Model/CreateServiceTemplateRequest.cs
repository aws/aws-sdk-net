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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceTemplate operation.
    /// Create a service template. The administrator creates a service template to define
    /// standardized infrastructure and an optional CI/CD service pipeline. Developers, in
    /// turn, select the service template from Proton. If the selected service template includes
    /// a service pipeline definition, they provide a link to their source code repository.
    /// Proton then deploys and manages the infrastructure defined by the selected service
    /// template. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-templates.html">Proton
    /// templates</a> in the <i>Proton User Guide</i>.
    /// </summary>
    public partial class CreateServiceTemplateRequest : AmazonProtonRequest
    {
        private string _description;
        private string _displayName;
        private string _encryptionKey;
        private string _name;
        private Provisioning _pipelineProvisioning;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the service template as displayed in the developer interface.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// A customer provided encryption key that's used to encrypt data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public Provisioning PipelineProvisioning
        {
            get { return this._pipelineProvisioning; }
            set { this._pipelineProvisioning = value; }
        }

        // Check to see if PipelineProvisioning property is set
        internal bool IsSetPipelineProvisioning()
        {
            return this._pipelineProvisioning != null;
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}