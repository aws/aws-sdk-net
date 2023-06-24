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
    /// The input structure for Stacking Operation.
    /// </summary>
    public partial class StackConfigInput
    {
        private OutputResolutionStackInput _outputResolution;
        private List<string> _targetBands = new List<string>();

        /// <summary>
        /// Gets and sets the property OutputResolution. 
        /// <para>
        /// The structure representing output resolution (in target georeferenced units) of the
        /// result of stacking operation.
        /// </para>
        /// </summary>
        public OutputResolutionStackInput OutputResolution
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
        /// A list of bands to be stacked in the specified order. When the parameter is not provided,
        /// all the available bands in the data collection are stacked in the alphabetical order
        /// of their asset names.
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