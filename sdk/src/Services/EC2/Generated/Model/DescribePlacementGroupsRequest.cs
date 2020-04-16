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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DescribePlacementGroups operation.
    /// Describes the specified placement groups or all of your placement groups. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
    /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </summary>
    public partial class DescribePlacementGroupsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _groupIds = new List<string>();
        private List<string> _groupNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>group-name</code> - The name of the placement group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the placement group (<code>pending</code> | <code>available</code>
        /// | <code>deleting</code> | <code>deleted</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>strategy</code> - The strategy of the placement group (<code>cluster</code>
        /// | <code>spread</code> | <code>partition</code>).
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
        /// to find all resources that have a tag with a specific key, regardless of the tag value.
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
        /// Gets and sets the property GroupIds. 
        /// <para>
        /// The IDs of the placement groups.
        /// </para>
        /// </summary>
        public List<string> GroupIds
        {
            get { return this._groupIds; }
            set { this._groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this._groupIds != null && this._groupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// The names of the placement groups.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your placement groups, or only those otherwise specified.
        /// </para>
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && this._groupNames.Count > 0; 
        }

    }
}