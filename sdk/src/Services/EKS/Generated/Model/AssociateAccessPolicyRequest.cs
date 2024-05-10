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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
    /// Container for the parameters to the AssociateAccessPolicy operation.
    /// Associates an access policy and its scope to an access entry. For more information
    /// about associating access policies, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-policies.html">Associating
    /// and disassociating access policies to and from access entries</a> in the <i>Amazon
    /// EKS User Guide</i>.
    /// </summary>
    public partial class AssociateAccessPolicyRequest : AmazonEKSRequest
    {
        private AccessScope _accessScope;
        private string _clusterName;
        private string _policyArn;
        private string _principalArn;

        /// <summary>
        /// Gets and sets the property AccessScope. 
        /// <para>
        /// The scope for the <c>AccessPolicy</c>. You can scope access policies to an entire
        /// cluster or to specific Kubernetes namespaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessScope AccessScope
        {
            get { return this._accessScope; }
            set { this._accessScope = value; }
        }

        // Check to see if AccessScope property is set
        internal bool IsSetAccessScope()
        {
            return this._accessScope != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN of the <c>AccessPolicy</c> that you're associating. For a list of ARNs, use
        /// <c>ListAccessPolicies</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM user or role for the <c>AccessEntry</c>
        /// that you're associating the access policy to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

    }
}