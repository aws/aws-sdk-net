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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the EnableAWSOrganizationsAccess operation.
    /// Enable portfolio sharing feature through Organizations. This API will allow Service
    /// Catalog to receive updates on your organization in order to sync your shares with
    /// the current structure. This API can only be called by the management account in the
    /// organization.
    /// 
    ///  
    /// <para>
    /// When you call this API, Service Catalog calls <c>organizations:EnableAWSServiceAccess</c>
    /// on your behalf so that your shares stay in sync with any changes in your Organizations
    /// structure.
    /// </para>
    ///  
    /// <para>
    /// Note that a delegated administrator is not authorized to invoke <c>EnableAWSOrganizationsAccess</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you have previously disabled Organizations access for Service Catalog, and then
    /// enable access again, the portfolio access permissions might not sync with the latest
    /// changes to the organization structure. Specifically, accounts that you removed from
    /// the organization after disabling Service Catalog access, and before you enabled access
    /// again, can retain access to the previously shared portfolio. As a result, an account
    /// that has been removed from the organization might still be able to create or manage
    /// Amazon Web Services resources when it is no longer authorized to do so. Amazon Web
    /// Services is working to resolve this issue.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class EnableAWSOrganizationsAccessRequest : AmazonServiceCatalogRequest
    {

    }
}