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
    /// Describes the results of a processing job.
    /// </summary>
    public partial class ProcessingOutput
    {
        private string _outputName;
        private ProcessingS3Output _s3Output;

        /// <summary>
        /// Gets and sets the property OutputName. 
        /// <para>
        /// The name for the processing job output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputName
        {
            get { return this._outputName; }
            set { this._outputName = value; }
        }

        // Check to see if OutputName property is set
        internal bool IsSetOutputName()
        {
            return this._outputName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Output. 
        /// <para>
        /// Configuration for processing job outputs in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingS3Output S3Output
        {
            get { return this._s3Output; }
            set { this._s3Output = value; }
        }

        // Check to see if S3Output property is set
        internal bool IsSetS3Output()
        {
            return this._s3Output != null;
        }

    }
}