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
    /// This is the response object from the DescribeOrganizationOverview operation.
    /// </summary>
    public partial class DescribeOrganizationOverviewResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ProactiveInsights. 
        /// <para>
        /// An integer that specifies the number of open proactive insights in your Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProactiveInsights { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveInsights property is set.
        /// </summary>
        internal bool IsSetProactiveInsights() => this.ProactiveInsights.HasValue;

        /// <summary>
        /// Gets and sets the property ReactiveInsights. 
        /// <para>
        /// An integer that specifies the number of open reactive insights in your Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ReactiveInsights { get; set; }

        /// <summary>
        /// Checks to see if the ReactiveInsights property is set.
        /// </summary>
        internal bool IsSetReactiveInsights() => this.ReactiveInsights.HasValue;
    }
}
