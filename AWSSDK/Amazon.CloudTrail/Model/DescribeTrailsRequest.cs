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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrails operation.
    /// <para>Retrieves the settings for some or all trails associated with an account. Returns a list of Trail structures in JSON format.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudTrail.AmazonCloudTrail.DescribeTrails"/>
    public class DescribeTrailsRequest : AmazonWebServiceRequest
    {
        private List<string> trailNameList = new List<string>();

        /// <summary>
        /// The list of <a>Trail</a> object names.
        ///  
        /// </summary>
        public List<string> TrailNameList
        {
            get { return this.trailNameList; }
            set { this.trailNameList = value; }
        }
        /// <summary>
        /// Adds elements to the TrailNameList collection
        /// </summary>
        /// <param name="trailNameList">The values to add to the TrailNameList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrailsRequest WithTrailNameList(params string[] trailNameList)
        {
            foreach (string element in trailNameList)
            {
                this.trailNameList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TrailNameList collection
        /// </summary>
        /// <param name="trailNameList">The values to add to the TrailNameList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrailsRequest WithTrailNameList(IEnumerable<string> trailNameList)
        {
            foreach (string element in trailNameList)
            {
                this.trailNameList.Add(element);
            }

            return this;
        }

        // Check to see if TrailNameList property is set
        internal bool IsSetTrailNameList()
        {
            return this.trailNameList.Count > 0;
        }
    }
}
    
