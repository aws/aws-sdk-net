/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketMetricsConfigurationRequest operation.
    /// <para>Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.</para>
    /// </summary>
    public partial class PutBucketMetricsConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string metricsId;
        private MetricsConfiguration metricsConfiguration;

        /// <summary>
        /// The name of the bucket for which the metrics configuration is set.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The ID used to identify the metrics configuration.
        /// </summary>
        public string MetricsId
        {
            get { return this.metricsId; }
            set { this.metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return this.metricsId != null;
        }

        /// <summary>
        /// Specifies the metrics configuration.
        /// </summary>
        public MetricsConfiguration MetricsConfiguration
        {
            get { return this.metricsConfiguration; }
            set { this.metricsConfiguration = value; }
        }

        // Check to see if MetricsConfiguration property is set
        internal bool IsSetMetricsConfiguration()
        {
            return this.metricsConfiguration != null;
        }

    }
}
