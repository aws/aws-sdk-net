/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribePlacementGroupsRequest : AmazonEC2Request
    {
        private List<string> groupNames = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more placement group names. Default: Describes all your placement groups, or only those otherwise specified.
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>group-name</c> - The name of the placement group. </li> <li> <c>state</c> - The state of the placement
        /// group (<c>pending</c> | <c>available</c> | <c>deleting</c> | <c>deleted</c>). </li> <li> <c>strategy</c> - The strategy of the placement
        /// group (<c>cluster</c>). </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
