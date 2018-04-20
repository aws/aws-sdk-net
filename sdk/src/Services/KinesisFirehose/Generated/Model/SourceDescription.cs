/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Details about a Kinesis data stream used as the source for a Kinesis Data Firehose
    /// delivery stream.
    /// </summary>
    public partial class SourceDescription
    {
        private KinesisStreamSourceDescription _kinesisStreamSourceDescription;

        /// <summary>
        /// Gets and sets the property KinesisStreamSourceDescription. 
        /// <para>
        /// The <a>KinesisStreamSourceDescription</a> value for the source Kinesis data stream.
        /// </para>
        /// </summary>
        public KinesisStreamSourceDescription KinesisStreamSourceDescription
        {
            get { return this._kinesisStreamSourceDescription; }
            set { this._kinesisStreamSourceDescription = value; }
        }

        // Check to see if KinesisStreamSourceDescription property is set
        internal bool IsSetKinesisStreamSourceDescription()
        {
            return this._kinesisStreamSourceDescription != null;
        }

    }
}