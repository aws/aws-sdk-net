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
    /// Container for the parameters to the RegisterDelegatedAdministrator operation.
    /// Enables the specified member account to administer the Organizations features of the
    /// specified Amazon Web Services service. It grants read-only access to Organizations
    /// service data. The account still requires IAM permissions to access and administer
    /// the Amazon Web Services service.
    /// 
    ///  
    /// <para>
    /// You can run this action only for Amazon Web Services services that support this feature.
    /// For a current list of services that support it, see the column <i>Supports Delegated
    /// Administrator</i> in the table at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services_list.html">Amazon
    /// Web Services Services that you can use with Organizations</a> in the <i>Organizations
    /// User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account.
    /// </para>
    /// </summary>
    public partial class RegisterDelegatedAdministratorRequest : AmazonOrganizationsRequest
    {
        private string _accountId;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID number of the member account in the organization to register as a delegated
        /// administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal of the Amazon Web Services service for which you want to make
        /// the member account a delegated administrator.
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