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
    /// For a SQL-based Kinesis Data Analytics application, describes the mapping of each
    /// data element in the streaming source to the corresponding column in the in-application
    /// stream.
    /// 
    ///  
    /// <para>
    /// Also used to describe the format of the reference data source.
    /// </para>
    /// </summary>
    public partial class RecordColumn
    {
        private string _mapping;
        private string _name;
        private string _sqlType;

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// A reference to the data element in the streaming input or the reference data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public string Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column that is created in the in-application input stream or reference
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SqlType. 
        /// <para>
        /// The type of column created in the in-application input stream or reference table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SqlType
        {
            get { return this._sqlType; }
            set { this._sqlType = value; }
        }

        // Check to see if SqlType property is set
        internal bool IsSetSqlType()
        {
            return this._sqlType != null;
        }

    }
}