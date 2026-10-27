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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// A single EarthObservationJob output band.
    /// </summary>
    public partial class OutputBand
    {
        /// <summary>
        /// Gets and sets the property BandName. 
        /// <para>
        /// The name of the band.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BandName { get; set; }

        /// <summary>
        /// Checks to see if the BandName property is set.
        /// </summary>
        internal bool IsSetBandName() => this.BandName != null;

        /// <summary>
        /// Gets and sets the property OutputDataType. 
        /// <para>
        /// The datatype of the output band.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputType OutputDataType { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataType property is set.
        /// </summary>
        internal bool IsSetOutputDataType() => this.OutputDataType != null;
    }
}
