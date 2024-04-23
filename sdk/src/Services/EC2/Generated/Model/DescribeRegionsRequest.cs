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
    /// Container for the parameters to the DescribeRegions operation.
    /// Describes the Regions that are enabled for your account, or all Regions.
    /// 
    ///  
    /// <para>
    /// For a list of the Regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/ec2-service.html">
    /// Amazon Elastic Compute Cloud endpoints and quotas</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about enabling and disabling Regions for your account, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// Amazon Web Services Regions</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeRegionsRequest : AmazonEC2Request
    {
        private bool? _allRegions;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _regionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        /// Indicates whether to display all Regions, including Regions that are disabled for
        /// your account.
        /// </para>
        /// </summary>
        public bool AllRegions
        {
            get { return this._allRegions.GetValueOrDefault(); }
            set { this._allRegions = value; }
        }

        // Check to see if AllRegions property is set
        internal bool IsSetAllRegions()
        {
            return this._allRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>endpoint</c> - The endpoint of the Region (for example, <c>ec2.us-east-1.amazonaws.com</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>opt-in-status</c> - The opt-in status of the Region (<c>opt-in-not-required</c>
        /// | <c>opted-in</c> | <c>not-opted-in</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region-name</c> - The name of the Region (for example, <c>us-east-1</c>).
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The names of the Regions. You can specify any Regions, whether they are enabled and
        /// disabled for your account.
        /// </para>
        /// </summary>
        public List<string> RegionNames
        {
            get { return this._regionNames; }
            set { this._regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this._regionNames != null && (this._regionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}