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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetRelationalDatabaseLogEvents operation.
    /// </summary>
    public partial class GetRelationalDatabaseLogEventsResponse : AmazonWebServiceResponse
    {
        private string _nextBackwardToken;
        private string _nextForwardToken;
        private List<LogEvent> _resourceLogEvents = AWSConfigs.InitializeCollections ? new List<LogEvent>() : null;

        /// <summary>
        /// Gets and sets the property NextBackwardToken. 
        /// <para>
        /// A token used for advancing to the previous page of results from your get relational
        /// database log events request.
        /// </para>
        /// </summary>
        public string NextBackwardToken
        {
            get { return this._nextBackwardToken; }
            set { this._nextBackwardToken = value; }
        }

        // Check to see if NextBackwardToken property is set
        internal bool IsSetNextBackwardToken()
        {
            return this._nextBackwardToken != null;
        }

        /// <summary>
        /// Gets and sets the property NextForwardToken. 
        /// <para>
        /// A token used for advancing to the next page of results from your get relational database
        /// log events request.
        /// </para>
        /// </summary>
        public string NextForwardToken
        {
            get { return this._nextForwardToken; }
            set { this._nextForwardToken = value; }
        }

        // Check to see if NextForwardToken property is set
        internal bool IsSetNextForwardToken()
        {
            return this._nextForwardToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLogEvents. 
        /// <para>
        /// An object describing the result of your get relational database log events request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogEvent> ResourceLogEvents
        {
            get { return this._resourceLogEvents; }
            set { this._resourceLogEvents = value; }
        }

        // Check to see if ResourceLogEvents property is set
        internal bool IsSetResourceLogEvents()
        {
            return this._resourceLogEvents != null && (this._resourceLogEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}