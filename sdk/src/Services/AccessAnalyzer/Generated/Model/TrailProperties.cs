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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains details about the CloudTrail trail being analyzed to generate a policy.
    /// </summary>
    public partial class TrailProperties
    {
        private bool? _allRegions;
        private string _cloudTrailArn;
        private List<string> _regions = new List<string>();

        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        /// Possible values are <code>true</code> or <code>false</code>. If set to <code>true</code>,
        /// IAM Access Analyzer retrieves CloudTrail data from all regions to analyze and generate
        /// a policy.
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
        /// Gets and sets the property CloudTrailArn. 
        /// <para>
        /// Specifies the ARN of the trail. The format of a trail ARN is <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CloudTrailArn
        {
            get { return this._cloudTrailArn; }
            set { this._cloudTrailArn = value; }
        }

        // Check to see if CloudTrailArn property is set
        internal bool IsSetCloudTrailArn()
        {
            return this._cloudTrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of regions to get CloudTrail data from and analyze to generate a policy.
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

    }
}