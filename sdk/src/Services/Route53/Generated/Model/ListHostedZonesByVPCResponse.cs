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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the ListHostedZonesByVPC operation.
    /// </summary>
    public partial class ListHostedZonesByVPCResponse : AmazonWebServiceResponse
    {
        private List<HostedZoneSummary> _hostedZoneSummaries = new List<HostedZoneSummary>();
        private string _maxItems;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HostedZoneSummaries. 
        /// <para>
        /// A list that contains one <code>HostedZoneSummary</code> element for each hosted zone
        /// that the specified Amazon VPC is associated with. Each <code>HostedZoneSummary</code>
        /// element contains the hosted zone name and ID, and information about who owns the hosted
        /// zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HostedZoneSummary> HostedZoneSummaries
        {
            get { return this._hostedZoneSummaries; }
            set { this._hostedZoneSummaries = value; }
        }

        // Check to see if HostedZoneSummaries property is set
        internal bool IsSetHostedZoneSummaries()
        {
            return this._hostedZoneSummaries != null && this._hostedZoneSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for <code>MaxItems</code> in the most recent <code>ListHostedZonesByVPC</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value that you specified for <code>NextToken</code> in the most recent <code>ListHostedZonesByVPC</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}