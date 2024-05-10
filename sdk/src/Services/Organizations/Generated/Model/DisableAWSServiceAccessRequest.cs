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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAWSServiceAccess operation.
    /// Disables the integration of an Amazon Web Services service (the service that is specified
    /// by <c>ServicePrincipal</c>) with Organizations. When you disable integration, the
    /// specified service no longer can create a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
    /// role</a> in <i>new</i> accounts in your organization. This means the service can't
    /// perform operations on your behalf on any new accounts in your organization. The service
    /// can still perform operations in older accounts until the service completes its clean-up
    /// from Organizations.
    /// 
    ///  <important> 
    /// <para>
    /// We <b> <i>strongly recommend</i> </b> that you don't use this command to disable integration
    /// between Organizations and the specified Amazon Web Services service. Instead, use
    /// the console or commands that are provided by the specified service. This lets the
    /// trusted service perform any required initialization when enabling trusted access,
    /// such as creating any required resources and any required clean up of resources when
    /// disabling trusted access. 
    /// </para>
    ///  
    /// <para>
    /// For information about how to disable trusted service access to your organization using
    /// the trusted service, see the <b>Learn more</b> link under the <b>Supports Trusted
    /// Access</b> column at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services_list.html">Amazon
    /// Web Services services that you can use with Organizations</a>. on this page.
    /// </para>
    ///  
    /// <para>
    /// If you disable access by using this command, it causes the following actions to occur:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The service can no longer create a service-linked role in the accounts in your organization.
    /// This means that the service can't perform operations on your behalf on any new accounts
    /// in your organization. The service can still perform operations in older accounts until
    /// the service completes its clean-up from Organizations. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The service can no longer perform tasks in the member accounts in the organization,
    /// unless those operations are explicitly permitted by the IAM policies that are attached
    /// to your roles. This includes any data aggregation from the member accounts to the
    /// management account, or to a delegated administrator account, where relevant.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Some services detect this and clean up any remaining data or resources related to
    /// the integration, while other services stop accessing the organization but leave any
    /// historical data and configuration in place to support a possible re-enabling of the
    /// integration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Using the other service's console or commands to disable the integration ensures that
    /// the other service is aware that it can clean up any resources that are required only
    /// for the integration. How the service cleans up its resources in the organization's
    /// accounts depends on that service. For more information, see the documentation for
    /// the other Amazon Web Services service. 
    /// </para>
    ///  </important> 
    /// <para>
    /// After you perform the <c>DisableAWSServiceAccess</c> operation, the specified service
    /// can no longer perform operations in your organization's accounts 
    /// </para>
    ///  
    /// <para>
    /// For more information about integrating other services with Organizations, including
    /// the list of services that work with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Using
    /// Organizations with other Amazon Web Services services</a> in the <i>Organizations
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account.
    /// </para>
    /// </summary>
    public partial class DisableAWSServiceAccessRequest : AmazonOrganizationsRequest
    {
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal name of the Amazon Web Services service for which you want to
        /// disable integration with your organization. This is typically in the form of a URL,
        /// such as <c> <i>service-abbreviation</i>.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

    }
}