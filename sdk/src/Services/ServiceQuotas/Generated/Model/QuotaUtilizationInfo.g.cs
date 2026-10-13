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
    /// Information about a quota's utilization, including the quota code, service information,
    /// current usage, and applied limits.
    /// </summary>
    public partial class QuotaUtilizationInfo
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
        /// Gets and sets the property AppliedValue. 
        /// <para>
        /// The applied value of the quota, which may be higher than the default value if a quota
        /// increase has been requested and approved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000000)]
        public double? AppliedValue { get; set; }

        /// <summary>
        /// Checks to see if the AppliedValue property is set.
        /// </summary>
        internal bool IsSetAppliedValue() => this.AppliedValue.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000000)]
        public double? DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric used to track quota usage.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The quota identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuotaCode { get; set; }

        /// <summary>
        /// Checks to see if the QuotaCode property is set.
        /// </summary>
        internal bool IsSetQuotaCode() => this.QuotaCode != null;

        /// <summary>
        /// Gets and sets the property QuotaName. 
        /// <para>
        /// The quota name.
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
        /// The service identifier.
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
        /// The service name.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Utilization. 
        /// <para>
        /// The utilization percentage of the quota, calculated as (current usage / applied value)
        /// × 100. Values range from 0.0 to 100.0 or higher if usage exceeds the quota limit.
        /// </para>
        /// </summary>
        public double? Utilization { get; set; }

        /// <summary>
        /// Checks to see if the Utilization property is set.
        /// </summary>
        internal bool IsSetUtilization() => this.Utilization.HasValue;
    }
}
