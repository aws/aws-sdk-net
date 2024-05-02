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
    /// Container for the parameters to the DisableAWSOrganizationsAccess operation.
    /// Disable portfolio sharing through the Organizations service. This command will not
    /// delete your current shares, but prevents you from creating new shares throughout your
    /// organization. Current shares are not kept in sync with your organization structure
    /// if the structure changes after calling this API. Only the management account in the
    /// organization can call this API.
    /// 
    ///  
    /// <para>
    /// You cannot call this API if there are active delegated administrators in the organization.
    /// </para>
    ///  
    /// <para>
    /// Note that a delegated administrator is not authorized to invoke <c>DisableAWSOrganizationsAccess</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you share an Service Catalog portfolio in an organization within Organizations,
    /// and then disable Organizations access for Service Catalog, the portfolio access permissions
    /// will not sync with the latest changes to the organization structure. Specifically,
    /// accounts that you removed from the organization after disabling Service Catalog access
    /// will retain access to the previously shared portfolio.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DisableAWSOrganizationsAccessRequest : AmazonServiceCatalogRequest
    {

    }
}