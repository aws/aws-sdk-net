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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricWidgetImage operation.
    /// You can use the <code>GetMetricWidgetImage</code> API to retrieve a snapshot graph
    /// of one or more Amazon CloudWatch metrics as a bitmap image. You can then embed this
    /// image into your services and products, such as wiki pages, reports, and documents.
    /// You could also retrieve images regularly, such as every minute, and create your own
    /// custom live dashboard.
    /// 
    ///  
    /// <para>
    /// The graph you retrieve can include all CloudWatch metric graph features, including
    /// metric math and horizontal and vertical annotations.
    /// </para>
    ///  
    /// <para>
    /// There is a limit of 20 transactions per second for this API. Each <code>GetMetricWidgetImage</code>
    /// action has the following limits:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// As many as 100 metrics in the graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Up to 100 KB uncompressed payload.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetMetricWidgetImageRequest : AmazonCloudWatchRequest
    {
        private string _metricWidget;
        private string _outputFormat;

        /// <summary>
        /// Gets and sets the property MetricWidget. 
        /// <para>
        /// A JSON string that defines the bitmap graph to be retrieved. The string includes the
        /// metrics to include in the graph, statistics, annotations, title, axis limits, and
        /// so on. You can include only one <code>MetricWidget</code> parameter in each <code>GetMetricWidgetImage</code>
        /// call.
        /// </para>
        ///  
        /// <para>
        /// For more information about the syntax of <code>MetricWidget</code> see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CloudWatch-Metric-Widget-Structure.html">GetMetricWidgetImage:
        /// Metric Widget Structure and Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// If any metric on the graph could not load all the requested data points, an orange
        /// triangle with an exclamation point appears next to the graph legend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricWidget
        {
            get { return this._metricWidget; }
            set { this._metricWidget = value; }
        }

        // Check to see if MetricWidget property is set
        internal bool IsSetMetricWidget()
        {
            return this._metricWidget != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The format of the resulting image. Only PNG images are supported.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>png</code>. If you specify <code>png</code>, the API returns
        /// an HTTP response with the content-type set to <code>text/xml</code>. The image data
        /// is in a <code>MetricWidgetImage</code> field. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;GetMetricWidgetImageResponse xmlns=&lt;URLstring&gt;&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;GetMetricWidgetImageResult&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;MetricWidgetImage&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> iVBORw0KGgoAAAANSUhEUgAAAlgAAAGQEAYAAAAip...</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;/MetricWidgetImage&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;/GetMetricWidgetImageResult&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;ResponseMetadata&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;RequestId&gt;6f0d4192-4d42-11e8-82c1-f539a07e0e3b&lt;/RequestId&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;/ResponseMetadata&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;/GetMetricWidgetImageResponse&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// The <code>image/png</code> setting is intended only for custom HTTP requests. For
        /// most use cases, and all actions using an AWS SDK, you should use <code>png</code>.
        /// If you specify <code>image/png</code>, the HTTP response has a content-type set to
        /// <code>image/png</code>, and the body of the response is a PNG image. 
        /// </para>
        /// </summary>
        public string OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

    }
}