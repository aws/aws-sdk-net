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
    /// Information about a quota.
    /// </summary>
    public partial class ServiceQuota
    {
        private bool? _adjustable;
        private ErrorReason _errorReason;
        private bool? _globalQuota;
        private QuotaPeriod _period;
        private string _quotaArn;
        private string _quotaCode;
        private string _quotaName;
        private string _serviceCode;
        private string _serviceName;
        private string _unit;
        private MetricInfo _usageMetric;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Adjustable. 
        /// <para>
        /// Indicates whether the quota value can be increased.
        /// </para>
        /// </summary>
        public bool Adjustable
        {
            get { return this._adjustable.GetValueOrDefault(); }
            set { this._adjustable = value; }
        }

        // Check to see if Adjustable property is set
        internal bool IsSetAdjustable()
        {
            return this._adjustable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// The error code and error reason.
        /// </para>
        /// </summary>
        public ErrorReason ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalQuota. 
        /// <para>
        /// Indicates whether the quota is global.
        /// </para>
        /// </summary>
        public bool GlobalQuota
        {
            get { return this._globalQuota.GetValueOrDefault(); }
            set { this._globalQuota = value; }
        }

        // Check to see if GlobalQuota property is set
        internal bool IsSetGlobalQuota()
        {
            return this._globalQuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period of time.
        /// </para>
        /// </summary>
        public QuotaPeriod Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota.
        /// </para>
        /// </summary>
        public string QuotaArn
        {
            get { return this._quotaArn; }
            set { this._quotaArn = value; }
        }

        // Check to see if QuotaArn property is set
        internal bool IsSetQuotaArn()
        {
            return this._quotaArn != null;
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement.
        /// </para>
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property UsageMetric. 
        /// <para>
        /// Information about the measurement.
        /// </para>
        /// </summary>
        public MetricInfo UsageMetric
        {
            get { return this._usageMetric; }
            set { this._usageMetric = value; }
        }

        // Check to see if UsageMetric property is set
        internal bool IsSetUsageMetric()
        {
            return this._usageMetric != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The quota value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000000)]
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}