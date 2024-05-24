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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Information about an anomaly type found on an image by an image segmentation model.
    /// For more information, see <a>DetectAnomalies</a>.
    /// </summary>
    public partial class Anomaly
    {
        private string _name;
        private PixelAnomaly _pixelAnomaly;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an anomaly type found in an image. <c>Name</c> maps to an anomaly type
        /// in the training dataset, apart from the anomaly type <c>background</c>. The service
        /// automatically inserts the <c>background</c> anomaly type into the response from <c>DetectAnomalies</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PixelAnomaly. 
        /// <para>
        /// Information about the pixel mask that covers an anomaly type.
        /// </para>
        /// </summary>
        public PixelAnomaly PixelAnomaly
        {
            get { return this._pixelAnomaly; }
            set { this._pixelAnomaly = value; }
        }

        // Check to see if PixelAnomaly property is set
        internal bool IsSetPixelAnomaly()
        {
            return this._pixelAnomaly != null;
        }

    }
}