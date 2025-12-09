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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Export task.
    /// </summary>
    public partial class ExportTask
    {
        private string _arn;
        private string _creationDateTime;
        private string _endDateTime;
        private string _exportid;
        private float? _progressPercentage;
        private string _s3Bucket;
        private string _s3BucketOwner;
        private string _s3Key;
        private ExportStatus _status;
        private ExportTaskSummary _summary;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ExportTask arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Export task creation datetime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// Export task end datetime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExportID. 
        /// <para>
        /// Export task id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string ExportID
        {
            get { return this._exportid; }
            set { this._exportid = value; }
        }

        // Check to see if ExportID property is set
        internal bool IsSetExportID()
        {
            return this._exportid != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// Export task progress percentage.
        /// </para>
        /// </summary>
        public float? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Export task s3 bucket.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// Export task s3 bucket owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string S3BucketOwner
        {
            get { return this._s3BucketOwner; }
            set { this._s3BucketOwner = value; }
        }

        // Check to see if S3BucketOwner property is set
        internal bool IsSetS3BucketOwner()
        {
            return this._s3BucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// Export task s3 key.
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Export task status.
        /// </para>
        /// </summary>
        public ExportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Export task summary.
        /// </para>
        /// </summary>
        public ExportTaskSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Export task tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}