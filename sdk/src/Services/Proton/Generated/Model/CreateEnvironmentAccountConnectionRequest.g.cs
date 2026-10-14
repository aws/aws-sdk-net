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
    /// Container for the parameters to the CreateEnvironmentAccountConnection operation.
    /// Create an environment account connection in an environment account so that environment
    /// infrastructure resources can be provisioned in the environment account from a management
    /// account. <para> An environment account connection is a secure bi-directional connection
    /// between a <i>management account</i> and an <i>environment account</i> that maintains
    /// authorization and permissions. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>Proton User guide</i>. </para>
    /// </summary>
    public partial class CreateEnvironmentAccountConnectionRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// When included, if two identical requests are made with the same client token, Proton
        /// returns the environment account connection that the first request created.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM service role in the environment account.
        /// Proton uses this role to provision infrastructure resources using CodeBuild-based
        /// provisioning in the associated environment account.
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
        /// directly defined components in the associated environment account. It determines the
        /// scope of infrastructure that a component can provision in the account.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>componentRoleArn</c> to allow directly defined components to be
        /// associated with any environments running in this account.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that's created in the associated management account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property ManagementAccountId. 
        /// <para>
        /// The ID of the management account that accepts or rejects the environment account connection.
        /// You create and manage the Proton environment in this account. If the management account
        /// accepts the environment account connection, Proton can use the associated IAM role
        /// to provision environment infrastructure resources in the associated environment account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManagementAccountId property is set.
        /// </summary>
        internal bool IsSetManagementAccountId() => this.ManagementAccountId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that's created in the environment
        /// account. Proton uses this role to provision infrastructure resources in the associated
        /// environment account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton environment
        /// account connection. A tag is a key-value pair.
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
    }
}
