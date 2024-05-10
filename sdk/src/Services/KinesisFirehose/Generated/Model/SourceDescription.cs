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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Details about a Kinesis data stream used as the source for a Firehose delivery stream.
    /// </summary>
    public partial class SourceDescription
    {
        private KinesisStreamSourceDescription _kinesisStreamSourceDescription;
        private MSKSourceDescription _mskSourceDescription;

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

        /// <summary>
        /// Gets and sets the property MSKSourceDescription. 
        /// <para>
        /// The configuration description for the Amazon MSK cluster to be used as the source
        /// for a delivery stream.
        /// </para>
        /// </summary>
        public MSKSourceDescription MSKSourceDescription
        {
            get { return this._mskSourceDescription; }
            set { this._mskSourceDescription = value; }
        }

        // Check to see if MSKSourceDescription property is set
        internal bool IsSetMSKSourceDescription()
        {
            return this._mskSourceDescription != null;
        }

    }
}