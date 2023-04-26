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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import task.
    /// </summary>
    public partial class ImportTask
    {
        private string _creationDateTime;
        private string _endDateTime;
        private string _importid;
        private float? _progressPercentage;
        private S3BucketSource _s3BucketSource;
        private ImportStatus _status;
        private ImportTaskSummary _summary;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Import task creation datetime.
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
        /// Import task end datetime.
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
        /// Gets and sets the property ImportID. 
        /// <para>
        /// Import task id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string ImportID
        {
            get { return this._importid; }
            set { this._importid = value; }
        }

        // Check to see if ImportID property is set
        internal bool IsSetImportID()
        {
            return this._importid != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// Import task progress percentage.
        /// </para>
        /// </summary>
        public float ProgressPercentage
        {
            get { return this._progressPercentage.GetValueOrDefault(); }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        /// Import task s3 bucket source.
        /// </para>
        /// </summary>
        public S3BucketSource S3BucketSource
        {
            get { return this._s3BucketSource; }
            set { this._s3BucketSource = value; }
        }

        // Check to see if S3BucketSource property is set
        internal bool IsSetS3BucketSource()
        {
            return this._s3BucketSource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Import task status.
        /// </para>
        /// </summary>
        public ImportStatus Status
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
        /// Import task summary.
        /// </para>
        /// </summary>
        public ImportTaskSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}