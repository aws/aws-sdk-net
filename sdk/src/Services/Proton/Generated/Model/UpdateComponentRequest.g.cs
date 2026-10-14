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
    /// Container for the parameters to the UpdateComponent operation. Update a component.
    /// <para> There are a few modes for updating a component. The <c>deploymentType</c> field
    /// defines the mode. </para> <note> <para> You can't update a component while its deployment
    /// status, or the deployment status of a service instance attached to it, is <c>IN_PROGRESS</c>.
    /// </para> </note> <para> For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>. </para>
    /// </summary>
    public partial class UpdateComponentRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the updated component.
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
        /// The deployment type. It defines the mode for updating a component, as follows:
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated. You can only specify <c>description</c> in this mode.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <c>CURRENT_VERSION</c> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the component is deployed and updated with the new <c>serviceSpec</c>,
        /// <c>templateSource</c>, and/or <c>type</c> that you provide. Only requested parameters
        /// are updated.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComponentDeploymentUpdateType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional customer-provided description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want to attach this component to. Don't
        /// specify to keep the component's current service instance attachment. Specify an empty
        /// string to detach the component from the service instance it's attached to. Specify
        /// non-empty values for both <c>serviceInstanceName</c> and <c>serviceName</c> or for
        /// neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <c>serviceInstanceName</c> is associated with. Don't
        /// specify to keep the component's current service instance attachment. Specify an empty
        /// string to detach the component from the service instance it's attached to. Specify
        /// non-empty values for both <c>serviceInstanceName</c> and <c>serviceName</c> or for
        /// neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that you want the component to use to access service inputs. Set
        /// this only when the component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpec property is set.
        /// </summary>
        internal bool IsSetServiceSpec() => this.ServiceSpec != null;

        /// <summary>
        /// Gets and sets the property TemplateFile. 
        /// <para>
        /// A path to the Infrastructure as Code (IaC) file describing infrastructure that a custom
        /// component provisions.
        /// </para>
        ///  <note> 
        /// <para>
        /// Components support a single IaC file, even if you use Terraform as your template language.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string TemplateFile { get; set; }

        /// <summary>
        /// Checks to see if the TemplateFile property is set.
        /// </summary>
        internal bool IsSetTemplateFile() => this.TemplateFile != null;
    }
}
