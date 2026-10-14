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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Specifies an algorithm that was used to create the model package. The algorithm must
    /// be either an algorithm resource in your SageMaker account or an algorithm in Amazon
    /// Web Services Marketplace that you are subscribed to.
    /// </summary>
    public partial class SourceAlgorithm
    {
        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of an algorithm that was used to create the model package. The algorithm
        /// must be either an algorithm resource in your SageMaker account or an algorithm in
        /// Amazon Web Services Marketplace that you are subscribed to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 170)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmName property is set.
        /// </summary>
        internal bool IsSetAlgorithmName() => this.AlgorithmName != null;

        /// <summary>
        /// Gets and sets the property ModelDataETag. 
        /// <para>
        /// The ETag associated with Model Data URL.
        /// </para>
        /// </summary>
        public string ModelDataETag { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataETag property is set.
        /// </summary>
        internal bool IsSetModelDataETag() => this.ModelDataETag != null;

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// Specifies the location of ML model data to deploy during endpoint creation.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataSource property is set.
        /// </summary>
        internal bool IsSetModelDataSource() => this.ModelDataSource != null;

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts, which result from model training, are
        /// stored. This path must point to a single <c>gzip</c> compressed tar archive (<c>.tar.gz</c>
        /// suffix).
        /// </para>
        ///  <note> 
        /// <para>
        /// The model artifacts must be in an S3 bucket that is in the same Amazon Web Services
        /// region as the algorithm.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ModelDataUrl { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataUrl property is set.
        /// </summary>
        internal bool IsSetModelDataUrl() => this.ModelDataUrl != null;
    }
}
