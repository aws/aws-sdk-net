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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Update an environment.
    /// 
    ///  
    /// <para>
    /// If the environment is associated with an environment account connection, <i>don't</i>
    /// update or include the <code>protonServiceRoleArn</code> and <code>provisioningRepository</code>
    /// parameter to update or connect to an environment account connection.
    /// </para>
    ///  
    /// <para>
    /// You can only update to a new environment account connection if that connection was
    /// created in the same environment account that the current environment account connection
    /// was created in. The account connection must also be associated with the current environment.
    /// </para>
    ///  
    /// <para>
    /// If the environment <i>isn't</i> associated with an environment account connection,
    /// <i>don't</i> update or include the <code>environmentAccountConnectionId</code> parameter.
    /// You <i>can't</i> update or connect the environment to an environment account connection
    /// if it <i>isn't</i> already associated with an environment connection.
    /// </para>
    ///  
    /// <para>
    /// You can update either the <code>environmentAccountConnectionId</code> or <code>protonServiceRoleArn</code>
    /// parameter and value. You can’t update both.
    /// </para>
    ///  
    /// <para>
    /// If the environment was configured for Amazon Web Services-managed provisioning, omit
    /// the <code>provisioningRepository</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// If the environment was configured for self-managed provisioning, specify the <code>provisioningRepository</code>
    /// parameter and omit the <code>protonServiceRoleArn</code> and <code>environmentAccountConnectionId</code>
    /// parameters.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-environments.html">Environments</a>
    /// and <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html">Provisioning
    /// methods</a> in the <i>Proton User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// There are four modes for updating an environment. The <code>deploymentType</code>
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
    /// In this mode, the environment is deployed and updated with the new spec that you provide.
    /// Only requested parameters are updated. <i>Don’t</i> include minor or major version
    /// parameters when you use this <code>deployment-type</code>.
    /// </para>
    ///  </dd> <dt/> <dd> 
    /// <para>
    ///  <code>MINOR_VERSION</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, the environment is deployed and updated with the published, recommended
    /// (latest) minor version of the current major version in use, by default. You can also
    /// specify a different minor version of the current major version in use.
    /// </para>
    ///  </dd> <dt/> <dd> 
    /// <para>
    ///  <code>MAJOR_VERSION</code> 
    /// </para>
    ///  
    /// <para>
    /// In this mode, the environment is deployed and updated with the published, recommended
    /// (latest) major and minor version of the current template, by default. You can also
    /// specify a different major version that's higher than the major version in use and
    /// a minor version.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonProtonRequest
    {
        private string _codebuildRoleArn;
        private string _componentRoleArn;
        private DeploymentUpdateType _deploymentType;
        private string _description;
        private string _environmentAccountConnectionId;
        private string _name;
        private string _protonServiceRoleArn;
        private RepositoryBranchInput _provisioningRepository;
        private string _spec;
        private string _templateMajorVersion;
        private string _templateMinorVersion;

        /// <summary>
        /// Gets and sets the property CodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that allows Proton to provision
        /// infrastructure using CodeBuild-based provisioning on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CodebuildRoleArn
        {
            get { return this._codebuildRoleArn; }
            set { this._codebuildRoleArn = value; }
        }

        // Check to see if CodebuildRoleArn property is set
        internal bool IsSetCodebuildRoleArn()
        {
            return this._codebuildRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that Proton uses when provisioning
        /// directly defined components in this environment. It determines the scope of infrastructure
        /// that a component can provision.
        /// </para>
        ///  
        /// <para>
        /// The environment must have a <code>componentRoleArn</code> to allow directly defined
        /// components to be associated with the environment.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ComponentRoleArn
        {
            get { return this._componentRoleArn; }
            set { this._componentRoleArn = value; }
        }

        // Check to see if ComponentRoleArn property is set
        internal bool IsSetComponentRoleArn()
        {
            return this._componentRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// There are four modes for updating an environment. The <code>deploymentType</code>
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
        /// In this mode, the environment is deployed and updated with the new spec that you provide.
        /// Only requested parameters are updated. <i>Don’t</i> include major or minor version
        /// parameters when you use this <code>deployment-type</code>.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MINOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the environment is deployed and updated with the published, recommended
        /// (latest) minor version of the current major version in use, by default. You can also
        /// specify a different minor version of the current major version in use.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MAJOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the environment is deployed and updated with the published, recommended
        /// (latest) major and minor version of the current template, by default. You can also
        /// specify a different major version that is higher than the major version in use and
        /// a minor version (optional).
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment update.
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
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection.
        /// </para>
        ///  
        /// <para>
        /// You can only update to a new environment account connection if it was created in the
        /// same environment account that the current environment account connection was created
        /// in and is associated with the current environment.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId
        {
            get { return this._environmentAccountConnectionId; }
            set { this._environmentAccountConnectionId = value; }
        }

        // Check to see if EnvironmentAccountConnectionId property is set
        internal bool IsSetEnvironmentAccountConnectionId()
        {
            return this._environmentAccountConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment to update.
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
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Proton service role that allows Proton to make
        /// API calls to other services your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ProtonServiceRoleArn
        {
            get { return this._protonServiceRoleArn; }
            set { this._protonServiceRoleArn = value; }
        }

        // Check to see if ProtonServiceRoleArn property is set
        internal bool IsSetProtonServiceRoleArn()
        {
            return this._protonServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRepository. 
        /// <para>
        /// The linked repository that you use to host your rendered infrastructure templates
        /// for self-managed provisioning. A linked repository is a repository that has been registered
        /// with Proton. For more information, see <a>CreateRepository</a>.
        /// </para>
        /// </summary>
        public RepositoryBranchInput ProvisioningRepository
        {
            get { return this._provisioningRepository; }
            set { this._provisioningRepository = value; }
        }

        // Check to see if ProvisioningRepository property is set
        internal bool IsSetProvisioningRepository()
        {
            return this._provisioningRepository != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The formatted specification that defines the update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
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
        /// The major version of the environment to update.
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
        /// The minor version of the environment to update.
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