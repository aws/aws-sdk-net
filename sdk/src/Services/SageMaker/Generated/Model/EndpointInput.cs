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
    /// Input object for the endpoint
    /// </summary>
    public partial class EndpointInput
    {
        private string _endpointName;
        private string _localPath;
        private ProcessingS3DataDistributionType _s3DataDistributionType;
        private ProcessingS3InputMode _s3InputMode;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// An endpoint in customer's account which has enabled <code>DataCaptureConfig</code>
        /// enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to the filesystem where the endpoint data is available to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string LocalPath
        {
            get { return this._localPath; }
            set { this._localPath = value; }
        }

        // Check to see if LocalPath property is set
        internal bool IsSetLocalPath()
        {
            return this._localPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// Whether input data distributed in Amazon S3 is fully replicated or sharded by an S3
        /// key. Defauts to <code>FullyReplicated</code> 
        /// </para>
        /// </summary>
        public ProcessingS3DataDistributionType S3DataDistributionType
        {
            get { return this._s3DataDistributionType; }
            set { this._s3DataDistributionType = value; }
        }

        // Check to see if S3DataDistributionType property is set
        internal bool IsSetS3DataDistributionType()
        {
            return this._s3DataDistributionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputMode. 
        /// <para>
        /// Whether the <code>Pipe</code> or <code>File</code> is used as the input mode for transfering
        /// data for the monitoring job. <code>Pipe</code> mode is recommended for large datasets.
        /// <code>File</code> mode is useful for small files that fit in memory. Defaults to <code>File</code>.
        /// </para>
        /// </summary>
        public ProcessingS3InputMode S3InputMode
        {
            get { return this._s3InputMode; }
            set { this._s3InputMode = value; }
        }

        // Check to see if S3InputMode property is set
        internal bool IsSetS3InputMode()
        {
            return this._s3InputMode != null;
        }

    }
}