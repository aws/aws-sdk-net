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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for a SCTE-35 return_to_network message.
    /// </summary>
    public partial class Scte35ReturnToNetworkScheduleActionSettings
    {
        private long? _spliceEventId;

        /// <summary>
        /// Gets and sets the property SpliceEventId. The splice_event_id for the SCTE-35 splice_insert,
        /// as defined in SCTE-35.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long? SpliceEventId
        {
            get { return this._spliceEventId; }
            set { this._spliceEventId = value; }
        }

        // Check to see if SpliceEventId property is set
        internal bool IsSetSpliceEventId()
        {
            return this._spliceEventId.HasValue; 
        }

    }
}