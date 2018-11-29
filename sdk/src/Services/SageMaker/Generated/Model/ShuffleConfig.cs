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
    /// A configuration for a shuffle option for input data in a channel. If you use <code>S3Prefix</code>
    /// for <code>S3DataType</code>, the results of the S3 key prefix matches are shuffled.
    /// If you use <code>ManifestFile</code>, the order of the S3 object references in the
    /// <code>ManifestFile</code> is shuffled. If you use <code>AugmentedManifestFile</code>,
    /// the order of the JSON lines in the <code>AugmentedManifestFile</code> is shuffled.
    /// The shuffling order is determined using the <code>Seed</code> value.
    /// 
    ///  
    /// <para>
    /// For Pipe input mode, shuffling is done at the start of every epoch. With large datasets,
    /// this ensures that the order of the training data is different for each epoch, and
    /// it helps reduce bias and possible overfitting. In a multi-node training job when <code>ShuffleConfig</code>
    /// is combined with <code>S3DataDistributionType</code> of <code>ShardedByS3Key</code>,
    /// the data is shuffled across nodes so that the content sent to a particular node on
    /// the first epoch might be sent to a different node on the second epoch.
    /// </para>
    /// </summary>
    public partial class ShuffleConfig
    {
        private long? _seed;

        /// <summary>
        /// Gets and sets the property Seed. 
        /// <para>
        /// Determines the shuffling order in <code>ShuffleConfig</code>. value.
        /// </para>
        /// </summary>
        public long Seed
        {
            get { return this._seed.GetValueOrDefault(); }
            set { this._seed = value; }
        }

        // Check to see if Seed property is set
        internal bool IsSetSeed()
        {
            return this._seed.HasValue; 
        }

    }
}