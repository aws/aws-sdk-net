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
    /// The summary of the Amazon SageMaker Model Card export job.
    /// </summary>
    public partial class ModelCardExportJobSummary
    {
        private DateTime? _createdAt;
        private DateTime? _lastModifiedAt;
        private string _modelCardExportJobArn;
        private string _modelCardExportJobName;
        private string _modelCardName;
        private int? _modelCardVersion;
        private ModelCardExportJobStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the model card export job was created.
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
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the model card export job was last modified..
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
        /// The name of the model card export job.
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
        /// The name of the model card that the export job exports.
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
        /// The version of the model card that the export job exports.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The completion status of the model card export job.
        /// </para>
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