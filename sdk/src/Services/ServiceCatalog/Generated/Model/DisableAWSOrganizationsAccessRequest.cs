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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAWSOrganizationsAccess operation.
    /// Disable portfolio sharing through AWS Organizations feature. This feature will not
    /// delete your current shares but it will prevent you from creating new shares throughout
    /// your organization. Current shares will not be in sync with your organization structure
    /// if it changes after calling this API. This API can only be called by the management
    /// account in the organization.
    /// 
    ///  
    /// <para>
    /// This API can't be invoked if there are active delegated administrators in the organization.
    /// </para>
    ///  
    /// <para>
    /// Note that a delegated administrator is not authorized to invoke <code>DisableAWSOrganizationsAccess</code>.
    /// </para>
    /// </summary>
    public partial class DisableAWSOrganizationsAccessRequest : AmazonServiceCatalogRequest
    {

    }
}