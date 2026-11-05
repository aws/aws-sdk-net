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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEnvironmentOperationsRole operation.
    /// <important> <para> The operations role feature of Elastic Beanstalk is in beta release
    /// and is subject to change. </para> </important> <para> Add or change the operations
    /// role used by an environment. After this call is made, Elastic Beanstalk uses the associated
    /// operations role for permissions to downstream services during subsequent calls acting
    /// on this environment. </para>
    /// </summary>
    public partial class AssociateEnvironmentOperationsRoleRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to which to set the operations role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property OperationsRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IAM role to be used as the environment's
        /// operations role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OperationsRole { get; set; }

        /// <summary>
        /// Checks to see if the OperationsRole property is set.
        /// </summary>
        internal bool IsSetOperationsRole() => this.OperationsRole != null;
    }
}
