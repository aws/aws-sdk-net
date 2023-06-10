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
    /// Container for the parameters to the UpdateComponent operation.
    /// Update a component.
    /// 
    ///  
    /// <para>
    /// There are a few modes for updating a component. The <code>deploymentType</code> field
    /// defines the mode.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't update a component while its deployment status, or the deployment status
    /// of a service instance attached to it, is <code>IN_PROGRESS</code>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateComponentRequest : AmazonProtonRequest
    {
        private string _clientToken;
        private ComponentDeploymentUpdateType _deploymentType;
        private string _description;
        private string _name;
        private string _serviceInstanceName;
        private string _serviceName;
        private string _serviceSpec;
        private string _templateFile;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for the updated component.
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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type. It defines the mode for updating a component, as follows:
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <code>NONE</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated. You can only specify <code>description</code> in this mode.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>CURRENT_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the component is deployed and updated with the new <code>serviceSpec</code>,
        /// <code>templateSource</code>, and/or <code>type</code> that you provide. Only requested
        /// parameters are updated.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComponentDeploymentUpdateType DeploymentType
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional customer-provided description of the component.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component to update.
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
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want to attach this component to. Don't
        /// specify to keep the component's current service instance attachment. Specify an empty
        /// string to detach the component from the service instance it's attached to. Specify
        /// non-empty values for both <code>serviceInstanceName</code> and <code>serviceName</code>
        /// or for neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <code>serviceInstanceName</code> is associated with.
        /// Don't specify to keep the component's current service instance attachment. Specify
        /// an empty string to detach the component from the service instance it's attached to.
        /// Specify non-empty values for both <code>serviceInstanceName</code> and <code>serviceName</code>
        /// or for neither of them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that you want the component to use to access service inputs. Set
        /// this only when the component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string ServiceSpec
        {
            get { return this._serviceSpec; }
            set { this._serviceSpec = value; }
        }

        // Check to see if ServiceSpec property is set
        internal bool IsSetServiceSpec()
        {
            return this._serviceSpec != null;
        }

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
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string TemplateFile
        {
            get { return this._templateFile; }
            set { this._templateFile = value; }
        }

        // Check to see if TemplateFile property is set
        internal bool IsSetTemplateFile()
        {
            return this._templateFile != null;
        }

    }
}