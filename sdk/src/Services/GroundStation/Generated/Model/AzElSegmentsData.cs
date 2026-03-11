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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for azimuth elevation segment data.
    /// 
    ///  
    /// <para>
    /// Specify either <a>AzElSegmentsData$s3Object</a> to reference data in Amazon S3, or
    /// <a>AzElSegmentsData$azElData</a> to provide data inline.
    /// </para>
    /// </summary>
    public partial class AzElSegmentsData
    {
        private AzElSegments _azElData;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property AzElData. 
        /// <para>
        /// Azimuth elevation segment data provided directly in the request.
        /// </para>
        ///  
        /// <para>
        /// Use this option for smaller datasets or when Amazon S3 access is not available.
        /// </para>
        /// </summary>
        public AzElSegments AzElData
        {
            get { return this._azElData; }
            set { this._azElData = value; }
        }

        // Check to see if AzElData property is set
        internal bool IsSetAzElData()
        {
            return this._azElData != null;
        }

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// The Amazon S3 object containing azimuth elevation segment data.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 object must contain JSON-formatted azimuth elevation data matching the
        /// <a>AzElSegments</a> structure.
        /// </para>
        /// </summary>
        public S3Object S3Object
        {
            get { return this._s3Object; }
            set { this._s3Object = value; }
        }

        // Check to see if S3Object property is set
        internal bool IsSetS3Object()
        {
            return this._s3Object != null;
        }

    }
}