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
    /// Container for the parameters to the CreateServiceTemplateVersion operation.
    /// Create a new major or minor version of a service template. A major version of a service
    /// template is a version that <i>isn't</i> backward compatible. A minor version of a
    /// service template is a version that's backward compatible within its major version.
    /// </summary>
    public partial class CreateServiceTemplateVersionRequest : AmazonProtonRequest
    {
        private string _clientToken;
        private List<CompatibleEnvironmentTemplateInput> _compatibleEnvironmentTemplates = new List<CompatibleEnvironmentTemplateInput>();
        private string _description;
        private string _majorVersion;
        private TemplateVersionSourceInput _source;
        private List<string> _supportedComponentSources = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _templateName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// When included, if two identical requests are made with the same client token, Proton
        /// returns the service template version that the first request created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CompatibleEnvironmentTemplates. 
        /// <para>
        /// An array of environment template objects that are compatible with the new service
        /// template version. A service instance based on this service template version can run
        /// in environments based on compatible templates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<CompatibleEnvironmentTemplateInput> CompatibleEnvironmentTemplates
        {
            get { return this._compatibleEnvironmentTemplates; }
            set { this._compatibleEnvironmentTemplates = value; }
        }

        // Check to see if CompatibleEnvironmentTemplates property is set
        internal bool IsSetCompatibleEnvironmentTemplates()
        {
            return this._compatibleEnvironmentTemplates != null && this._compatibleEnvironmentTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new version of a service template.
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
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// To create a new minor version of the service template, include a <code>major Version</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a new major and minor version of the service template, <i>exclude</i> <code>major
        /// Version</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string MajorVersion
        {
            get { return this._majorVersion; }
            set { this._majorVersion = value; }
        }

        // Check to see if MajorVersion property is set
        internal bool IsSetMajorVersion()
        {
            return this._majorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// An object that includes the template bundle S3 bucket path and name for the new version
        /// of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateVersionSourceInput Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedComponentSources. 
        /// <para>
        /// An array of supported component sources. Components with supported sources can be
        /// attached to service instances based on this service template version.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> SupportedComponentSources
        {
            get { return this._supportedComponentSources; }
            set { this._supportedComponentSources = value; }
        }

        // Check to see if SupportedComponentSources property is set
        internal bool IsSetSupportedComponentSources()
        {
            return this._supportedComponentSources != null && this._supportedComponentSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton service
        /// template version. A tag is a key-value pair.
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

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}