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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the GetSampleData operation.
    /// Returns a selection of sample records from an Amazon S3 datasource.
    /// </summary>
    public partial class GetSampleDataRequest : AmazonLookoutMetricsRequest
    {
        private SampleDataS3SourceConfig _s3SourceConfig;

        /// <summary>
        /// Gets and sets the property S3SourceConfig. 
        /// <para>
        /// A datasource bucket in Amazon S3.
        /// </para>
        /// </summary>
        public SampleDataS3SourceConfig S3SourceConfig
        {
            get { return this._s3SourceConfig; }
            set { this._s3SourceConfig = value; }
        }

        // Check to see if S3SourceConfig property is set
        internal bool IsSetS3SourceConfig()
        {
            return this._s3SourceConfig != null;
        }

    }
}