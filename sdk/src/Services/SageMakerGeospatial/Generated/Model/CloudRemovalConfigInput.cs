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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Input structure for Cloud Removal Operation type
    /// </summary>
    public partial class CloudRemovalConfigInput
    {
        private AlgorithmNameCloudRemoval _algorithmName;
        private string _interpolationValue;
        private List<string> _targetBands = new List<string>();

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm used for cloud removal.
        /// </para>
        /// </summary>
        public AlgorithmNameCloudRemoval AlgorithmName
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
        /// Gets and sets the property InterpolationValue. 
        /// <para>
        /// The interpolation value you provide for cloud removal.
        /// </para>
        /// </summary>
        public string InterpolationValue
        {
            get { return this._interpolationValue; }
            set { this._interpolationValue = value; }
        }

        // Check to see if InterpolationValue property is set
        internal bool IsSetInterpolationValue()
        {
            return this._interpolationValue != null;
        }

        /// <summary>
        /// Gets and sets the property TargetBands. 
        /// <para>
        /// TargetBands to be returned in the output of CloudRemoval operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetBands
        {
            get { return this._targetBands; }
            set { this._targetBands = value; }
        }

        // Check to see if TargetBands property is set
        internal bool IsSetTargetBands()
        {
            return this._targetBands != null && this._targetBands.Count > 0; 
        }

    }
}