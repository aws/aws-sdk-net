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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeModelCardExportJob operation.
    /// </summary>
    public partial class DescribeModelCardExportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private ModelCardExportArtifacts _exportArtifacts;
        private string _failureReason;
        private DateTime? _lastModifiedAt;
        private string _modelCardExportJobArn;
        private string _modelCardExportJobName;
        private string _modelCardName;
        private int? _modelCardVersion;
        private ModelCardExportOutputConfig _outputConfig;
        private ModelCardExportJobStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the model export job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportArtifacts. 
        /// <para>
        /// The exported model card artifacts.
        /// </para>
        /// </summary>
        public ModelCardExportArtifacts ExportArtifacts
        {
            get { return this._exportArtifacts; }
            set { this._exportArtifacts = value; }
        }

        // Check to see if ExportArtifacts property is set
        internal bool IsSetExportArtifacts()
        {
            return this._exportArtifacts != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if the model export job fails.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the model export job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedAt
        {
            get { return this._lastModifiedAt.GetValueOrDefault(); }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelCardExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ModelCardExportJobArn
        {
            get { return this._modelCardExportJobArn; }
            set { this._modelCardExportJobArn = value; }
        }

        // Check to see if ModelCardExportJobArn property is set
        internal bool IsSetModelCardExportJobArn()
        {
            return this._modelCardExportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardExportJobName. 
        /// <para>
        /// The name of the model card export job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelCardExportJobName
        {
            get { return this._modelCardExportJobName; }
            set { this._modelCardExportJobName = value; }
        }

        // Check to see if ModelCardExportJobName property is set
        internal bool IsSetModelCardExportJobName()
        {
            return this._modelCardExportJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name of the model card that the model export job exports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelCardName
        {
            get { return this._modelCardName; }
            set { this._modelCardName = value; }
        }

        // Check to see if ModelCardName property is set
        internal bool IsSetModelCardName()
        {
            return this._modelCardName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card that the model export job exports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ModelCardVersion
        {
            get { return this._modelCardVersion.GetValueOrDefault(); }
            set { this._modelCardVersion = value; }
        }

        // Check to see if ModelCardVersion property is set
        internal bool IsSetModelCardVersion()
        {
            return this._modelCardVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The export output details for the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelCardExportOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The completion status of the model card export job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>InProgress</code>: The model card export job is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Completed</code>: The model card export job is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code>: The model card export job failed. To see the reason for the
        /// failure, see the <code>FailureReason</code> field in the response to a <code>DescribeModelCardExportJob</code>
        /// call.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelCardExportJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}