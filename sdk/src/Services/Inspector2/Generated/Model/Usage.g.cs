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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains usage information about the cost of Amazon Inspector operation.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider associated with the usage information.
        /// </para>
        /// </summary>
        public CloudProvider CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency type used when calculating usage data.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The estimated monthly cost of Amazon Inspector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? EstimatedMonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyCost() => this.EstimatedMonthlyCost.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total of usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type scan.
        /// </para>
        /// </summary>
        public UsageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
