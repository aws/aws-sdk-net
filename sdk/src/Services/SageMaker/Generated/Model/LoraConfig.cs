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
    /// The Low-Rank Adaptation (LoRA) configuration for a training session, including the
    /// rank and alpha parameters.
    /// </summary>
    public partial class LoraConfig
    {
        private int? _alpha;
        private int? _rank;

        /// <summary>
        /// Gets and sets the property Alpha. 
        /// <para>
        /// The Low-Rank Adaptation (LoRA) scaling factor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Alpha
        {
            get { return this._alpha; }
            set { this._alpha = value; }
        }

        // Check to see if Alpha property is set
        internal bool IsSetAlpha()
        {
            return this._alpha.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the Low-Rank Adaptation (LoRA) adapter matrices.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public int? Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

    }
}