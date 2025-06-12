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
    /// The detailed data about the current state of this service instance.
    /// </summary>
    public partial class ServiceInstanceState
    {
        private List<string> _lastSuccessfulComponentDeploymentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _lastSuccessfulEnvironmentDeploymentId;
        private string _lastSuccessfulServicePipelineDeploymentId;
        private string _spec;
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property LastSuccessfulComponentDeploymentIds. 
        /// <para>
        /// The IDs for the last successful components deployed for this service instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> LastSuccessfulComponentDeploymentIds
        {
            get { return this._lastSuccessfulComponentDeploymentIds; }
            set { this._lastSuccessfulComponentDeploymentIds = value; }
        }

        // Check to see if LastSuccessfulComponentDeploymentIds property is set
        internal bool IsSetLastSuccessfulComponentDeploymentIds()
        {
            return this._lastSuccessfulComponentDeploymentIds != null && (this._lastSuccessfulComponentDeploymentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulEnvironmentDeploymentId. 
        /// <para>
        /// The ID for the last successful environment deployed for this service instance.
        /// </para>
        /// </summary>
        public string LastSuccessfulEnvironmentDeploymentId
        {
            get { return this._lastSuccessfulEnvironmentDeploymentId; }
            set { this._lastSuccessfulEnvironmentDeploymentId = value; }
        }

        // Check to see if LastSuccessfulEnvironmentDeploymentId property is set
        internal bool IsSetLastSuccessfulEnvironmentDeploymentId()
        {
            return this._lastSuccessfulEnvironmentDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulServicePipelineDeploymentId. 
        /// <para>
        /// The ID for the last successful service pipeline deployed for this service instance.
        /// </para>
        /// </summary>
        public string LastSuccessfulServicePipelineDeploymentId
        {
            get { return this._lastSuccessfulServicePipelineDeploymentId; }
            set { this._lastSuccessfulServicePipelineDeploymentId = value; }
        }

        // Check to see if LastSuccessfulServicePipelineDeploymentId property is set
        internal bool IsSetLastSuccessfulServicePipelineDeploymentId()
        {
            return this._lastSuccessfulServicePipelineDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The service spec that was used to create the service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=51200)]
        public string Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMajorVersion
        {
            get { return this._templateMajorVersion; }
            set { this._templateMajorVersion = value; }
        }

        // Check to see if TemplateMajorVersion property is set
        internal bool IsSetTemplateMajorVersion()
        {
            return this._templateMajorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMinorVersion
        {
            get { return this._templateMinorVersion; }
            set { this._templateMinorVersion = value; }
        }

        // Check to see if TemplateMinorVersion property is set
        internal bool IsSetTemplateMinorVersion()
        {
            return this._templateMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template that was used to create the service instance.
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