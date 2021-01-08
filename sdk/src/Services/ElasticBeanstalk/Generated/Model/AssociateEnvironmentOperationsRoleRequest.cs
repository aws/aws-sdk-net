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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEnvironmentOperationsRole operation.
    /// Add or change the operations role used by an environment. After this call is made,
    /// Elastic Beanstalk uses the associated operations role for permissions to downstream
    /// services during subsequent calls acting on this environment. For more information,
    /// see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
    /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
    /// </summary>
    public partial class AssociateEnvironmentOperationsRoleRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentName;
        private string _operationsRole;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to which to set the operations role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=40)]
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
        /// Gets and sets the property OperationsRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IAM role to be used as the environment's
        /// operations role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OperationsRole
        {
            get { return this._operationsRole; }
            set { this._operationsRole = value; }
        }

        // Check to see if OperationsRole property is set
        internal bool IsSetOperationsRole()
        {
            return this._operationsRole != null;
        }

    }
}