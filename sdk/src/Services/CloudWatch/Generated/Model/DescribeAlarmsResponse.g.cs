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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the DescribeAlarms operation.
    /// </summary>
    public partial class DescribeAlarmsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompositeAlarms. 
        /// <para>
        /// The information about any composite alarms returned by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CompositeAlarm> CompositeAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<CompositeAlarm>() : null;

        /// <summary>
        /// Checks to see if the CompositeAlarms property is set.
        /// </summary>
        internal bool IsSetCompositeAlarms() => this.CompositeAlarms != null && (this.CompositeAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogAlarms. 
        /// <para>
        /// The information about any log alarms returned by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogAlarm> LogAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<LogAlarm>() : null;

        /// <summary>
        /// Checks to see if the LogAlarms property is set.
        /// </summary>
        internal bool IsSetLogAlarms() => this.LogAlarms != null && (this.LogAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricAlarms. 
        /// <para>
        /// The information about any metric alarms returned by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricAlarm> MetricAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricAlarm>() : null;

        /// <summary>
        /// Checks to see if the MetricAlarms property is set.
        /// </summary>
        internal bool IsSetMetricAlarms() => this.MetricAlarms != null && (this.MetricAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that marks the start of the next batch of returned results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
