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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Describes IAM Identity Center options for creating an OpenSearch Serverless security
    /// configuration in the form of a key-value map.
    /// </summary>
    public partial class CreateIamIdentityCenterConfigOptions
    {
        /// <summary>
        /// Gets and sets the property GroupAttribute. 
        /// <para>
        /// The group attribute for this IAM Identity Center integration. Defaults to <c>GroupId</c>.
        /// </para>
        /// </summary>
        public IamIdentityCenterGroupAttribute GroupAttribute { get; set; }

        /// <summary>
        /// Checks to see if the GroupAttribute property is set.
        /// </summary>
        internal bool IsSetGroupAttribute() => this.GroupAttribute != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance used to integrate with OpenSearch Serverless.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// The user attribute for this IAM Identity Center integration. Defaults to <c>UserId</c>.
        /// </para>
        /// </summary>
        public IamIdentityCenterUserAttribute UserAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserAttribute property is set.
        /// </summary>
        internal bool IsSetUserAttribute() => this.UserAttribute != null;
    }
}
