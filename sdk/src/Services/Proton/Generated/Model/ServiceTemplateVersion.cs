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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Detailed data of an Proton service template version resource.
    /// </summary>
    public partial class ServiceTemplateVersion
    {
        private string _arn;
        private List<CompatibleEnvironmentTemplate> _compatibleEnvironmentTemplates = AWSConfigs.InitializeCollections ? new List<CompatibleEnvironmentTemplate>() : null;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastModifiedAt;
        private string _majorVersion;
        private string _minorVersion;
        private string _recommendedMinorVersion;
        private string _schema;
        private TemplateVersionStatus _status;
        private string _statusMessage;
        private List<string> _supportedComponentSources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CompatibleEnvironmentTemplates. 
        /// <para>
        /// An array of compatible environment template names for the major version of a service
        /// template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CompatibleEnvironmentTemplate> CompatibleEnvironmentTemplates
        {
            get { return this._compatibleEnvironmentTemplates; }
            set { this._compatibleEnvironmentTemplates = value; }
        }

        // Check to see if CompatibleEnvironmentTemplates property is set
        internal bool IsSetCompatibleEnvironmentTemplates()
        {
            return this._compatibleEnvironmentTemplates != null && (this._compatibleEnvironmentTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the version of a service template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the version of a service template.
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
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The time when the version of a service template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MajorVersion. 
        /// <para>
        /// The latest major version that's associated with the version of a service template.
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
        /// The minor version of a service template.
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
        /// Gets and sets the property RecommendedMinorVersion. 
        /// <para>
        /// The recommended minor version of the service template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string RecommendedMinorVersion
        {
            get { return this._recommendedMinorVersion; }
            set { this._recommendedMinorVersion = value; }
        }

        // Check to see if RecommendedMinorVersion property is set
        internal bool IsSetRecommendedMinorVersion()
        {
            return this._recommendedMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema of the version of a service template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The service template version status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A service template version status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedComponentSources
        {
            get { return this._supportedComponentSources; }
            set { this._supportedComponentSources = value; }
        }

        // Check to see if SupportedComponentSources property is set
        internal bool IsSetSupportedComponentSources()
        {
            return this._supportedComponentSources != null && (this._supportedComponentSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the version of a service template.
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