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
    /// Input configuration information.
    /// </summary>
    public partial class InputConfigInput
    {
        /// <summary>
        /// Gets and sets the property PreviousEarthObservationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the previous Earth Observation job.
        /// </para>
        /// </summary>
        public string PreviousEarthObservationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the PreviousEarthObservationJobArn property is set.
        /// </summary>
        internal bool IsSetPreviousEarthObservationJobArn() => this.PreviousEarthObservationJobArn != null;

        /// <summary>
        /// Gets and sets the property RasterDataCollectionQuery. 
        /// <para>
        /// The structure representing the RasterDataCollection Query consisting of the Area of
        /// Interest, RasterDataCollectionArn,TimeRange and Property Filters.
        /// </para>
        /// </summary>
        public RasterDataCollectionQueryInput RasterDataCollectionQuery { get; set; }

        /// <summary>
        /// Checks to see if the RasterDataCollectionQuery property is set.
        /// </summary>
        internal bool IsSetRasterDataCollectionQuery() => this.RasterDataCollectionQuery != null;
    }
}
