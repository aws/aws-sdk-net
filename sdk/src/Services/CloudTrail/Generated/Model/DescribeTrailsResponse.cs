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
    /// Returns the objects or data listed below if successful. Otherwise, returns an error.
    /// </summary>
    public partial class DescribeTrailsResponse : AmazonWebServiceResponse
    {
        private List<Trail> _trailList = new List<Trail>();

        /// <summary>
        /// Gets and sets the property TrailList. 
        /// <para>
        /// The list of trail objects. Trail objects with string values are only returned if values
        /// for the objects exist in a trail's configuration. For example, <code>SNSTopicName</code>
        /// and <code>SNSTopicARN</code> are only returned in results if a trail is configured
        /// to send SNS notifications. Similarly, <code>KMSKeyId</code> only appears in results
        /// if a trail's log files are encrypted with AWS KMS-managed keys.
        /// </para>
        /// </summary>
        public List<Trail> TrailList
        {
            get { return this._trailList; }
            set { this._trailList = value; }
        }

        // Check to see if TrailList property is set
        internal bool IsSetTrailList()
        {
            return this._trailList != null && this._trailList.Count > 0; 
        }

    }
}