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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProjectVersion operation.
    /// Creates a new version of a model and begins training. Models are managed as part of
    /// an Amazon Rekognition Custom Labels project. You can specify one training dataset
    /// and one testing dataset. The response from <code>CreateProjectVersion</code> is an
    /// Amazon Resource Name (ARN) for the version of the model. 
    /// 
    ///  
    /// <para>
    /// Training takes a while to complete. You can get the current status by calling <a>DescribeProjectVersions</a>.
    /// </para>
    ///  
    /// <para>
    /// Once training has successfully completed, call <a>DescribeProjectVersions</a> to get
    /// the training results and evaluate the model. 
    /// </para>
    ///  
    /// <para>
    /// After evaluating the model, you start the model by calling <a>StartProjectVersion</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:CreateProjectVersion</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateProjectVersionRequest : AmazonRekognitionRequest
    {
        private OutputConfig _outputConfig;
        private string _projectArn;
        private TestingData _testingData;
        private TrainingData _trainingData;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The Amazon S3 location to store the results of training.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the Amazon Rekognition Custom Labels project that manages the model that
        /// you want to train.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestingData. 
        /// <para>
        /// The dataset to use for testing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestingData TestingData
        {
            get { return this._testingData; }
            set { this._testingData = value; }
        }

        // Check to see if TestingData property is set
        internal bool IsSetTestingData()
        {
            return this._testingData != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingData. 
        /// <para>
        /// The dataset to use for training. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingData TrainingData
        {
            get { return this._trainingData; }
            set { this._trainingData = value; }
        }

        // Check to see if TrainingData property is set
        internal bool IsSetTrainingData()
        {
            return this._trainingData != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// A name for the version of the model. This value must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}