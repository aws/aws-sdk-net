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
    /// The inputs for a processing job. The processing input must specify exactly one of
    /// either <c>S3Input</c> or <c>DatasetDefinition</c> types.
    /// </summary>
    public partial class ProcessingInput
    {
        private bool? _appManaged;
        private DatasetDefinition _datasetDefinition;
        private string _inputName;
        private ProcessingS3Input _s3Input;

        /// <summary>
        /// Gets and sets the property AppManaged. 
        /// <para>
        /// When <c>True</c>, input operations such as data download are managed natively by the
        /// processing job application. When <c>False</c> (default), input operations are managed
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
        /// Gets and sets the property DatasetDefinition. 
        /// <para>
        /// Configuration for a Dataset Definition input. 
        /// </para>
        /// </summary>
        public DatasetDefinition DatasetDefinition
        {
            get { return this._datasetDefinition; }
            set { this._datasetDefinition = value; }
        }

        // Check to see if DatasetDefinition property is set
        internal bool IsSetDatasetDefinition()
        {
            return this._datasetDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name for the processing job input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputName
        {
            get { return this._inputName; }
            set { this._inputName = value; }
        }

        // Check to see if InputName property is set
        internal bool IsSetInputName()
        {
            return this._inputName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Input. 
        /// <para>
        /// Configuration for downloading input data from Amazon S3 into the processing container.
        /// </para>
        /// </summary>
        public ProcessingS3Input S3Input
        {
            get { return this._s3Input; }
            set { this._s3Input = value; }
        }

        // Check to see if S3Input property is set
        internal bool IsSetS3Input()
        {
            return this._s3Input != null;
        }

    }
}