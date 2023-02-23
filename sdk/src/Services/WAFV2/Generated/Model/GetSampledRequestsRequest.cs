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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetSampledRequests operation.
    /// Gets detailed information about a specified number of requests--a sample--that WAF
    /// randomly selects from among the first 5,000 requests that your Amazon Web Services
    /// resource received during a time range that you choose. You can specify a sample size
    /// of up to 500 requests, and you can specify any time range in the previous three hours.
    /// 
    ///  
    /// <para>
    ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
    /// that you specified. However, if your resource (such as a CloudFront distribution)
    /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
    /// returns an updated time range. This new time range indicates the actual period during
    /// which WAF selected the requests in the sample.
    /// </para>
    /// </summary>
    public partial class GetSampledRequestsRequest : AmazonWAFV2Request
    {
        private long? _maxItems;
        private string _ruleMetricName;
        private Scope _scope;
        private TimeWindow _timeWindow;
        private string _webAclArn;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The number of requests that you want WAF to return from among the first 5,000 requests
        /// that your Amazon Web Services resource received during the time range. If your resource
        /// received fewer requests than the value of <code>MaxItems</code>, <code>GetSampledRequests</code>
        /// returns information about all of them. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public long MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleMetricName. 
        /// <para>
        /// The metric name assigned to the <code>Rule</code> or <code>RuleGroup</code> dimension
        /// for which you want a sample of requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RuleMetricName
        {
            get { return this._ruleMetricName; }
            set { this._ruleMetricName = value; }
        }

        // Check to see if RuleMetricName property is set
        internal bool IsSetRuleMetricName()
        {
            return this._ruleMetricName != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, a Amazon Cognito user pool, or
        /// an App Runner service. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The start date and time and the end date and time of the range for which you want
        /// <code>GetSampledRequests</code> to return a sample of requests. You must specify the
        /// times in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, <code>Z</code>. For example, <code>"2016-09-27T14:50Z"</code>. You can
        /// specify any time range in the previous three hours. If you specify a start time that's
        /// earlier than three hours ago, WAF sets it to three hours ago.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeWindow TimeWindow
        {
            get { return this._timeWindow; }
            set { this._timeWindow = value; }
        }

        // Check to see if TimeWindow property is set
        internal bool IsSetTimeWindow()
        {
            return this._timeWindow != null;
        }

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the <code>WebACL</code> for which you want a sample
        /// of requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string WebAclArn
        {
            get { return this._webAclArn; }
            set { this._webAclArn = value; }
        }

        // Check to see if WebAclArn property is set
        internal bool IsSetWebAclArn()
        {
            return this._webAclArn != null;
        }

    }
}