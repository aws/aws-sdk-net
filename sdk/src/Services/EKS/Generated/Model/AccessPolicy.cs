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
    /// An access policy includes permissions that allow Amazon EKS to authorize an IAM principal
    /// to work with Kubernetes objects on your cluster. The policies are managed by Amazon
    /// EKS, but they're not IAM policies. You can't view the permissions in the policies
    /// using the API. The permissions for many of the policies are similar to the Kubernetes
    /// <c>cluster-admin</c>, <c>admin</c>, <c>edit</c>, and <c>view</c> cluster roles. For
    /// more information about these cluster roles, see <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/#user-facing-roles">User-facing
    /// roles</a> in the Kubernetes documentation. To view the contents of the policies, see
    /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/access-policies.html#access-policy-permissions">Access
    /// policy permissions</a> in the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class AccessPolicy
    {
        private string _arn;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the access policy.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access policy.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}