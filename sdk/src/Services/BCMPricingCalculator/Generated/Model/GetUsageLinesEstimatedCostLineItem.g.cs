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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents the estimated cost of a usage line that was priced.
    /// </summary>
    public partial class GetUsageLinesEstimatedCostLineItem
    {
        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        ///  The estimated cost of the usage amount in the request. 
        /// </para>
        /// </summary>
        public GetUsageLinesEstimatedCostEstimatedCost EstimatedCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCost property is set.
        /// </summary>
        internal bool IsSetEstimatedCost() => this.EstimatedCost != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The key of the usage line in the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The operation of the usage line. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code of the usage line. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The usage type of the usage line. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
