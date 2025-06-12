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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The Timestream rule action writes attributes (measures) from an MQTT message into
    /// an Amazon Timestream table. For more information, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/timestream-rule-action.html">Timestream</a>
    /// topic rule action documentation.
    /// </summary>
    public partial class TimestreamAction
    {
        private string _databaseName;
        private List<TimestreamDimension> _dimensions = AWSConfigs.InitializeCollections ? new List<TimestreamDimension>() : null;
        private string _roleArn;
        private string _tableName;
        private TimestreamTimestamp _timestamp;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of an Amazon Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Metadata attributes of the time series that are written in each measure record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public List<TimestreamDimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to write to the Amazon Timestream database
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the database table into which to write the measure records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Specifies an application-defined value to replace the default value assigned to the
        /// Timestream record's timestamp in the <c>time</c> column.
        /// </para>
        ///  
        /// <para>
        /// You can use this property to specify the value and the precision of the Timestream
        /// record's timestamp. You can specify a value from the message payload or a value computed
        /// by a substitution template.
        /// </para>
        ///  
        /// <para>
        /// If omitted, the topic rule action assigns the timestamp, in milliseconds, at the time
        /// it processed the rule. 
        /// </para>
        /// </summary>
        public TimestreamTimestamp Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}