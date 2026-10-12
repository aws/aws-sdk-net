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
    /// Container for the parameters to the UpdateServiceInstance operation. Update a service
    /// instance. <para> There are a few modes for updating a service instance. The <c>deploymentType</c>
    /// field defines the mode. </para> <note> <para> You can't update a service instance
    /// while its deployment status, or the deployment status of a component attached to it,
    /// is <c>IN_PROGRESS</c>. </para> <para> For more information about components, see <a
    /// href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>. </para> </note>
    /// </summary>
    public partial class UpdateServiceInstanceRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token of the service instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type. It defines the mode for updating a service instance, as follows:
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <c>CURRENT_VERSION</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service instance is deployed and updated with the new spec that
        /// you provide. Only requested parameters are updated. <i>Don’t</i> include major or
        /// minor version parameters when you use this deployment type.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <c>MINOR_VERSION</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service instance is deployed and updated with the published, recommended
        /// (latest) minor version of the current major version in use, by default. You can also
        /// specify a different minor version of the current major version in use.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <c>MAJOR_VERSION</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service instance is deployed and updated with the published, recommended
        /// (latest) major and minor version of the current template, by default. You can specify
        /// a different major version that's higher than the major version in use and a minor
        /// version.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentUpdateType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that the service instance belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The formatted specification that defines the service instance update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateMajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMajorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMajorVersion() => this.TemplateMajorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMinorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMinorVersion() => this.TemplateMinorVersion != null;
    }
}
