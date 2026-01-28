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
    /// Information about a telemetry sink.
    /// </summary>
    public partial class TelemetrySinkData
    {
        private KinesisDataStreamData _kinesisDataStreamData;

        /// <summary>
        /// Gets and sets the property KinesisDataStreamData. 
        /// <para>
        /// Information about a telemetry sink of type <c>KINESIS_DATA_STREAM</c>.
        /// </para>
        /// </summary>
        public KinesisDataStreamData KinesisDataStreamData
        {
            get { return this._kinesisDataStreamData; }
            set { this._kinesisDataStreamData = value; }
        }

        // Check to see if KinesisDataStreamData property is set
        internal bool IsSetKinesisDataStreamData()
        {
            return this._kinesisDataStreamData != null;
        }

    }
}