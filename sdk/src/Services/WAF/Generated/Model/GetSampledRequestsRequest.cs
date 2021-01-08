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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the GetSampledRequests operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Gets detailed information about a specified number of requests--a sample--that AWS
    /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
    /// during a time range that you choose. You can specify a sample size of up to 500 requests,
    /// and you can specify any time range in the previous three hours.
    /// </para>
    ///  
    /// <para>
    ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
    /// that you specified. However, if your resource (such as a CloudFront distribution)
    /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
    /// returns an updated time range. This new time range indicates the actual period during
    /// which AWS WAF selected the requests in the sample.
    /// </para>
    /// </summary>
    public partial class GetSampledRequestsRequest : AmazonWAFRequest
    {
        private long? _maxItems;
        private string _ruleId;
        private TimeWindow _timeWindow;
        private string _webAclId;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The number of requests that you want AWS WAF to return from among the first 5,000
        /// requests that your AWS resource received during the time range. If your resource received
        /// fewer requests than the value of <code>MaxItems</code>, <code>GetSampledRequests</code>
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
        /// Gets and sets the property RuleId. 
        /// <para>
        ///  <code>RuleId</code> is one of three values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>RuleId</code> of the <code>Rule</code> or the <code>RuleGroupId</code> of
        /// the <code>RuleGroup</code> for which you want <code>GetSampledRequests</code> to return
        /// a sample of requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Default_Action</code>, which causes <code>GetSampledRequests</code> to return
        /// a sample of the requests that didn't match any of the rules in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The start date and time and the end date and time of the range for which you want
        /// <code>GetSampledRequests</code> to return a sample of requests. You must specify the
        /// times in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, <code>Z</code>. For example, <code>"2016-09-27T14:50Z"</code>. You can
        /// specify any time range in the previous three hours.
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
        /// Gets and sets the property WebAclId. 
        /// <para>
        /// The <code>WebACLId</code> of the <code>WebACL</code> for which you want <code>GetSampledRequests</code>
        /// to return a sample of requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WebAclId
        {
            get { return this._webAclId; }
            set { this._webAclId = value; }
        }

        // Check to see if WebAclId property is set
        internal bool IsSetWebAclId()
        {
            return this._webAclId != null;
        }

    }
}