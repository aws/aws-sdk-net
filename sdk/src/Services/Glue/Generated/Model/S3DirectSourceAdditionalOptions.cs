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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies additional connection options for the Amazon S3 data store.
    /// </summary>
    public partial class S3DirectSourceAdditionalOptions
    {
        private long? _boundedFiles;
        private long? _boundedSize;
        private bool? _enableSamplePath;
        private string _samplePath;

        /// <summary>
        /// Gets and sets the property BoundedFiles. 
        /// <para>
        /// Sets the upper limit for the target number of files that will be processed.
        /// </para>
        /// </summary>
        public long? BoundedFiles
        {
            get { return this._boundedFiles; }
            set { this._boundedFiles = value; }
        }

        // Check to see if BoundedFiles property is set
        internal bool IsSetBoundedFiles()
        {
            return this._boundedFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BoundedSize. 
        /// <para>
        /// Sets the upper limit for the target size of the dataset in bytes that will be processed.
        /// </para>
        /// </summary>
        public long? BoundedSize
        {
            get { return this._boundedSize; }
            set { this._boundedSize = value; }
        }

        // Check to see if BoundedSize property is set
        internal bool IsSetBoundedSize()
        {
            return this._boundedSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableSamplePath. 
        /// <para>
        /// Sets option to enable a sample path.
        /// </para>
        /// </summary>
        public bool? EnableSamplePath
        {
            get { return this._enableSamplePath; }
            set { this._enableSamplePath = value; }
        }

        // Check to see if EnableSamplePath property is set
        internal bool IsSetEnableSamplePath()
        {
            return this._enableSamplePath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplePath. 
        /// <para>
        /// If enabled, specifies the sample path.
        /// </para>
        /// </summary>
        public string SamplePath
        {
            get { return this._samplePath; }
            set { this._samplePath = value; }
        }

        // Check to see if SamplePath property is set
        internal bool IsSetSamplePath()
        {
            return this._samplePath != null;
        }

    }
}