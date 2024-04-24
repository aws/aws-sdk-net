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
    /// This is the response object from the GetMetricWidgetImage operation.
    /// </summary>
    public partial class GetMetricWidgetImageResponse : AmazonWebServiceResponse
    {
        private MemoryStream _metricWidgetImage;

        /// <summary>
        /// Gets and sets the property MetricWidgetImage. 
        /// <para>
        /// The image of the graph, in the output format specified. The output is base64-encoded.
        /// </para>
        /// </summary>
        public MemoryStream MetricWidgetImage
        {
            get { return this._metricWidgetImage; }
            set { this._metricWidgetImage = value; }
        }

        // Check to see if MetricWidgetImage property is set
        internal bool IsSetMetricWidgetImage()
        {
            return this._metricWidgetImage != null;
        }

    }
}