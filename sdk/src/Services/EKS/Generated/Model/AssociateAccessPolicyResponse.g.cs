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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the AssociateAccessPolicy operation.
    /// </summary>
    public partial class AssociateAccessPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedAccessPolicy. 
        /// <para>
        /// The <c>AccessPolicy</c> and scope associated to the <c>AccessEntry</c>.
        /// </para>
        /// </summary>
        public AssociatedAccessPolicy AssociatedAccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedAccessPolicy property is set.
        /// </summary>
        internal bool IsSetAssociatedAccessPolicy() => this.AssociatedAccessPolicy != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM principal for the <c>AccessEntry</c>.
        /// </para>
        /// </summary>
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;
    }
}
