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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFpgaImages operation.
    /// Describes the Amazon FPGA Images (AFIs) available to you. These include public AFIs,
    /// private AFIs that you own, and AFIs owned by other AWS accounts for which you have
    /// load permissions.
    /// </summary>
    public partial class DescribeFpgaImagesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _fpgaImageIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _owners = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>create-time</code> - The creation time of the AFI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fpga-image-id</code> - The FPGA image identifier (AFI ID).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fpga-image-global-id</code> - The global FPGA image identifier (AGFI ID).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code> - The name of the AFI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The AWS account ID of the AFI owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-code</code> - The product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>shell-version</code> - The version of the AWS Shell that was used to create
        /// the bitstream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the AFI (<code>pending</code> | <code>failed</code>
        /// | <code>available</code> | <code>unavailable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>update-time</code> - The time of the most recent update.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FpgaImageIds. 
        /// <para>
        /// The AFI IDs.
        /// </para>
        /// </summary>
        public List<string> FpgaImageIds
        {
            get { return this._fpgaImageIds; }
            set { this._fpgaImageIds = value; }
        }

        // Check to see if FpgaImageIds property is set
        internal bool IsSetFpgaImageIds()
        {
            return this._fpgaImageIds != null && this._fpgaImageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results.
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
        /// Gets and sets the property Owners. 
        /// <para>
        /// Filters the AFI by owner. Specify an AWS account ID, <code>self</code> (owner is the
        /// sender of the request), or an AWS owner alias (valid values are <code>amazon</code>
        /// | <code>aws-marketplace</code>).
        /// </para>
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && this._owners.Count > 0; 
        }

    }
}