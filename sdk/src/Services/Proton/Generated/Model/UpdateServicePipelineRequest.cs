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
    /// Container for the parameters to the UpdateServicePipeline operation.
    /// Update the service pipeline.
    /// 
    ///  
    /// <para>
    /// There are four modes for updating a service pipeline. The <code>deploymentType</code>
    /// field defines the mode.
    /// </para>
    ///  <dl> <dt/> <dd> 
    /// <para>
    ///  <code>NONE</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
    /// are updated.
    /// </para>
    ///  </dd> <dt/> <dd> 
    /// <para>
    ///  <code>CURRENT_VERSION</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, the service pipeline is deployed and updated with the new spec that
    /// you provide. Only requested parameters are updated. <i>Don’t</i> include major or
    /// minor version parameters when you use this <code>deployment-type</code>.
    /// </para>
    ///  </dd> <dt/> <dd> 
    /// <para>
    ///  <code>MINOR_VERSION</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, the service pipeline is deployed and updated with the published, recommended
    /// (latest) minor version of the current major version in use, by default. You can specify
    /// a different minor version of the current major version in use.
    /// </para>
    ///  </dd> <dt/> <dd> 
    /// <para>
    ///  <code>MAJOR_VERSION</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, the service pipeline is deployed and updated with the published, recommended
    /// (latest) major and minor version of the current template by default. You can specify
    /// a different major version that's higher than the major version in use and a minor
    /// version.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class UpdateServicePipelineRequest : AmazonProtonRequest
    {
        private DeploymentUpdateType _deploymentType;
        private string _serviceName;
        private string _spec;
        private string _templateMajorVersion;
        private string _templateMinorVersion;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type.
        /// </para>
        ///  
        /// <para>
        /// There are four modes for updating a service pipeline. The <code>deploymentType</code>
        /// field defines the mode.
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <code>NONE</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>CURRENT_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the new spec that
        /// you provide. Only requested parameters are updated. <i>Don’t</i> include major or
        /// minor version parameters when you use this <code>deployment-type</code>.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MINOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the published, recommended
        /// (latest) minor version of the current major version in use, by default. You can specify
        /// a different minor version of the current major version in use.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MAJOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the published, recommended
        /// (latest) major and minor version of the current template, by default. You can specify
        /// a different major version that's higher than the major version in use and a minor
        /// version.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentUpdateType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service to that the pipeline is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The spec for the service pipeline to update.
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
        /// The major version of the service template that was used to create the service that
        /// the pipeline is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// The minor version of the service template that was used to create the service that
        /// the pipeline is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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

    }
}