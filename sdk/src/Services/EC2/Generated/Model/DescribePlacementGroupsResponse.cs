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
    /// This is the response object from the DescribePlacementGroups operation.
    /// </summary>
    public partial class DescribePlacementGroupsResponse : AmazonWebServiceResponse
    {
        private List<PlacementGroup> _placementGroups = new List<PlacementGroup>();

        /// <summary>
        /// Gets and sets the property PlacementGroups. 
        /// <para>
        /// Information about the placement groups.
        /// </para>
        /// </summary>
        public List<PlacementGroup> PlacementGroups
        {
            get { return this._placementGroups; }
            set { this._placementGroups = value; }
        }

        // Check to see if PlacementGroups property is set
        internal bool IsSetPlacementGroups()
        {
            return this._placementGroups != null && this._placementGroups.Count > 0; 
        }

    }
}