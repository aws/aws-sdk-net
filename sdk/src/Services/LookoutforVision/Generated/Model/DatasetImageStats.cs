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
    /// Statistics about the images in a dataset.
    /// </summary>
    public partial class DatasetImageStats
    {
        private int? _anomaly;
        private int? _labeled;
        private int? _normal;
        private int? _total;

        /// <summary>
        /// Gets and sets the property Anomaly. 
        /// <para>
        /// the total number of images labeled as an anomaly.
        /// </para>
        /// </summary>
        public int? Anomaly
        {
            get { return this._anomaly; }
            set { this._anomaly = value; }
        }

        // Check to see if Anomaly property is set
        internal bool IsSetAnomaly()
        {
            return this._anomaly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Labeled. 
        /// <para>
        /// The total number of labeled images.
        /// </para>
        /// </summary>
        public int? Labeled
        {
            get { return this._labeled; }
            set { this._labeled = value; }
        }

        // Check to see if Labeled property is set
        internal bool IsSetLabeled()
        {
            return this._labeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Normal. 
        /// <para>
        /// The total number of images labeled as normal.
        /// </para>
        /// </summary>
        public int? Normal
        {
            get { return this._normal; }
            set { this._normal = value; }
        }

        // Check to see if Normal property is set
        internal bool IsSetNormal()
        {
            return this._normal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of images in the dataset.
        /// </para>
        /// </summary>
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}