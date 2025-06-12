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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The Amazon S3 result from the snapshot job. The result includes the <c>DestinationConfiguration</c>
    /// and the Amazon S3 Uri. If an error occured during the job, the result returns information
    /// on the error.
    /// </summary>
    public partial class SnapshotJobS3Result
    {
        private List<SnapshotJobResultErrorInfo> _errorInfo = AWSConfigs.InitializeCollections ? new List<SnapshotJobResultErrorInfo>() : null;
        private SnapshotS3DestinationConfiguration _s3DestinationConfiguration;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// An array of error records that describe any failures that occur while the dashboard
        /// snapshot job runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SnapshotJobResultErrorInfo> ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null && (this._errorInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// A list of Amazon S3 bucket configurations that are provided when you make a <c>StartDashboardSnapshotJob</c>
        /// API call. 
        /// </para>
        /// </summary>
        public SnapshotS3DestinationConfiguration S3DestinationConfiguration
        {
            get { return this._s3DestinationConfiguration; }
            set { this._s3DestinationConfiguration = value; }
        }

        // Check to see if S3DestinationConfiguration property is set
        internal bool IsSetS3DestinationConfiguration()
        {
            return this._s3DestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 Uri.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}