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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMetricsExport operation.
    /// Describes the metrics of the application configuration being exported.
    /// </summary>
    public partial class DescribeMetricsExportRequest : AmazonResilienceHubRequest
    {
        private string _metricsExportId;

        /// <summary>
        /// Gets and sets the property MetricsExportId. 
        /// <para>
        /// Identifier of the metrics export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricsExportId
        {
            get { return this._metricsExportId; }
            set { this._metricsExportId = value; }
        }

        // Check to see if MetricsExportId property is set
        internal bool IsSetMetricsExportId()
        {
            return this._metricsExportId != null;
        }

    }
}