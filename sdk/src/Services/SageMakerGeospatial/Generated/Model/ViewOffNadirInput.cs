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
    /// The input structure for specifying ViewOffNadir property filter. ViewOffNadir refers
    /// to the angle from the sensor between nadir (straight down) and the scene center. Measured
    /// in degrees (0-90).
    /// </summary>
    public partial class ViewOffNadirInput
    {
        private float? _lowerBound;
        private float? _upperBound;

        /// <summary>
        /// Gets and sets the property LowerBound. 
        /// <para>
        /// The minimum value for ViewOffNadir property filter. This filters items having ViewOffNadir
        /// greater than or equal to this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float LowerBound
        {
            get { return this._lowerBound.GetValueOrDefault(); }
            set { this._lowerBound = value; }
        }

        // Check to see if LowerBound property is set
        internal bool IsSetLowerBound()
        {
            return this._lowerBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// The maximum value for ViewOffNadir property filter. This filters items having ViewOffNadir
        /// lesser than or equal to this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float UpperBound
        {
            get { return this._upperBound.GetValueOrDefault(); }
            set { this._upperBound = value; }
        }

        // Check to see if UpperBound property is set
        internal bool IsSetUpperBound()
        {
            return this._upperBound.HasValue; 
        }

    }
}