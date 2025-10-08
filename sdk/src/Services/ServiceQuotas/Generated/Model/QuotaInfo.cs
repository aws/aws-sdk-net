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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Information on your Service Quotas for <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
    /// Quotas Automatic Management</a>. Automatic Management monitors your Service Quotas
    /// utilization and notifies you before you run out of your allocated quotas.
    /// </summary>
    public partial class QuotaInfo
    {
        private string _quotaCode;
        private string _quotaName;

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The Service Quotas code for the Amazon Web Services service monitored with Automatic
        /// Management.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QuotaCode
        {
            get { return this._quotaCode; }
            set { this._quotaCode = value; }
        }

        // Check to see if QuotaCode property is set
        internal bool IsSetQuotaCode()
        {
            return this._quotaCode != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// The Service Quotas name for the Amazon Web Services service monitored with Automatic
        /// Management.
        /// </para>
        /// </summary>
        public string QuotaName
        {
            get { return this._quotaName; }
            set { this._quotaName = value; }
        }

        // Check to see if QuotaName property is set
        internal bool IsSetQuotaName()
        {
            return this._quotaName != null;
        }

    }
}