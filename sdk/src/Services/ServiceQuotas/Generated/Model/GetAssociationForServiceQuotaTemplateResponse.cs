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
    /// This is the response object from the GetAssociationForServiceQuotaTemplate operation.
    /// </summary>
    public partial class GetAssociationForServiceQuotaTemplateResponse : AmazonWebServiceResponse
    {
        private ServiceQuotaTemplateAssociationStatus _serviceQuotaTemplateAssociationStatus;

        /// <summary>
        /// Gets and sets the property ServiceQuotaTemplateAssociationStatus. 
        /// <para>
        /// The association status. If the status is <code>ASSOCIATED</code>, the quota increase
        /// requests in the template are automatically applied to new accounts in your organization.
        /// </para>
        /// </summary>
        public ServiceQuotaTemplateAssociationStatus ServiceQuotaTemplateAssociationStatus
        {
            get { return this._serviceQuotaTemplateAssociationStatus; }
            set { this._serviceQuotaTemplateAssociationStatus = value; }
        }

        // Check to see if ServiceQuotaTemplateAssociationStatus property is set
        internal bool IsSetServiceQuotaTemplateAssociationStatus()
        {
            return this._serviceQuotaTemplateAssociationStatus != null;
        }

    }
}