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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the set of parameters needed to perform aggregation in the aggregate transform.
    /// </summary>
    public partial class AggregateOperation
    {
        /// <summary>
        /// Gets and sets the property AggFunc. 
        /// <para>
        /// Specifies the aggregation function to apply.
        /// </para>
        ///  
        /// <para>
        /// Possible aggregation functions include: avg countDistinct, count, first, last, kurtosis,
        /// max, min, skewness, stddev_samp, stddev_pop, sum, sumDistinct, var_samp, var_pop
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AggFunction AggFunc { get; set; }

        /// <summary>
        /// Checks to see if the AggFunc property is set.
        /// </summary>
        internal bool IsSetAggFunc() => this.AggFunc != null;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// Specifies the column on the data set on which the aggregation function will be applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Column { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null && (this.Column.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
