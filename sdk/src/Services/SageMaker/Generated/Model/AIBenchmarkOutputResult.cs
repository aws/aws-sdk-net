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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The output result of an AI benchmark job, including the Amazon S3 location and CloudWatch
    /// log information.
    /// </summary>
    public partial class AIBenchmarkOutputResult
    {
        private List<AICloudWatchLogs> _cloudWatchLogs = AWSConfigs.InitializeCollections ? new List<AICloudWatchLogs>() : null;
        private string _s3OutputLocation;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// The CloudWatch log information for the benchmark job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AICloudWatchLogs> CloudWatchLogs
        {
            get { return this._cloudWatchLogs; }
            set { this._cloudWatchLogs = value; }
        }

        // Check to see if CloudWatchLogs property is set
        internal bool IsSetCloudWatchLogs()
        {
            return this._cloudWatchLogs != null && (this._cloudWatchLogs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon S3 URI where benchmark results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3OutputLocation
        {
            get { return this._s3OutputLocation; }
            set { this._s3OutputLocation = value; }
        }

        // Check to see if S3OutputLocation property is set
        internal bool IsSetS3OutputLocation()
        {
            return this._s3OutputLocation != null;
        }

    }
}