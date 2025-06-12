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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
    /// Designates the CloudWatch metric and statistic that provides the time series the anomaly
    /// detector uses as input. If you have enabled unified cross-account observability, and
    /// this account is a monitoring account, the metric can be in the same account or a source
    /// account.
    /// </summary>
    public partial class SingleMetricAnomalyDetector
    {
        private string _accountId;
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private string _metricName;
        private string _awsNamespace;
        private string _stat;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// If the CloudWatch metric that provides the time series that the anomaly detector uses
        /// as input is in another account, specify that account ID here. If you omit this parameter,
        /// the current account is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The metric dimensions to create the anomaly detection model for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to create the anomaly detection model for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric to create the anomaly detection model for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic to use for the metric and anomaly detection model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string Stat
        {
            get { return this._stat; }
            set { this._stat = value; }
        }

        // Check to see if Stat property is set
        internal bool IsSetStat()
        {
            return this._stat != null;
        }

    }
}