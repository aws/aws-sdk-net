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
    /// Input structure for the BandMath operation type. Defines Predefined and CustomIndices
    /// to be computed using BandMath.
    /// </summary>
    public partial class BandMathConfigInput
    {
        private CustomIndicesInput _customIndices;
        private List<string> _predefinedIndices = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomIndices. 
        /// <para>
        /// CustomIndices that are computed.
        /// </para>
        /// </summary>
        public CustomIndicesInput CustomIndices
        {
            get { return this._customIndices; }
            set { this._customIndices = value; }
        }

        // Check to see if CustomIndices property is set
        internal bool IsSetCustomIndices()
        {
            return this._customIndices != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedIndices. 
        /// <para>
        /// One or many of the supported predefined indices to compute. Allowed values: <c>NDVI</c>,
        /// <c>EVI2</c>, <c>MSAVI</c>, <c>NDWI</c>, <c>NDMI</c>, <c>NDSI</c>, and <c>WDRVI</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> PredefinedIndices
        {
            get { return this._predefinedIndices; }
            set { this._predefinedIndices = value; }
        }

        // Check to see if PredefinedIndices property is set
        internal bool IsSetPredefinedIndices()
        {
            return this._predefinedIndices != null && (this._predefinedIndices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}