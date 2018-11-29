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
    /// Specifies an algorithm that was used to create the model package. The algorithm must
    /// be either an algorithm resource in your Amazon SageMaker account or an algorithm in
    /// AWS Marketplace that you are subscribed to.
    /// </summary>
    public partial class SourceAlgorithm
    {
        private string _algorithmName;
        private string _modelDataUrl;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of an algorithm that was used to create the model package. The algorithm
        /// must be either an algorithm resource in your Amazon SageMaker account or an algorithm
        /// in AWS Marketplace that you are subscribed to.
        /// </para>
        /// </summary>
        public string AlgorithmName
        {
            get { return this._algorithmName; }
            set { this._algorithmName = value; }
        }

        // Check to see if AlgorithmName property is set
        internal bool IsSetAlgorithmName()
        {
            return this._algorithmName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts, which result from model training, are
        /// stored. This path must point to a single <code>gzip</code> compressed tar archive
        /// (<code>.tar.gz</code> suffix).
        /// </para>
        /// </summary>
        public string ModelDataUrl
        {
            get { return this._modelDataUrl; }
            set { this._modelDataUrl = value; }
        }

        // Check to see if ModelDataUrl property is set
        internal bool IsSetModelDataUrl()
        {
            return this._modelDataUrl != null;
        }

    }
}