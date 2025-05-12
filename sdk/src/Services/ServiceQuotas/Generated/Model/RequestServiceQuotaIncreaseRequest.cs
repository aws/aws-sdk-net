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
    /// Container for the parameters to the RequestServiceQuotaIncrease operation.
    /// Submits a quota increase request for the specified quota at the account or resource
    /// level.
    /// </summary>
    public partial class RequestServiceQuotaIncreaseRequest : AmazonServiceQuotasRequest
    {
        private string _contextId;
        private double? _desiredValue;
        private string _quotaCode;
        private string _serviceCode;
        private bool? _supportCaseAllowed;

        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// Specifies the resource with an Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ContextId
        {
            get { return this._contextId; }
            set { this._contextId = value; }
        }

        // Check to see if ContextId property is set
        internal bool IsSetContextId()
        {
            return this._contextId != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredValue. 
        /// <para>
        /// Specifies the new, increased value for the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000000000)]
        public double? DesiredValue
        {
            get { return this._desiredValue; }
            set { this._desiredValue = value; }
        }

        // Check to see if DesiredValue property is set
        internal bool IsSetDesiredValue()
        {
            return this._desiredValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the quota identifier. To find the quota code for a specific quota, use the
        /// <a>ListServiceQuotas</a> operation, and look for the <c>QuotaCode</c> response in
        /// the output for the quota you want.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service identifier. To find the service code value for an Amazon Web
        /// Services service, use the <a>ListServices</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCaseAllowed. 
        /// <para>
        /// Specifies if an Amazon Web Services Support case can be opened for the quota increase
        /// request. This parameter is optional. 
        /// </para>
        ///  
        /// <para>
        /// By default, this flag is set to <c>True</c> and Amazon Web Services may create a support
        /// case for some quota increase requests. You can set this flag to <c>False</c> if you
        /// do not want a support case created when you request a quota increase. If you set the
        /// flag to <c>False</c>, Amazon Web Services does not open a support case and updates
        /// the request status to <c>Not approved</c>. 
        /// </para>
        /// </summary>
        public bool? SupportCaseAllowed
        {
            get { return this._supportCaseAllowed; }
            set { this._supportCaseAllowed = value; }
        }

        // Check to see if SupportCaseAllowed property is set
        internal bool IsSetSupportCaseAllowed()
        {
            return this._supportCaseAllowed.HasValue; 
        }

    }
}