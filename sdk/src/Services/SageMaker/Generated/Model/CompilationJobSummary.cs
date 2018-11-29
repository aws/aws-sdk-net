/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of a model compilation job.
    /// </summary>
    public partial class CompilationJobSummary
    {
        private DateTime? _compilationEndTime;
        private string _compilationJobArn;
        private string _compilationJobName;
        private CompilationJobStatus _compilationJobStatus;
        private TargetDevice _compilationTargetDevice;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CompilationEndTime. 
        /// <para>
        /// The time when the model compilation job completed.
        /// </para>
        /// </summary>
        public DateTime CompilationEndTime
        {
            get { return this._compilationEndTime.GetValueOrDefault(); }
            set { this._compilationEndTime = value; }
        }

        // Check to see if CompilationEndTime property is set
        internal bool IsSetCompilationEndTime()
        {
            return this._compilationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompilationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model compilation job.
        /// </para>
        /// </summary>
        public string CompilationJobArn
        {
            get { return this._compilationJobArn; }
            set { this._compilationJobArn = value; }
        }

        // Check to see if CompilationJobArn property is set
        internal bool IsSetCompilationJobArn()
        {
            return this._compilationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the model compilation job that you want a summary for.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CompilationJobStatus. 
        /// <para>
        /// The status of the model compilation job.
        /// </para>
        /// </summary>
        public CompilationJobStatus CompilationJobStatus
        {
            get { return this._compilationJobStatus; }
            set { this._compilationJobStatus = value; }
        }

        // Check to see if CompilationJobStatus property is set
        internal bool IsSetCompilationJobStatus()
        {
            return this._compilationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CompilationTargetDevice. 
        /// <para>
        /// The type of device that the model will run on after compilation has completed.
        /// </para>
        /// </summary>
        public TargetDevice CompilationTargetDevice
        {
            get { return this._compilationTargetDevice; }
            set { this._compilationTargetDevice = value; }
        }

        // Check to see if CompilationTargetDevice property is set
        internal bool IsSetCompilationTargetDevice()
        {
            return this._compilationTargetDevice != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the model compilation job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the model compilation job was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}