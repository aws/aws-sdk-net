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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies a metrics configuration for the CloudWatch request metrics (specified by
    /// the metrics configuration ID) from an Amazon S3 bucket. If you're updating an existing
    /// metrics configuration, note that this is a full replacement of the existing metrics
    /// configuration. If you don't include the elements you want to keep, they are erased.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTMetricConfiguration.html">PutBucketMetricsConfiguration</a>.
    /// </summary>
    public partial class MetricsConfiguration
    {
        private MetricsFilter _metricsFilter;
        private string _metricsId;

        /// <summary>
        /// Gets and sets the property MetricsFilter. 
        /// <para>
        /// Specifies a metrics configuration filter. The metrics configuration will only include
        /// objects that meet the filter's criteria. A filter must be a prefix, an object tag,
        /// an access point ARN, or a conjunction (MetricsAndOperator).
        /// </para>
        /// </summary>
        public MetricsFilter MetricsFilter
        {
            get { return this._metricsFilter; }
            set { this._metricsFilter = value; }
        }

        // Check to see if MetricsFilter property is set
        internal bool IsSetMetricsFilter()
        {
            return this._metricsFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsId. 
        /// <para>
        /// The ID used to identify the metrics configuration. The ID has a 64 character limit
        /// and can only contain letters, numbers, periods, dashes, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricsId
        {
            get { return this._metricsId; }
            set { this._metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return this._metricsId != null;
        }

    }
}