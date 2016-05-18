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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeScalingActivities operation.
    /// </summary>
    public partial class DescribeScalingActivitiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScalingActivity> _scalingActivities = new List<ScalingActivity>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>NextToken</code> value to include in a future <code>DescribeScalingActivities</code>
        /// request. When the results of a <code>DescribeScalingActivities</code> request exceed
        /// <code>MaxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is <code>null</code> when there are no more results to return.
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
        /// Gets and sets the property ScalingActivities. 
        /// <para>
        /// A list of scaling activity objects.
        /// </para>
        /// </summary>
        public List<ScalingActivity> ScalingActivities
        {
            get { return this._scalingActivities; }
            set { this._scalingActivities = value; }
        }

        // Check to see if ScalingActivities property is set
        internal bool IsSetScalingActivities()
        {
            return this._scalingActivities != null && this._scalingActivities.Count > 0; 
        }

    }
}