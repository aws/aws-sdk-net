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
    /// Container for the parameters to the UpdateServiceTemplateVersion operation.
    /// Update a major or minor version of a service template.
    /// </summary>
    public partial class UpdateServiceTemplateVersionRequest : AmazonProtonRequest
    {
        private List<CompatibleEnvironmentTemplateInput> _compatibleEnvironmentTemplates = new List<CompatibleEnvironmentTemplateInput>();
        private string _description;
        private string _majorVersion;
        private string _minorVersion;
        private TemplateVersionStatus _status;
        private List<string> _supportedComponentSources = new List<string>();
        private string _templateName;

        /// <summary>
        /// Gets and sets the property CompatibleEnvironmentTemplates. 
        /// <para>
        /// An array of environment template objects that are compatible with this service template
        /// version. A service instance based on this service template version can run in environments
        /// based on compatible templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// A description of a service template version to update.
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
        /// To update a major version of a service template, include <code>major Version</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
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
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// To update a minor version of a service template, include <code>minorVersion</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string MinorVersion
        {
            get { return this._minorVersion; }
            set { this._minorVersion = value; }
        }

        // Check to see if MinorVersion property is set
        internal bool IsSetMinorVersion()
        {
            return this._minorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service template minor version to update.
        /// </para>
        /// </summary>
        public TemplateVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedComponentSources. 
        /// <para>
        /// An array of supported component sources. Components with supported sources can be
        /// attached to service instances based on this service template version.
        /// </para>
        ///  <note> 
        /// <para>
        /// A change to <code>supportedComponentSources</code> doesn't impact existing component
        /// attachments to instances based on this template version. A change only affects later
        /// associations.
        /// </para>
        ///  </note> 
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