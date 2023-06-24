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
    /// Container for the parameters to the CreateEnvironmentAccountConnection operation.
    /// Create an environment account connection in an environment account so that environment
    /// infrastructure resources can be provisioned in the environment account from a management
    /// account.
    /// 
    ///  
    /// <para>
    /// An environment account connection is a secure bi-directional connection between a
    /// <i>management account</i> and an <i>environment account</i> that maintains authorization
    /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>Proton User guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEnvironmentAccountConnectionRequest : AmazonProtonRequest
    {
        private string _clientToken;
        private string _codebuildRoleArn;
        private string _componentRoleArn;
        private string _environmentName;
        private string _managementAccountId;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// When included, if two identical requests are made with the same client token, Proton
        /// returns the environment account connection that the first request created.
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
        /// Gets and sets the property CodebuildRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM service role in the environment account.
        /// Proton uses this role to provision infrastructure resources using CodeBuild-based
        /// provisioning in the associated environment account.
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
        /// directly defined components in the associated environment account. It determines the
        /// scope of infrastructure that a component can provision in the account.
        /// </para>
        ///  
        /// <para>
        /// You must specify <code>componentRoleArn</code> to allow directly defined components
        /// to be associated with any environments running in this account.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that's created in the associated management account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ManagementAccountId. 
        /// <para>
        /// The ID of the management account that accepts or rejects the environment account connection.
        /// You create and manage the Proton environment in this account. If the management account
        /// accepts the environment account connection, Proton can use the associated IAM role
        /// to provision environment infrastructure resources in the associated environment account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagementAccountId
        {
            get { return this._managementAccountId; }
            set { this._managementAccountId = value; }
        }

        // Check to see if ManagementAccountId property is set
        internal bool IsSetManagementAccountId()
        {
            return this._managementAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that's created in the environment
        /// account. Proton uses this role to provision infrastructure resources in the associated
        /// environment account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}