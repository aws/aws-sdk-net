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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the EnableAWSServiceAccess operation.
    /// Enables the integration of an Amazon Web Services service (the service that is specified
    /// by <code>ServicePrincipal</code>) with Organizations. When you enable integration,
    /// you allow the specified service to create a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
    /// role</a> in all the accounts in your organization. This allows the service to perform
    /// operations on your behalf in your organization and its accounts.
    /// 
    ///  <important> 
    /// <para>
    /// We recommend that you enable integration between Organizations and the specified Amazon
    /// Web Services service by using the console or commands that are provided by the specified
    /// service. Doing so ensures that the service is aware that it can create the resources
    /// that are required for the integration. How the service creates those resources in
    /// the organization's accounts depends on that service. For more information, see the
    /// documentation for the other Amazon Web Services service.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about enabling services to integrate with Organizations, see
    /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
    /// Organizations with Other Amazon Web Services Services</a> in the <i>Organizations
    /// User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can only call this operation from the organization's management account and only
    /// if the organization has <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">enabled
    /// all features</a>.
    /// </para>
    /// </summary>
    public partial class EnableAWSServiceAccessRequest : AmazonOrganizationsRequest
    {
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal name of the Amazon Web Services service for which you want to
        /// enable integration with your organization. This is typically in the form of a URL,
        /// such as <code> <i>service-abbreviation</i>.amazonaws.com</code>.
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