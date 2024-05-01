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
    /// Summary of edge packaging job.
    /// </summary>
    public partial class EdgePackagingJobSummary
    {
        private string _compilationJobName;
        private DateTime? _creationTime;
        private string _edgePackagingJobArn;
        private string _edgePackagingJobName;
        private EdgePackagingJobStatus _edgePackagingJobStatus;
        private DateTime? _lastModifiedTime;
        private string _modelName;
        private string _modelVersion;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the SageMaker Neo compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CompilationJobName
        {
            get { return this._compilationJobName; }
            set { this._compilationJobName = value; }
        }

        // Check to see if CompilationJobName property is set
        internal bool IsSetCompilationJobName()
        {
            return this._compilationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EdgePackagingJobArn
        {
            get { return this._edgePackagingJobArn; }
            set { this._edgePackagingJobArn = value; }
        }

        // Check to see if EdgePackagingJobArn property is set
        internal bool IsSetEdgePackagingJobArn()
        {
            return this._edgePackagingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobName. 
        /// <para>
        /// The name of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgePackagingJobName
        {
            get { return this._edgePackagingJobName; }
            set { this._edgePackagingJobName = value; }
        }

        // Check to see if EdgePackagingJobName property is set
        internal bool IsSetEdgePackagingJobName()
        {
            return this._edgePackagingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobStatus. 
        /// <para>
        /// The status of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgePackagingJobStatus EdgePackagingJobStatus
        {
            get { return this._edgePackagingJobStatus; }
            set { this._edgePackagingJobStatus = value; }
        }

        // Check to see if EdgePackagingJobStatus property is set
        internal bool IsSetEdgePackagingJobStatus()
        {
            return this._edgePackagingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the edge packaging job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

    }
}