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
    /// Container for the parameters to the ListRegexPatternSets operation.
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
    /// sets that you manage.
    /// </para>
    /// </summary>
    public partial class ListRegexPatternSetsRequest : AmazonWAFV2Request
    {
        private int? _limit;
        private string _nextMarker;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of objects that you want AWS WAF to return for this request. If
        /// more objects are available, in the response, AWS WAF provides a <code>NextMarker</code>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <code>Limit</code> setting, if the number
        /// of objects that are still available for retrieval exceeds the limit, AWS WAF returns
        /// a <code>NextMarker</code> value in the response. To retrieve the next batch of objects,
        /// provide the marker from the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an AWS CloudFront distribution or for a regional application.
        /// A regional application can be an Application Load Balancer (ALB), an API Gateway REST
        /// API, or an AppSync GraphQL API. 
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

    }
}