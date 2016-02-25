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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcClassicLinkDnsSupport operation.
    /// </summary>
    public partial class DescribeVpcClassicLinkDnsSupportResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ClassicLinkDnsSupport> _vpcs = new List<ClassicLinkDnsSupport>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Vpcs. 
        /// <para>
        /// Information about the ClassicLink DNS support status of the VPCs.
        /// </para>
        /// </summary>
        public List<ClassicLinkDnsSupport> Vpcs
        {
            get { return this._vpcs; }
            set { this._vpcs = value; }
        }

        // Check to see if Vpcs property is set
        internal bool IsSetVpcs()
        {
            return this._vpcs != null && this._vpcs.Count > 0; 
        }

    }
}