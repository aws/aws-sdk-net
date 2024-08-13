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
    /// Describes the results of a processing job. The processing output must specify exactly
    /// one of either <c>S3Output</c> or <c>FeatureStoreOutput</c> types.
    /// </summary>
    public partial class ProcessingOutput
    {
        private bool? _appManaged;
        private ProcessingFeatureStoreOutput _featureStoreOutput;
        private string _outputName;
        private ProcessingS3Output _s3Output;

        /// <summary>
        /// Gets and sets the property AppManaged. 
        /// <para>
        /// When <c>True</c>, output operations such as data upload are managed natively by the
        /// processing job application. When <c>False</c> (default), output operations are managed
        /// by Amazon SageMaker.
        /// </para>
        /// </summary>
        public bool? AppManaged
        {
            get { return this._appManaged; }
            set { this._appManaged = value; }
        }

        // Check to see if AppManaged property is set
        internal bool IsSetAppManaged()
        {
            return this._appManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureStoreOutput. 
        /// <para>
        /// Configuration for processing job outputs in Amazon SageMaker Feature Store. This processing
        /// output type is only supported when <c>AppManaged</c> is specified. 
        /// </para>
        /// </summary>
        public ProcessingFeatureStoreOutput FeatureStoreOutput
        {
            get { return this._featureStoreOutput; }
            set { this._featureStoreOutput = value; }
        }

        // Check to see if FeatureStoreOutput property is set
        internal bool IsSetFeatureStoreOutput()
        {
            return this._featureStoreOutput != null;
        }

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