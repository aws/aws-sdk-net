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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// A filter used to search for Amazon Braket hybrid jobs. You can combine multiple filters
    /// in a single request, except that <c>jobArn</c> cannot be combined with any other filter.
    /// </summary>
    public partial class SearchJobsFilter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hybrid job parameter to filter based on. Supported filter names:
        /// </para>
        ///  
        /// <para>
        ///  <c>jobArn</c> — Filter by the job ARN. Supports the <c>EQUAL</c> operator only. Cannot
        /// be combined with other filters.
        /// </para>
        ///  
        /// <para>
        ///  <c>jobName</c> — Filter by the job name. Supports the <c>EQUAL</c> operator for exact
        /// match, or the <c>CONTAINS</c> operator for substring match. For example, use <c>CONTAINS</c>
        /// with a value of <c>my-experiment</c> to find all jobs whose name includes "my-experiment".
        /// </para>
        ///  
        /// <para>
        ///  <c>deviceArn</c> — Filter by the target device. Supports the <c>EQUAL</c> operator
        /// only. The value can be a device ARN (for example, <c>arn:aws:braket:us-east-1::device/qpu/ionq/Aria-1</c>)
        /// or a local simulator identifier (for example, <c>local:braket/default</c>).
        /// </para>
        ///  
        /// <para>
        ///  <c>createdAt</c> — Filter by the job creation time. Supports the <c>EQUAL</c>, <c>GT</c>,
        /// <c>GTE</c>, <c>LT</c>, <c>LTE</c>, and <c>BETWEEN</c> operators. Values must be in
        /// RFC 3339 date-time format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// An operator to use for the filter. The supported operators depend on the filter name.
        /// See the <c>name</c> parameter for details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchJobsFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values used to filter hybrid jobs based on the filter name and operator. Each
        /// filter accepts an array of values. Most filters accept a single value, except <c>createdAt</c>
        /// with the <c>BETWEEN</c> operator, which requires exactly two values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
