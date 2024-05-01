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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProjectDataDelivery operation.
    /// Updates the data storage options for this project. If you store evaluation events,
    /// you an keep them and analyze them on your own. If you choose not to store evaluation
    /// events, Evidently deletes them after using them to produce metrics and other experiment
    /// results that you can view.
    /// 
    ///  
    /// <para>
    /// You can't specify both <c>cloudWatchLogs</c> and <c>s3Destination</c> in the same
    /// operation.
    /// </para>
    /// </summary>
    public partial class UpdateProjectDataDeliveryRequest : AmazonCloudWatchEvidentlyRequest
    {
        private CloudWatchLogsDestinationConfig _cloudWatchLogs;
        private string _project;
        private S3DestinationConfig _s3Destination;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// A structure containing the CloudWatch Logs log group where you want to store evaluation
        /// events.
        /// </para>
        /// </summary>
        public CloudWatchLogsDestinationConfig CloudWatchLogs
        {
            get { return this._cloudWatchLogs; }
            set { this._cloudWatchLogs = value; }
        }

        // Check to see if CloudWatchLogs property is set
        internal bool IsSetCloudWatchLogs()
        {
            return this._cloudWatchLogs != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that you want to modify the data storage options for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// A structure containing the S3 bucket name and bucket prefix where you want to store
        /// evaluation events.
        /// </para>
        /// </summary>
        public S3DestinationConfig S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

    }
}