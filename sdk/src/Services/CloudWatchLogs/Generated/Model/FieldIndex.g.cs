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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure describes one log event field that is used as an index in at least
    /// one index policy in this account.
    /// </summary>
    public partial class FieldIndex
    {
        /// <summary>
        /// Gets and sets the property FieldIndexName. 
        /// <para>
        /// The string that this field index matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FieldIndexName { get; set; }

        /// <summary>
        /// Checks to see if the FieldIndexName property is set.
        /// </summary>
        internal bool IsSetFieldIndexName() => this.FieldIndexName != null;

        /// <summary>
        /// Gets and sets the property FirstEventTime. 
        /// <para>
        /// The time and date of the earliest log event that matches this field index, after the
        /// index policy that contains it was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FirstEventTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstEventTime property is set.
        /// </summary>
        internal bool IsSetFirstEventTime() => this.FirstEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property IndexCategory. 
        /// <para>
        /// The category of the field index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEFAULT</c>: Fields that CloudWatch Logs indexes by default. Examples include
        /// <c>@logStream</c> and <c>@data_format</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c>: Fields that you added manually to the field index policy. CloudWatch
        /// Logs always indexes these fields. These fields count toward the quota of 20 fields
        /// for each log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO</c>: Fields that CloudWatch Logs indexes automatically based on your query
        /// patterns and usage. These fields do not count toward the field index quota. CloudWatch
        /// Logs might update these fields based on changes in your query patterns. To keep a
        /// field indexed permanently, add it to an account-level or log-group level field index
        /// policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: Fields that CloudWatch Logs indexed before but does not index now.
        /// This happens if you remove a field from the field index policy or if CloudWatch Logs
        /// automatically selects a different field based on your queries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about automatically indexed fields, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing-Automatic.html">Automatically
        /// indexed fields</a>.
        /// </para>
        /// </summary>
        public IndexCategory IndexCategory { get; set; }

        /// <summary>
        /// Checks to see if the IndexCategory property is set.
        /// </summary>
        internal bool IsSetIndexCategory() => this.IndexCategory != null;

        /// <summary>
        /// Gets and sets the property LastEventTime. 
        /// <para>
        /// The time and date of the most recent log event that matches this field index. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastEventTime { get; set; }

        /// <summary>
        /// Checks to see if the LastEventTime property is set.
        /// </summary>
        internal bool IsSetLastEventTime() => this.LastEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastScanTime. 
        /// <para>
        /// The most recent time that CloudWatch Logs scanned ingested log events to search for
        /// this field index to improve the speed of future CloudWatch Logs Insights queries that
        /// search for this field index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastScanTime { get; set; }

        /// <summary>
        /// Checks to see if the LastScanTime property is set.
        /// </summary>
        internal bool IsSetLastScanTime() => this.LastScanTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// If this field index appears in an index policy that applies only to a single log group,
        /// the ARN of that log group is displayed here.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LogGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifier() => this.LogGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of index. Specify <c>FACET</c> for facet-based indexing or <c>FIELD_INDEX</c>
        /// for field-based indexing. This determines how the field is indexed and can be queried.
        /// </para>
        /// </summary>
        public IndexType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
