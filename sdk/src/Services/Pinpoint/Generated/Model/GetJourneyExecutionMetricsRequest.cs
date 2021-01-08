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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the GetJourneyExecutionMetrics operation.
    /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
    /// to a journey.
    /// </summary>
    public partial class GetJourneyExecutionMetricsRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private string _journeyId;
        private string _nextToken;
        private string _pageSize;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property JourneyId. 
        /// <para>
        /// The unique identifier for the journey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JourneyId
        {
            get { return this._journeyId; }
            set { this._journeyId = value; }
        }

        // Check to see if JourneyId property is set
        internal bool IsSetJourneyId()
        {
            return this._journeyId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The  string that specifies which page of results to return in a paginated response.
        /// This parameter is not supported for application, campaign, and journey metrics.
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
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to include in each page of a paginated response. This
        /// parameter is not supported for application, campaign, and journey metrics.
        /// </para>
        /// </summary>
        public string PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize != null;
        }

    }
}