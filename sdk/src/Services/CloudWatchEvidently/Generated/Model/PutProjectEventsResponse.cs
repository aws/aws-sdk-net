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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This is the response object from the PutProjectEvents operation.
    /// </summary>
    public partial class PutProjectEventsResponse : AmazonWebServiceResponse
    {
        private List<PutProjectEventsResultEntry> _eventResults = AWSConfigs.InitializeCollections ? new List<PutProjectEventsResultEntry>() : null;
        private int? _failedEventCount;

        /// <summary>
        /// Gets and sets the property EventResults. 
        /// <para>
        /// A structure that contains Evidently's response to the sent events, including an event
        /// ID and error codes, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PutProjectEventsResultEntry> EventResults
        {
            get { return this._eventResults; }
            set { this._eventResults = value; }
        }

        // Check to see if EventResults property is set
        internal bool IsSetEventResults()
        {
            return this._eventResults != null && (this._eventResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedEventCount. 
        /// <para>
        /// The number of events in the operation that could not be used by Evidently.
        /// </para>
        /// </summary>
        public int? FailedEventCount
        {
            get { return this._failedEventCount; }
            set { this._failedEventCount = value; }
        }

        // Check to see if FailedEventCount property is set
        internal bool IsSetFailedEventCount()
        {
            return this._failedEventCount.HasValue; 
        }

    }
}