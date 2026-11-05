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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains details about the permissions policies that are attached to the specified
    /// identity (user, group, or role).
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPoliciesGrantingServiceAccess.html">ListPoliciesGrantingServiceAccess</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ListPoliciesGrantingServiceAccessEntry
    {
        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// The <c>PoliciesGrantingServiceAccess</c> object that contains details about the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyGrantingServiceAccess> Policies { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyGrantingServiceAccess>() : null;

        /// <summary>
        /// Checks to see if the Policies property is set.
        /// </summary>
        internal bool IsSetPolicies() => this.Policies != null && (this.Policies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the service that was accessed.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace of a service, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>Service
        /// Authorization Reference</i>. Choose the name of the service to view details for that
        /// service. In the first paragraph, find the service prefix. For example, <c>(service
        /// prefix: a4b)</c>. For more information about service namespaces, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services service namespaces</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ServiceNamespace { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNamespace property is set.
        /// </summary>
        internal bool IsSetServiceNamespace() => this.ServiceNamespace != null;
    }
}
