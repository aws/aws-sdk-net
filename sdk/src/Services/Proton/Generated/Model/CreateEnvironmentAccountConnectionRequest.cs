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
    /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>AWS Proton Administrator guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEnvironmentAccountConnectionRequest : AmazonProtonRequest
    {
        private string _clientToken;
        private string _environmentName;
        private string _managementAccountId;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// When included, if two identicial requests are made with the same client token, AWS
        /// Proton returns the environment account connection that the first request created.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the AWS Proton environment that's created in the associated management
        /// account.
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
        /// You create an manage the AWS Proton environment in this account. If the management
        /// account accepts the environment account connection, AWS Proton can use the associated
        /// IAM role to provision environment infrastructure resources in the associated environment
        /// account.
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
        /// account. AWS Proton uses this role to provision infrastructure resources in the associated
        /// environment account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

    }
}