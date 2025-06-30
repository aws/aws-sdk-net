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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// access control lists, Organizations policies, IAM permissions boundaries, and STS
    /// assume role policies. It only applies permissions policy logic. For more about the
    /// evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
    /// policies</a> in the <i>IAM User Guide</i>.
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
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Policies that are attached to users and roles as permissions boundaries are not returned.
    /// To view which managed policy is currently used to set the permissions boundary for
    /// a user or role, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
    /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class ListPoliciesGrantingServiceAccessRequest : AmazonIdentityManagementServiceRequest
    {
        private string _arn;
        private string _marker;
        private List<string> _serviceNamespaces = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the IAM identity (user, group, or role) whose policies you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// indicating that the results are truncated. Set it to the value of the <c>Marker</c>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
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
        /// The service namespace for the Amazon Web Services services whose policies you want
        /// to list.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace for a service, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>IAM User
        /// Guide</i>. Choose the name of the service to view details for that service. In the
        /// first paragraph, find the service prefix. For example, <c>(service prefix: a4b)</c>.
        /// For more information about service namespaces, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services service namespaces</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<string> ServiceNamespaces
        {
            get { return this._serviceNamespaces; }
            set { this._serviceNamespaces = value; }
        }

        // Check to see if ServiceNamespaces property is set
        internal bool IsSetServiceNamespaces()
        {
            return this._serviceNamespaces != null && (this._serviceNamespaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}