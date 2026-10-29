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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetCardinality operation. Returns the approximate
    /// count of unique values that match the query. <para> Requires permission to access
    /// the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetCardinality</a>
    /// action. </para>
    /// </summary>
    public partial class GetCardinalityRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AggregationField. 
        /// <para>
        /// The field to aggregate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string AggregationField { get; set; }

        /// <summary>
        /// Checks to see if the AggregationField property is set.
        /// </summary>
        internal bool IsSetAggregationField() => this.AggregationField != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The search query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The query version.
        /// </para>
        /// </summary>
        public string QueryVersion { get; set; }

        /// <summary>
        /// Checks to see if the QueryVersion property is set.
        /// </summary>
        internal bool IsSetQueryVersion() => this.QueryVersion != null;
    }
}
