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
    /// Container for the parameters to the UpdateEnvironmentAccountConnection operation.
    /// In an environment account, update an environment account connection to use a new IAM
    /// role. <para> For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>Proton User guide</i>. </para>
    /// </summary>
    public partial class UpdateEnvironmentAccountConnectionRequest : AmazonProtonRequest
    {
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
        /// The environment account connection must have a <c>componentRoleArn</c> to allow directly
        /// defined components to be associated with any environments running in the account.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment account connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that's associated with the
        /// environment account connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
