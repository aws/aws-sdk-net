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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The Timestream rule action writes attributes (measures) from an MQTT message into
    /// an Amazon Timestream table. For more information, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/timestream-rule-action.html">Timestream</a>
    /// topic rule action documentation.
    /// </summary>
    public partial class TimestreamAction
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of an Amazon Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Metadata attributes of the time series that are written in each measure record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public List<TimestreamDimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<TimestreamDimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to write to the Amazon Timestream database
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the database table into which to write the measure records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

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
        public TimestreamTimestamp Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
