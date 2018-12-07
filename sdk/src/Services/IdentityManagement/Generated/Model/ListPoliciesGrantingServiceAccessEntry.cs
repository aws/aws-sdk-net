/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains details about the permissions policies that are attached to the specified
    /// identity (user, group, or role).
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>ListPoliciesGrantingServiceAccess</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ListPoliciesGrantingServiceAccessEntry
    {
        private List<PolicyGrantingServiceAccess> _policies = new List<PolicyGrantingServiceAccess>();
        private string _serviceNamespace;

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// The <code>PoliciesGrantingServiceAccess</code> object that contains details about
        /// the policy.
        /// </para>
        /// </summary>
        public List<PolicyGrantingServiceAccess> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && this._policies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the service that was accessed.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace of a service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_actions-resources-contextkeys.html">Actions,
        /// Resources, and Condition Keys for AWS Services</a> in the <i>IAM User Guide</i>. Choose
        /// the name of the service to view details for that service. In the first paragraph,
        /// find the service prefix. For example, <code>(service prefix: a4b)</code>. For more
        /// information about service namespaces, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

    }
}