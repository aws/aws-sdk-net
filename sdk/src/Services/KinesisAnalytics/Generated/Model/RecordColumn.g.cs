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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the mapping of each data element in the streaming source to the corresponding
    /// column in the in-application stream.
    /// 
    ///  
    /// <para>
    /// Also used to describe the format of the reference data source.
    /// </para>
    /// </summary>
    public partial class RecordColumn
    {
        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// Reference to the data element in the streaming input or the reference data source.
        /// This element is required if the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_RecordFormat.html#analytics-Type-RecordFormat-RecordFormatTypel">RecordFormatType</a>
        /// is <c>JSON</c>.
        /// </para>
        /// </summary>
        public string Mapping { get; set; }

        /// <summary>
        /// Checks to see if the Mapping property is set.
        /// </summary>
        internal bool IsSetMapping() => this.Mapping != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the column created in the in-application input stream or reference table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SqlType. 
        /// <para>
        /// Type of column created in the in-application input stream or reference table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string SqlType { get; set; }

        /// <summary>
        /// Checks to see if the SqlType property is set.
        /// </summary>
        internal bool IsSetSqlType() => this.SqlType != null;
    }
}
