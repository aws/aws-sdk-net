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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountHealth operation.
    /// </summary>
    public partial class DescribeAccountHealthResponse : AmazonWebServiceResponse
    {
        private int? _metricsAnalyzed;
        private int? _openProactiveInsights;
        private int? _openReactiveInsights;
        private long? _resourceHours;

        /// <summary>
        /// Gets and sets the property MetricsAnalyzed. 
        /// <para>
        ///  An integer that specifies the number of metrics that have been analyzed in your AWS
        /// account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MetricsAnalyzed
        {
            get { return this._metricsAnalyzed.GetValueOrDefault(); }
            set { this._metricsAnalyzed = value; }
        }

        // Check to see if MetricsAnalyzed property is set
        internal bool IsSetMetricsAnalyzed()
        {
            return this._metricsAnalyzed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenProactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open proactive insights in your AWS account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int OpenProactiveInsights
        {
            get { return this._openProactiveInsights.GetValueOrDefault(); }
            set { this._openProactiveInsights = value; }
        }

        // Check to see if OpenProactiveInsights property is set
        internal bool IsSetOpenProactiveInsights()
        {
            return this._openProactiveInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenReactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open reactive insights in your AWS account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int OpenReactiveInsights
        {
            get { return this._openReactiveInsights.GetValueOrDefault(); }
            set { this._openReactiveInsights = value; }
        }

        // Check to see if OpenReactiveInsights property is set
        internal bool IsSetOpenReactiveInsights()
        {
            return this._openReactiveInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceHours. 
        /// <para>
        /// The number of Amazon DevOps Guru resource analysis hours billed to the current AWS
        /// account in the last hour. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ResourceHours
        {
            get { return this._resourceHours.GetValueOrDefault(); }
            set { this._resourceHours = value; }
        }

        // Check to see if ResourceHours property is set
        internal bool IsSetResourceHours()
        {
            return this._resourceHours.HasValue; 
        }

    }
}