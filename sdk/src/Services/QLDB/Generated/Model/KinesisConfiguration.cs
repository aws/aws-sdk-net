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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// The configuration settings of the Amazon Kinesis Data Streams destination for your
    /// Amazon QLDB journal stream.
    /// </summary>
    public partial class KinesisConfiguration
    {
        private bool? _aggregationEnabled;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property AggregationEnabled. 
        /// <para>
        /// Enables QLDB to publish multiple data records in a single Kinesis Data Streams record.
        /// To learn more, see <a href="https://docs.aws.amazon.com/streams/latest/dev/kinesis-kpl-concepts.html">KPL
        /// Key Concepts</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool AggregationEnabled
        {
            get { return this._aggregationEnabled.GetValueOrDefault(); }
            set { this._aggregationEnabled = value; }
        }

        // Check to see if AggregationEnabled property is set
        internal bool IsSetAggregationEnabled()
        {
            return this._aggregationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis data stream resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

    }
}