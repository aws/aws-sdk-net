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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure representing input for resampling operation.
    /// </summary>
    public partial class ResamplingConfigInput
    {
        private AlgorithmNameResampling _algorithmName;
        private OutputResolutionResamplingInput _outputResolution;
        private List<string> _targetBands = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm used for resampling.
        /// </para>
        /// </summary>
        public AlgorithmNameResampling AlgorithmName
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
        /// Gets and sets the property OutputResolution. 
        /// <para>
        /// The structure representing output resolution (in target georeferenced units) of the
        /// result of resampling operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputResolutionResamplingInput OutputResolution
        {
            get { return this._outputResolution; }
            set { this._outputResolution = value; }
        }

        // Check to see if OutputResolution property is set
        internal bool IsSetOutputResolution()
        {
            return this._outputResolution != null;
        }

        /// <summary>
        /// Gets and sets the property TargetBands. 
        /// <para>
        /// Bands used in the operation. If no target bands are specified, it uses all bands available
        /// in the input.
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
            return this._targetBands != null && (this._targetBands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}