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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
        private string _creationDate;
        private int? _dimensionalValueCount;
        private string _lastEvaluatedDate;
        private string _lastUpdatedDate;
        private string _monitorArn;
        private MonitorDimension _monitorDimension;
        private string _monitorName;
        private Expression _monitorSpecification;
        private MonitorType _monitorType;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the monitor was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionalValueCount. 
        /// <para>
        /// The value for evaluated dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DimensionalValueCount
        {
            get { return this._dimensionalValueCount; }
            set { this._dimensionalValueCount = value; }
        }

        // Check to see if DimensionalValueCount property is set
        internal bool IsSetDimensionalValueCount()
        {
            return this._dimensionalValueCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedDate. 
        /// <para>
        /// The date when the monitor last evaluated for anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string LastEvaluatedDate
        {
            get { return this._lastEvaluatedDate; }
            set { this._lastEvaluatedDate = value; }
        }

        // Check to see if LastEvaluatedDate property is set
        internal bool IsSetLastEvaluatedDate()
        {
            return this._lastEvaluatedDate != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date when the monitor was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorDimension. 
        /// <para>
        /// The dimensions to evaluate. 
        /// </para>
        /// </summary>
        public MonitorDimension MonitorDimension
        {
            get { return this._monitorDimension; }
            set { this._monitorDimension = value; }
        }

        // Check to see if MonitorDimension property is set
        internal bool IsSetMonitorDimension()
        {
            return this._monitorDimension != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorSpecification.
        /// </summary>
        public Expression MonitorSpecification
        {
            get { return this._monitorSpecification; }
            set { this._monitorSpecification = value; }
        }

        // Check to see if MonitorSpecification property is set
        internal bool IsSetMonitorSpecification()
        {
            return this._monitorSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorType. 
        /// <para>
        /// The possible type values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitorType MonitorType
        {
            get { return this._monitorType; }
            set { this._monitorType = value; }
        }

        // Check to see if MonitorType property is set
        internal bool IsSetMonitorType()
        {
            return this._monitorType != null;
        }

    }
}