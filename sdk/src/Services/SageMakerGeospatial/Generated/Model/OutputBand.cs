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
    /// A single EarthObservationJob output band.
    /// </summary>
    public partial class OutputBand
    {
        private string _bandName;
        private OutputType _outputDataType;

        /// <summary>
        /// Gets and sets the property BandName. 
        /// <para>
        /// The name of the band.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BandName
        {
            get { return this._bandName; }
            set { this._bandName = value; }
        }

        // Check to see if BandName property is set
        internal bool IsSetBandName()
        {
            return this._bandName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataType. 
        /// <para>
        /// The datatype of the output band.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputType OutputDataType
        {
            get { return this._outputDataType; }
            set { this._outputDataType = value; }
        }

        // Check to see if OutputDataType property is set
        internal bool IsSetOutputDataType()
        {
            return this._outputDataType != null;
        }

    }
}