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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrails operation.
    /// Retrieves settings for one or more trails associated with the current region for your
    /// account.
    /// </summary>
    public partial class DescribeTrailsRequest : AmazonCloudTrailRequest
    {
        private bool? _includeShadowTrails;
        private List<string> _trailNameList = new List<string>();

        /// <summary>
        /// Gets and sets the property IncludeShadowTrails. 
        /// <para>
        /// Specifies whether to include shadow trails in the response. A shadow trail is the
        /// replication in a region of a trail that was created in a different region, or in the
        /// case of an organization trail, the replication of an organization trail in member
        /// accounts. If you do not include shadow trails, organization trails in a member account
        /// and region replication trails will not be returned. The default is true.
        /// </para>
        /// </summary>
        public bool IncludeShadowTrails
        {
            get { return this._includeShadowTrails.GetValueOrDefault(); }
            set { this._includeShadowTrails = value; }
        }

        // Check to see if IncludeShadowTrails property is set
        internal bool IsSetIncludeShadowTrails()
        {
            return this._includeShadowTrails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrailNameList. 
        /// <para>
        /// Specifies a list of trail names, trail ARNs, or both, of the trails to describe. The
        /// format of a trail ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
        /// </para>
        ///  
        /// <para>
        /// If an empty list is specified, information for the trail in the current region is
        /// returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If an empty list is specified and <code>IncludeShadowTrails</code> is false, then
        /// information for all trails in the current region is returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If an empty list is specified and IncludeShadowTrails is null or true, then information
        /// for all trails in the current region and any associated shadow trails in other regions
        /// is returned.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If one or more trail names are specified, information is returned only if the names
        /// match the names of trails belonging only to the current region and current account.
        /// To return information about a trail in another region, you must specify its trail
        /// ARN.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> TrailNameList
        {
            get { return this._trailNameList; }
            set { this._trailNameList = value; }
        }

        // Check to see if TrailNameList property is set
        internal bool IsSetTrailNameList()
        {
            return this._trailNameList != null && this._trailNameList.Count > 0; 
        }

    }
}