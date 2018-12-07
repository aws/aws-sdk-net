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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the EnableAWSOrganizationsAccess operation.
    /// Enable portfolio sharing feature through AWS Organizations. This API will allow Service
    /// Catalog to receive updates on your organization in order to sync your shares with
    /// the current structure. This API can only be called by the master account in the organization.
    /// 
    ///  
    /// <para>
    /// By calling this API Service Catalog will make a call to organizations:EnableAWSServiceAccess
    /// on your behalf so that your shares can be in sync with any changes in your AWS Organizations
    /// structure.
    /// </para>
    /// </summary>
    public partial class EnableAWSOrganizationsAccessRequest : AmazonServiceCatalogRequest
    {

    }
}