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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies a metrics configuration filter. The metrics configuration only includes
    /// objects that meet the filter's criteria. A filter must be a prefix, an object tag,
    /// an access point ARN, or a conjunction (MetricsAndOperator). For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketMetricsConfiguration.html">
    /// PutBucketMetricsConfiguration</a>.
    /// </summary>
    public class MetricsFilter
    {
        private MetricsFilterPredicate metricsFilterPredicate;

        /// <summary>
        /// Filter Predicate setup for specific filter types.
        /// </summary>
        public MetricsFilterPredicate MetricsFilterPredicate
        {
            get { return this.metricsFilterPredicate; }
            set { this.metricsFilterPredicate = value; }
        }
    }
}
