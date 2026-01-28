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
    /// Information about a quota's utilization, including the quota code, service information,
    /// current usage, and applied limits.
    /// </summary>
    public partial class QuotaUtilizationInfo
    {
        private bool? _adjustable;
        private double? _appliedValue;
        private double? _defaultValue;
        private string _awsNamespace;
        private string _quotaCode;
        private string _quotaName;
        private string _serviceCode;
        private string _serviceName;
        private double? _utilization;

        /// <summary>
        /// Gets and sets the property Adjustable. 
        /// <para>
        /// Indicates whether the quota value can be increased.
        /// </para>
        /// </summary>
        public bool? Adjustable
        {
            get { return this._adjustable; }
            set { this._adjustable = value; }
        }

        // Check to see if Adjustable property is set
        internal bool IsSetAdjustable()
        {
            return this._adjustable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppliedValue. 
        /// <para>
        /// The applied value of the quota, which may be higher than the default value if a quota
        /// increase has been requested and approved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000000)]
        public double? AppliedValue
        {
            get { return this._appliedValue; }
            set { this._appliedValue = value; }
        }

        // Check to see if AppliedValue property is set
        internal bool IsSetAppliedValue()
        {
            return this._appliedValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000000)]
        public double? DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric used to track quota usage.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The quota identifier.
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
        /// The quota name.
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

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The service name.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Utilization. 
        /// <para>
        /// The utilization percentage of the quota, calculated as (current usage / applied value)
        /// × 100. Values range from 0.0 to 100.0 or higher if usage exceeds the quota limit.
        /// </para>
        /// </summary>
        public double? Utilization
        {
            get { return this._utilization; }
            set { this._utilization = value; }
        }

        // Check to see if Utilization property is set
        internal bool IsSetUtilization()
        {
            return this._utilization.HasValue; 
        }

    }
}