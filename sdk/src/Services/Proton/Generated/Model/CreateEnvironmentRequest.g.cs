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
    /// Container for the parameters to the CreateEnvironment operation. Deploy a new environment.
    /// An Proton environment is created from an environment template that defines infrastructure
    /// and resources that can be shared across services. <para> <b>You can provision environments
    /// using the following methods:</b> </para> <ul> <li> <para> Amazon Web Services-managed
    /// provisioning: Proton makes direct calls to provision your resources. </para> </li>
    /// <li> <para> Self-managed provisioning: Proton makes pull requests on your repository
    /// to provide compiled infrastructure as code (IaC) files that your IaC engine uses to
    /// provision resources. </para> </li> </ul> <para> For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-environments.html">Environments</a>
    /// and <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html">Provisioning
    /// methods</a> in the <i>Proton User Guide</i>. </para>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property CodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that allows Proton to provision
        /// infrastructure using CodeBuild-based provisioning on your behalf.
        /// </para>
        ///  
        /// <para>
        /// To use CodeBuild-based provisioning for the environment or for any service instance
        /// running in the environment, specify either the <c>environmentAccountConnectionId</c>
        /// or <c>codebuildRoleArn</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CodebuildRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CodebuildRoleArn property is set.
        /// </summary>
        internal bool IsSetCodebuildRoleArn() => this.CodebuildRoleArn != null;

        /// <summary>
        /// Gets and sets the property ComponentRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that Proton uses when provisioning
        /// directly defined components in this environment. It determines the scope of infrastructure
        /// that a component can provision.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>componentRoleArn</c> to allow directly defined components to be
        /// associated with this environment.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ComponentRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ComponentRoleArn property is set.
        /// </summary>
        internal bool IsSetComponentRoleArn() => this.ComponentRoleArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment that's being created and deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection that you provide if you're provisioning
        /// your environment infrastructure resources to an environment account. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use Amazon Web Services-managed provisioning for the environment, specify either
        /// the <c>environmentAccountConnectionId</c> or <c>protonServiceRoleArn</c> parameter
        /// and omit the <c>provisioningRepository</c> parameter.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentAccountConnectionId property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountConnectionId() => this.EnvironmentAccountConnectionId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Proton service role that allows Proton to make
        /// calls to other services on your behalf.
        /// </para>
        ///  
        /// <para>
        /// To use Amazon Web Services-managed provisioning for the environment, specify either
        /// the <c>environmentAccountConnectionId</c> or <c>protonServiceRoleArn</c> parameter
        /// and omit the <c>provisioningRepository</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ProtonServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ProtonServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetProtonServiceRoleArn() => this.ProtonServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property ProvisioningRepository. 
        /// <para>
        /// The linked repository that you use to host your rendered infrastructure templates
        /// for self-managed provisioning. A linked repository is a repository that has been registered
        /// with Proton. For more information, see <a>CreateRepository</a>.
        /// </para>
        ///  
        /// <para>
        /// To use self-managed provisioning for the environment, specify this parameter and omit
        /// the <c>environmentAccountConnectionId</c> and <c>protonServiceRoleArn</c> parameters.
        /// </para>
        /// </summary>
        public RepositoryBranchInput ProvisioningRepository { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningRepository property is set.
        /// </summary>
        internal bool IsSetProvisioningRepository() => this.ProvisioningRepository != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// A YAML formatted string that provides inputs as defined in the environment template
        /// bundle schema file. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-environments.html">Environments</a>
        /// in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 51200)]
        public string Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton environment.
        /// A tag is a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string TemplateMajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMajorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMajorVersion() => this.TemplateMajorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMinorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMinorVersion() => this.TemplateMinorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the environment template. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-templates.html">Environment
        /// Templates</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
