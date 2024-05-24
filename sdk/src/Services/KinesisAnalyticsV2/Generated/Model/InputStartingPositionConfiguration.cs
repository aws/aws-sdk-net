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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the point at which the application reads from the streaming source.
    /// </summary>
    public partial class InputStartingPositionConfiguration
    {
        private InputStartingPosition _inputStartingPosition;

        /// <summary>
        /// Gets and sets the property InputStartingPosition. 
        /// <para>
        /// The starting position on the stream.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOW</c> - Start reading just after the most recent record in the stream, and start
        /// at the request timestamp that the customer issued.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIM_HORIZON</c> - Start reading at the last untrimmed record in the stream, which
        /// is the oldest record available in the stream. This option is not available for an
        /// Amazon Kinesis Data Firehose delivery stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAST_STOPPED_POINT</c> - Resume reading from where the application last stopped
        /// reading.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InputStartingPosition InputStartingPosition
        {
            get { return this._inputStartingPosition; }
            set { this._inputStartingPosition = value; }
        }

        // Check to see if InputStartingPosition property is set
        internal bool IsSetInputStartingPosition()
        {
            return this._inputStartingPosition != null;
        }

    }
}