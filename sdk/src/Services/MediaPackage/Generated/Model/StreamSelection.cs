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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
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
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A StreamSelection configuration.
    /// </summary>
    public partial class StreamSelection
    {
        private int? _maxVideoBitsPerSecond;
        private int? _minVideoBitsPerSecond;
        private StreamOrder _streamOrder;

        /// <summary>
        /// Gets and sets the property MaxVideoBitsPerSecond. The maximum video bitrate (bps)
        /// to include in output.
        /// </summary>
        public int? MaxVideoBitsPerSecond
        {
            get { return this._maxVideoBitsPerSecond; }
            set { this._maxVideoBitsPerSecond = value; }
        }

        // Check to see if MaxVideoBitsPerSecond property is set
        internal bool IsSetMaxVideoBitsPerSecond()
        {
            return this._maxVideoBitsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinVideoBitsPerSecond. The minimum video bitrate (bps)
        /// to include in output.
        /// </summary>
        public int? MinVideoBitsPerSecond
        {
            get { return this._minVideoBitsPerSecond; }
            set { this._minVideoBitsPerSecond = value; }
        }

        // Check to see if MinVideoBitsPerSecond property is set
        internal bool IsSetMinVideoBitsPerSecond()
        {
            return this._minVideoBitsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamOrder. A directive that determines the order of streams
        /// in the output.
        /// </summary>
        public StreamOrder StreamOrder
        {
            get { return this._streamOrder; }
            set { this._streamOrder = value; }
        }

        // Check to see if StreamOrder property is set
        internal bool IsSetStreamOrder()
        {
            return this._streamOrder != null;
        }

    }
}