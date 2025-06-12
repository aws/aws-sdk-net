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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceOperations operation.
    /// Returns a list of the <i>operations</i> of this service that have been discovered
    /// by Application Signals. Only the operations that were invoked during the specified
    /// time range are returned.
    /// </summary>
    public partial class ListServiceOperationsRequest : AmazonApplicationSignalsRequest
    {
        private DateTime? _endTime;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period to retrieve information about. When used in a raw HTTP
        /// Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Your requested end time will be rounded to the nearest hour.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// Use this field to specify which service you want to retrieve information for. You
        /// must specify at least the <c>Type</c>, <c>Name</c>, and <c>Environment</c> attributes.
        /// </para>
        ///  
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. If you omit this parameter,
        /// the default of 50 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous operation, to get the next
        /// set of service operations.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period to retrieve information about. When used in a raw HTTP
        /// Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Your requested start time will be rounded to the nearest hour.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}