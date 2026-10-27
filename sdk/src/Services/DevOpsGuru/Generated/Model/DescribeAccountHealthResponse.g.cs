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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountHealth operation.
    /// </summary>
    public partial class DescribeAccountHealthResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalyzedResourceCount. 
        /// <para>
        ///  Number of resources that DevOps Guru is monitoring in your Amazon Web Services account.
        /// 
        /// </para>
        /// </summary>
        public long? AnalyzedResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedResourceCount property is set.
        /// </summary>
        internal bool IsSetAnalyzedResourceCount() => this.AnalyzedResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property MetricsAnalyzed. 
        /// <para>
        ///  An integer that specifies the number of metrics that have been analyzed in your Amazon
        /// Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MetricsAnalyzed { get; set; }

        /// <summary>
        /// Checks to see if the MetricsAnalyzed property is set.
        /// </summary>
        internal bool IsSetMetricsAnalyzed() => this.MetricsAnalyzed.HasValue;

        /// <summary>
        /// Gets and sets the property OpenProactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open proactive insights in your Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? OpenProactiveInsights { get; set; }

        /// <summary>
        /// Checks to see if the OpenProactiveInsights property is set.
        /// </summary>
        internal bool IsSetOpenProactiveInsights() => this.OpenProactiveInsights.HasValue;

        /// <summary>
        /// Gets and sets the property OpenReactiveInsights. 
        /// <para>
        ///  An integer that specifies the number of open reactive insights in your Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? OpenReactiveInsights { get; set; }

        /// <summary>
        /// Checks to see if the OpenReactiveInsights property is set.
        /// </summary>
        internal bool IsSetOpenReactiveInsights() => this.OpenReactiveInsights.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceHours. 
        /// <para>
        /// The number of Amazon DevOps Guru resource analysis hours billed to the current Amazon
        /// Web Services account in the last hour. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ResourceHours { get; set; }

        /// <summary>
        /// Checks to see if the ResourceHours property is set.
        /// </summary>
        internal bool IsSetResourceHours() => this.ResourceHours.HasValue;
    }
}
