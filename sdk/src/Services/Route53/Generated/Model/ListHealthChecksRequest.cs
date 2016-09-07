/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthChecks operation.
    /// Retrieve a list of your health checks. Send a <code>GET</code> request to the <code>/2013-04-01/healthcheck</code>
    /// resource. The response to this request includes a <code>HealthChecks</code> element
    /// with zero or more <code>HealthCheck</code> child elements. By default, the list of
    /// health checks is displayed on a single page. You can control the length of the page
    /// that is displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
    /// parameter to control the health check that the list begins with.
    /// 
    ///  
    /// <para>
    /// For information about listing health checks using the Amazon Route 53 console, see
    /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
    /// Route 53 Health Checks and DNS Failover</a>.
    /// </para>
    /// </summary>
    public partial class ListHealthChecksRequest : AmazonRoute53Request
    {
        private string _marker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the response to a <code>ListHealthChecks</code> is more than one page, marker is
        /// the health check ID for the first health check on the next page of results. For more
        /// information, see <a>ListHealthChecksResponse$MaxItems</a>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of <code>HealthCheck</code> elements you want <code>ListHealthChecks</code>
        /// to return on each page of the response body. If the AWS account includes more <code>HealthCheck</code>
        /// elements than the value of <code>maxitems</code>, the response is broken into pages.
        /// Each page contains the number of <code>HealthCheck</code> elements specified by <code>maxitems</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you specify <code>10</code> for <code>maxitems</code> and the
        /// current AWS account has <code>51</code> health checks. In the response, <code>ListHealthChecks</code>
        /// sets <a>ListHealthChecksResponse$IsTruncated</a> to true and includes the <a>ListHealthChecksResponse$NextMarker</a>
        /// element. To access the second and subsequent pages, you resend the <code>GET</code>
        /// <code>ListHealthChecks</code> request, add the <a>ListHealthChecksResponse$Marker</a>
        /// parameter to the request, and specify the value of the <a>ListHealthChecksResponse$NextMarker</a>
        /// element from the previous response. On the last (sixth) page of the response, which
        /// contains only one HealthCheck element:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <a>ListHealthChecksResponse$IsTruncated</a> is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListHealthChecksResponse$NextMarker</a> is omitted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}