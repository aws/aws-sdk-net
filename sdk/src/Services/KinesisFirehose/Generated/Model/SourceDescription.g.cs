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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Details about a Kinesis data stream used as the source for a Firehose stream.
    /// </summary>
    public partial class SourceDescription
    {
        /// <summary>
        /// Gets and sets the property DatabaseSourceDescription. 
        /// <para>
        /// Details about a database used as the source for a Firehose stream.
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseSourceDescription DatabaseSourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseSourceDescription property is set.
        /// </summary>
        internal bool IsSetDatabaseSourceDescription() => this.DatabaseSourceDescription != null;

        /// <summary>
        /// Gets and sets the property DirectPutSourceDescription. 
        /// <para>
        /// Details about Direct PUT used as the source for a Firehose stream. 
        /// </para>
        /// </summary>
        public DirectPutSourceDescription DirectPutSourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the DirectPutSourceDescription property is set.
        /// </summary>
        internal bool IsSetDirectPutSourceDescription() => this.DirectPutSourceDescription != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamSourceDescription. 
        /// <para>
        /// The <a>KinesisStreamSourceDescription</a> value for the source Kinesis data stream.
        /// </para>
        /// </summary>
        public KinesisStreamSourceDescription KinesisStreamSourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamSourceDescription property is set.
        /// </summary>
        internal bool IsSetKinesisStreamSourceDescription() => this.KinesisStreamSourceDescription != null;

        /// <summary>
        /// Gets and sets the property MSKSourceDescription. 
        /// <para>
        /// The configuration description for the Amazon MSK cluster to be used as the source
        /// for a delivery stream.
        /// </para>
        /// </summary>
        public MSKSourceDescription MSKSourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the MSKSourceDescription property is set.
        /// </summary>
        internal bool IsSetMSKSourceDescription() => this.MSKSourceDescription != null;
    }
}
