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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrails operation.
    /// Retrieves settings for the trail associated with the current region for your account.
    /// </summary>
    public partial class DescribeTrailsRequest : AmazonCloudTrailRequest
    {
        private List<string> _trailNameList = new List<string>();

        /// <summary>
        /// Gets and sets the property TrailNameList. 
        /// <para>
        /// Specifies a list of trail names, trail ARNs, or both, of the trails to describe. The
        /// format of a trail ARN is <code>arn:aws:cloudtrail:us-east-1:123456789012:trail/MyTrail</code>.
        /// If an empty list is specified, information for the trail in the current region is
        /// returned.
        /// </para>
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