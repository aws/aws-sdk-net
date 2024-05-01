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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The source that Amazon Rekognition Custom Labels uses to create a dataset. To use
    /// an Amazon Sagemaker format manifest file, specify the S3 bucket location in the <c>GroundTruthManifest</c>
    /// field. The S3 bucket must be in your AWS account. To create a copy of an existing
    /// dataset, specify the Amazon Resource Name (ARN) of an existing dataset in <c>DatasetArn</c>.
    /// 
    ///  
    /// <para>
    /// You need to specify a value for <c>DatasetArn</c> or <c>GroundTruthManifest</c>, but
    /// not both. if you supply both values, or if you don't specify any values, an InvalidParameterException
    /// exception occurs. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a>CreateDataset</a>.
    /// </para>
    /// </summary>
    public partial class DatasetSource
    {
        private string _datasetArn;
        private GroundTruthManifest _groundTruthManifest;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The ARN of an Amazon Rekognition Custom Labels dataset that you want to copy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property GroundTruthManifest.
        /// </summary>
        public GroundTruthManifest GroundTruthManifest
        {
            get { return this._groundTruthManifest; }
            set { this._groundTruthManifest = value; }
        }

        // Check to see if GroundTruthManifest property is set
        internal bool IsSetGroundTruthManifest()
        {
            return this._groundTruthManifest != null;
        }

    }
}