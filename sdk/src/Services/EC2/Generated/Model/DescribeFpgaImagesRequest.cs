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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFpgaImages operation.
    /// Describes the Amazon FPGA Images (AFIs) available to you. These include public AFIs,
    /// private AFIs that you own, and AFIs owned by other Amazon Web Services accounts for
    /// which you have load permissions.
    /// </summary>
    public partial class DescribeFpgaImagesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _fpgaImageIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _owners = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>create-time</c> - The creation time of the AFI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fpga-image-id</c> - The FPGA image identifier (AFI ID).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fpga-image-global-id</c> - The global FPGA image identifier (AGFI ID).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> - The name of the AFI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the AFI owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-code</c> - The product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>shell-version</c> - The version of the Amazon Web Services Shell that was used
        /// to create the bitstream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the AFI (<c>pending</c> | <c>failed</c> | <c>available</c>
        /// | <c>unavailable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>update-time</c> - The time of the most recent update.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FpgaImageIds. 
        /// <para>
        /// The AFI IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FpgaImageIds
        {
            get { return this._fpgaImageIds; }
            set { this._fpgaImageIds = value; }
        }

        // Check to see if FpgaImageIds property is set
        internal bool IsSetFpgaImageIds()
        {
            return this._fpgaImageIds != null && (this._fpgaImageIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// Filters the AFI by owner. Specify an Amazon Web Services account ID, <c>self</c> (owner
        /// is the sender of the request), or an Amazon Web Services owner alias (valid values
        /// are <c>amazon</c> | <c>aws-marketplace</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && (this._owners.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}