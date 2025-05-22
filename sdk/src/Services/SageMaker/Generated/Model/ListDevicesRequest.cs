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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListDevices operation.
    /// A list of devices.
    /// </summary>
    public partial class ListDevicesRequest : AmazonSageMakerRequest
    {
        private string _deviceFleetName;
        private DateTime? _latestHeartbeatAfter;
        private int? _maxResults;
        private string _modelName;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// Filter for fleets containing this name in their device fleet name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestHeartbeatAfter. 
        /// <para>
        /// Select fleets where the job was updated after X
        /// </para>
        /// </summary>
        public DateTime? LatestHeartbeatAfter
        {
            get { return this._latestHeartbeatAfter; }
            set { this._latestHeartbeatAfter = value; }
        }

        // Check to see if LatestHeartbeatAfter property is set
        internal bool IsSetLatestHeartbeatAfter()
        {
            return this._latestHeartbeatAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to select.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// A filter that searches devices that contains this name in any of their models.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The response from the last list when returning a list large enough to need tokening.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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

    }
}