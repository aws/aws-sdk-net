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
    /// The InfluxDB rule action converts the message payload into InfluxDB line protocol.
    /// It writes the result to a table in an InfluxDB database. The database can be an Amazon
    /// Timestream for InfluxDB instance or a self-managed InfluxDB cluster.
    /// 
    ///  
    /// <para>
    /// The action connects to InfluxDB through an InfluxDB topic rule destination, which
    /// must be in the <c>ENABLED</c> state before the action can write data.
    /// </para>
    /// </summary>
    public partial class InfluxDBAction
    {
        /// <summary>
        /// Gets and sets the property BatchConfig. 
        /// <para>
        /// The batching configuration for the action. When present, IoT collects data points
        /// from multiple messages and writes them to InfluxDB in a single request.
        /// </para>
        ///  
        /// <para>
        /// If omitted, each message is written to InfluxDB in its own request.
        /// </para>
        /// </summary>
        public InfluxDBBatchConfig BatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the BatchConfig property is set.
        /// </summary>
        internal bool IsSetBatchConfig() => this.BatchConfig != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the InfluxDB database to write to. In InfluxDB 2, this is the name of
        /// the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the InfluxDB topic rule destination that identifies the InfluxDB instance
        /// to write to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The name of the InfluxDB organization that owns the database.
        /// </para>
        ///  
        /// <para>
        /// A write to an InfluxDB 2 instance fails if this value isn't set. This value isn't
        /// used when the destination is an InfluxDB 3 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to retrieve the InfluxDB API token from
        /// Amazon Web Services Secrets Manager.
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
        /// The name of the table to write the data point to. This is the measurement name of
        /// the InfluxDB line protocol record.
        /// </para>
        ///  
        /// <para>
        /// Accepts substitution templates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The set of tags to write with each data point. Tags are the indexed metadata of an
        /// InfluxDB data point.
        /// </para>
        ///  
        /// <para>
        /// Tag names and tag values accept substitution templates. A tag name can't use the <c>@{...}</c>
        /// per-element form. A tag name must resolve to the same value for every element of an
        /// array payload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 498)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimestampUnit. 
        /// <para>
        /// The precision of the timestamp written with each data point. Valid values are <c>s</c>
        /// (seconds), <c>ms</c> (milliseconds), <c>us</c> (microseconds), and <c>ns</c> (nanoseconds).
        /// </para>
        ///  
        /// <para>
        /// If omitted, the topic rule action uses <c>ms</c>.
        /// </para>
        /// </summary>
        public InfluxDBTimestampUnit TimestampUnit { get; set; }

        /// <summary>
        /// Checks to see if the TimestampUnit property is set.
        /// </summary>
        internal bool IsSetTimestampUnit() => this.TimestampUnit != null;
    }
}
