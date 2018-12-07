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
    /// Container for the parameters to the ListPoliciesGrantingServiceAccess operation.
    /// Retrieves a list of policies that the IAM identity (user, group, or role) can use
    /// to access each specified service.
    /// 
    ///  <note> 
    /// <para>
    /// This operation does not use other policy types when determining whether a resource
    /// could access a service. These other policy types include resource-based policies,
    /// access control lists, AWS Organizations policies, IAM permissions boundaries, and
    /// AWS STS assume role policies. It only applies permissions policy logic. For more about
    /// the evaluation of policy types, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The list of policies returned by the operation depends on the ARN of the identity
    /// that you provide.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>User</b> – The list of policies includes the managed and inline policies that
    /// are attached to the user directly. The list also includes any additional managed and
    /// inline policies that are attached to the group to which the user belongs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Group</b> – The list of policies includes only the managed and inline policies
    /// that are attached to the group directly. Policies that are attached to the group’s
    /// user are not included.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Role</b> – The list of policies includes only the managed and inline policies
    /// that are attached to the role.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For each managed policy, this operation returns the ARN and policy name. For each
    /// inline policy, it returns the policy name and the entity to which it is attached.
    /// Inline policies do not have an ARN. For more information about these policy types,
    /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Policies that are attached to users and roles as permissions boundaries are not returned.
    /// To view which managed policy is currently used to set the permissions boundary for
    /// a user or role, use the <a>GetUser</a> or <a>GetRole</a> operations.
    /// </para>
    /// </summary>
    public partial class ListPoliciesGrantingServiceAccessRequest : AmazonIdentityManagementServiceRequest
    {
        private string _arn;
        private string _marker;
        private List<string> _serviceNamespaces = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the IAM identity (user, group, or role) whose policies you want to list.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespaces. 
        /// <para>
        /// The service namespace for the AWS services whose policies you want to list.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace for a service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_actions-resources-contextkeys.html">Actions,
        /// Resources, and Condition Keys for AWS Services</a> in the <i>IAM User Guide</i>. Choose
        /// the name of the service to view details for that service. In the first paragraph,
        /// find the service prefix. For example, <code>(service prefix: a4b)</code>. For more
        /// information about service namespaces, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public List<string> ServiceNamespaces
        {
            get { return this._serviceNamespaces; }
            set { this._serviceNamespaces = value; }
        }

        // Check to see if ServiceNamespaces property is set
        internal bool IsSetServiceNamespaces()
        {
            return this._serviceNamespaces != null && this._serviceNamespaces.Count > 0; 
        }

    }
}