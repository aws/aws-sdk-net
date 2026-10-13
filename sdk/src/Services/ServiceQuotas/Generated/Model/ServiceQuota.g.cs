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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about a quota.
    /// </summary>
    public partial class ServiceQuota
    {
        /// <summary>
        /// Gets and sets the property Adjustable. 
        /// <para>
        /// Indicates whether the quota value can be increased.
        /// </para>
        /// </summary>
        public bool? Adjustable { get; set; }

        /// <summary>
        /// Checks to see if the Adjustable property is set.
        /// </summary>
        internal bool IsSetAdjustable() => this.Adjustable.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The quota description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 350)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// The error code and error reason.
        /// </para>
        /// </summary>
        public ErrorReason ErrorReason { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReason property is set.
        /// </summary>
        internal bool IsSetErrorReason() => this.ErrorReason != null;

        /// <summary>
        /// Gets and sets the property GlobalQuota. 
        /// <para>
        /// Indicates whether the quota is global.
        /// </para>
        /// </summary>
        public bool? GlobalQuota { get; set; }

        /// <summary>
        /// Checks to see if the GlobalQuota property is set.
        /// </summary>
        internal bool IsSetGlobalQuota() => this.GlobalQuota.HasValue;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period of time.
        /// </para>
        /// </summary>
        public QuotaPeriod Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property QuotaAppliedAtLevel. 
        /// <para>
        /// Filters the response to return applied quota values for the <c>ACCOUNT</c>, <c>RESOURCE</c>,
        /// or <c>ALL</c> levels. <c>ACCOUNT</c> is the default.
        /// </para>
        /// </summary>
        public AppliedLevelEnum QuotaAppliedAtLevel { get; set; }

        /// <summary>
        /// Checks to see if the QuotaAppliedAtLevel property is set.
        /// </summary>
        internal bool IsSetQuotaAppliedAtLevel() => this.QuotaAppliedAtLevel != null;

        /// <summary>
        /// Gets and sets the property QuotaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota.
        /// </para>
        /// </summary>
        public string QuotaArn { get; set; }

        /// <summary>
        /// Checks to see if the QuotaArn property is set.
        /// </summary>
        internal bool IsSetQuotaArn() => this.QuotaArn != null;

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the quota identifier. To find the quota code for a specific quota, use the
        /// <a>ListServiceQuotas</a> operation, and look for the <c>QuotaCode</c> response in
        /// the output for the quota you want.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuotaCode { get; set; }

        /// <summary>
        /// Checks to see if the QuotaCode property is set.
        /// </summary>
        internal bool IsSetQuotaCode() => this.QuotaCode != null;

        /// <summary>
        /// Gets and sets the property QuotaContext. 
        /// <para>
        /// The context for this service quota.
        /// </para>
        /// </summary>
        public QuotaContextInfo QuotaContext { get; set; }

        /// <summary>
        /// Checks to see if the QuotaContext property is set.
        /// </summary>
        internal bool IsSetQuotaContext() => this.QuotaContext != null;

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// Specifies the quota name.
        /// </para>
        /// </summary>
        public string QuotaName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaName property is set.
        /// </summary>
        internal bool IsSetQuotaName() => this.QuotaName != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service identifier. To find the service code value for an Amazon Web
        /// Services service, use the <a>ListServices</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Specifies the service name.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement.
        /// </para>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property UsageMetric. 
        /// <para>
        /// Information about the measurement.
        /// </para>
        /// </summary>
        public MetricInfo UsageMetric { get; set; }

        /// <summary>
        /// Checks to see if the UsageMetric property is set.
        /// </summary>
        internal bool IsSetUsageMetric() => this.UsageMetric != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The quota value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000000)]
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
