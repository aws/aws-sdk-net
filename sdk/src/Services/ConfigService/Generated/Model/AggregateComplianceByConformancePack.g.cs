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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides aggregate compliance of the conformance pack. Indicates whether a conformance
    /// pack is compliant based on the name of the conformance pack, account ID, and region.
    /// 
    ///  
    /// <para>
    /// A conformance pack is compliant if all of the rules in a conformance packs are compliant.
    /// It is noncompliant if any of the rules are not compliant. The compliance status of
    /// a conformance pack is INSUFFICIENT_DATA only if all rules within a conformance pack
    /// cannot be evaluated due to insufficient data. If some of the rules in a conformance
    /// pack are compliant but the compliance status of other rules in that same conformance
    /// pack is INSUFFICIENT_DATA, the conformance pack shows compliant.
    /// </para>
    /// </summary>
    public partial class AggregateComplianceByConformancePack
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID of the source account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The source Amazon Web Services Region from where the data is aggregated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The compliance status of the conformance pack.
        /// </para>
        /// </summary>
        public AggregateConformancePackCompliance Compliance { get; set; }

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null;

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// The name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackName property is set.
        /// </summary>
        internal bool IsSetConformancePackName() => this.ConformancePackName != null;
    }
}
