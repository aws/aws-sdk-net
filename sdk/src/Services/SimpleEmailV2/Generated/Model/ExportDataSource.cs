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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains details about the data source of the export job. It can only
    /// contain one of <c>MetricsDataSource</c> or <c>MessageInsightsDataSource</c> object.
    /// </summary>
    public partial class ExportDataSource
    {
        private MessageInsightsDataSource _messageInsightsDataSource;
        private MetricsDataSource _metricsDataSource;

        /// <summary>
        /// Gets and sets the property MessageInsightsDataSource.
        /// </summary>
        public MessageInsightsDataSource MessageInsightsDataSource
        {
            get { return this._messageInsightsDataSource; }
            set { this._messageInsightsDataSource = value; }
        }

        // Check to see if MessageInsightsDataSource property is set
        internal bool IsSetMessageInsightsDataSource()
        {
            return this._messageInsightsDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsDataSource.
        /// </summary>
        public MetricsDataSource MetricsDataSource
        {
            get { return this._metricsDataSource; }
            set { this._metricsDataSource = value; }
        }

        // Check to see if MetricsDataSource property is set
        internal bool IsSetMetricsDataSource()
        {
            return this._metricsDataSource != null;
        }

    }
}