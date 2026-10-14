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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This object continuously inspects your account's cost data for anomalies. It's based
    /// on <c>MonitorType</c> and <c>MonitorSpecification</c>. The content consists of detailed
    /// metadata and the current status of the monitor object.
    /// </summary>
    public partial class AnomalyMonitor
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the monitor was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DimensionalValueCount. 
        /// <para>
        /// The value for evaluated dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DimensionalValueCount { get; set; }

        /// <summary>
        /// Checks to see if the DimensionalValueCount property is set.
        /// </summary>
        internal bool IsSetDimensionalValueCount() => this.DimensionalValueCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastEvaluatedDate. 
        /// <para>
        /// The date when the monitor last evaluated for anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string LastEvaluatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedDate property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedDate() => this.LastEvaluatedDate != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date when the monitor was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate != null;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property MonitorDimension. 
        /// <para>
        /// For customer managed monitors, do not specify this field.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services managed monitors, this field controls which cost dimension
        /// is automatically analyzed by the monitor. For <c>TAG</c> and <c>COST_CATEGORY </c>
        /// dimensions, you must also specify MonitorSpecification to configure the specific tag
        /// or cost category key to analyze.
        /// </para>
        /// </summary>
        public MonitorDimension MonitorDimension { get; set; }

        /// <summary>
        /// Checks to see if the MonitorDimension property is set.
        /// </summary>
        internal bool IsSetMonitorDimension() => this.MonitorDimension != null;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

        /// <summary>
        /// Gets and sets the property MonitorSpecification. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object used to control what costs the monitor analyzes for anomalies.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services managed monitors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If MonitorDimension is <c>SERVICE</c> or <c>LINKED_ACCOUNT</c>, do not specify this
        /// field
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If MonitorDimension is <c>TAG</c>, set this field to <c>{ "Tags": { "Key": "your tag
        /// key" } }</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If MonitorDimension is <c>COST_CATEGORY</c>, set this field to <c>{ "CostCategories":
        /// { "Key": "your cost category key" } }</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For customer managed monitors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To track linked accounts, set this field to <c>{ "Dimensions": { "Key": "LINKED_ACCOUNT",
        /// "Values": [ "your list of up to 10 account IDs" ] } } </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To track cost allocation tags, set this field to <c>{ "Tags": { "Key": "your tag key",
        /// "Values": [ "your list of up to 10 tag values" ] } } </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To track cost categories, set this field to<c>{ "CostCategories": { "Key": "your cost
        /// category key", "Values": [ "your cost category value" ] } } </c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Expression MonitorSpecification { get; set; }

        /// <summary>
        /// Checks to see if the MonitorSpecification property is set.
        /// </summary>
        internal bool IsSetMonitorSpecification() => this.MonitorSpecification != null;

        /// <summary>
        /// Gets and sets the property MonitorType. 
        /// <para>
        /// The type of the monitor. 
        /// </para>
        ///  
        /// <para>
        /// Set this to <c>DIMENSIONAL</c> for an Amazon Web Services managed monitor. Amazon
        /// Web Services managed monitors automatically track up to the top 5,000 values by cost
        /// within a dimension of your choosing. Each dimension value is evaluated independently.
        /// If you start incurring cost in a new value of your chosen dimension, it will automatically
        /// be analyzed by an Amazon Web Services managed monitor.
        /// </para>
        ///  
        /// <para>
        /// Set this to <c>CUSTOM</c> for a customer managed monitor. Customer managed monitors
        /// let you select specific dimension values that get monitored in aggregate. 
        /// </para>
        ///  
        /// <para>
        /// For more information about monitor types, see <a href="https://docs.aws.amazon.com/cost-management/latest/userguide/getting-started-ad.html#monitor-type-def">Monitor
        /// types</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitorType MonitorType { get; set; }

        /// <summary>
        /// Checks to see if the MonitorType property is set.
        /// </summary>
        internal bool IsSetMonitorType() => this.MonitorType != null;
    }
}
