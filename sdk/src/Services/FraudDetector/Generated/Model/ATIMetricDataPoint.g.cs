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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The Account Takeover Insights (ATI) model performance metrics data points.
    /// </summary>
    public partial class ATIMetricDataPoint
    {
        /// <summary>
        /// Gets and sets the property Adr. 
        /// <para>
        ///  The anomaly discovery rate. This metric quantifies the percentage of anomalies that
        /// can be detected by the model at the selected score threshold. A lower score threshold
        /// increases the percentage of anomalies captured by the model, but would also require
        /// challenging a larger percentage of login events, leading to a higher customer friction.
        /// 
        /// </para>
        /// </summary>
        public float? Adr { get; set; }

        /// <summary>
        /// Checks to see if the Adr property is set.
        /// </summary>
        internal bool IsSetAdr() => this.Adr.HasValue;

        /// <summary>
        /// Gets and sets the property Atodr. 
        /// <para>
        ///  The account takeover discovery rate. This metric quantifies the percentage of account
        /// compromise events that can be detected by the model at the selected score threshold.
        /// This metric is only available if 50 or more entities with at-least one labeled account
        /// takeover event is present in the ingested dataset. 
        /// </para>
        /// </summary>
        public float? Atodr { get; set; }

        /// <summary>
        /// Checks to see if the Atodr property is set.
        /// </summary>
        internal bool IsSetAtodr() => this.Atodr.HasValue;

        /// <summary>
        /// Gets and sets the property Cr. 
        /// <para>
        ///  The challenge rate. This indicates the percentage of login events that the model
        /// recommends to challenge such as one-time password, multi-factor authentication, and
        /// investigations. 
        /// </para>
        /// </summary>
        public float? Cr { get; set; }

        /// <summary>
        /// Checks to see if the Cr property is set.
        /// </summary>
        internal bool IsSetCr() => this.Cr.HasValue;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        ///  The model's threshold that specifies an acceptable fraud capture rate. For example,
        /// a threshold of 500 means any model score 500 or above is labeled as fraud. 
        /// </para>
        /// </summary>
        public float? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;
    }
}
