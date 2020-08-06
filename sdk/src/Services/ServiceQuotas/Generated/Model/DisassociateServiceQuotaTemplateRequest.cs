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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateServiceQuotaTemplate operation.
    /// Disables the Service Quotas template. Once the template is disabled, it does not request
    /// quota increases for new accounts in your organization. Disabling the quota template
    /// does not apply the quota increase requests from the template. 
    /// 
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To enable the quota template, call <a>AssociateServiceQuotaTemplate</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To delete a specific service quota from the template, use <a>DeleteServiceQuotaIncreaseRequestFromTemplate</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateServiceQuotaTemplateRequest : AmazonServiceQuotasRequest
    {

    }
}