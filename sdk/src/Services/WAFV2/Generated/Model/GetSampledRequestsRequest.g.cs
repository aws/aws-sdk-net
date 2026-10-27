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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetSampledRequests operation. Gets detailed information
    /// about a specified number of requests--a sample--that WAF randomly selects from among
    /// the first 5,000 requests that your Amazon Web Services resource received during a
    /// time range that you choose. You can specify a sample size of up to 500 requests, and
    /// you can specify any time range in the previous three hours. <para> <c>GetSampledRequests</c>
    /// returns a time range, which is usually the time range that you specified. However,
    /// if your resource (such as a CloudFront distribution) received 5,000 requests before
    /// the specified time range elapsed, <c>GetSampledRequests</c> returns an updated time
    /// range. This new time range indicates the actual period during which WAF selected the
    /// requests in the sample. </para>
    /// </summary>
    public partial class GetSampledRequestsRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The number of requests that you want WAF to return from among the first 5,000 requests
        /// that your Amazon Web Services resource received during the time range. If your resource
        /// received fewer requests than the value of <c>MaxItems</c>, <c>GetSampledRequests</c>
        /// returns information about all of them. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public long? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property RuleMetricName. 
        /// <para>
        /// The metric name assigned to the <c>Rule</c> or <c>RuleGroup</c> dimension for which
        /// you want a sample of requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RuleMetricName { get; set; }

        /// <summary>
        /// Checks to see if the RuleMetricName property is set.
        /// </summary>
        internal bool IsSetRuleMetricName() => this.RuleMetricName != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The start date and time and the end date and time of the range for which you want
        /// <c>GetSampledRequests</c> to return a sample of requests. You must specify the times
        /// in Coordinated Universal Time (UTC) format. UTC format includes the special designator,
        /// <c>Z</c>. For example, <c>"2016-09-27T14:50Z"</c>. You can specify any time range
        /// in the previous three hours. If you specify a start time that's earlier than three
        /// hours ago, WAF sets it to three hours ago.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the <c>WebACL</c> for which you want a sample of
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
