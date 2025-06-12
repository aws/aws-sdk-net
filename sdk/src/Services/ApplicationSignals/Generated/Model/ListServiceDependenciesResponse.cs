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
    /// This is the response object from the ListServiceDependencies operation.
    /// </summary>
    public partial class ListServiceDependenciesResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private string _nextToken;
        private List<ServiceDependency> _serviceDependencies = AWSConfigs.InitializeCollections ? new List<ServiceDependency>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period that the returned information applies to. When used in
        /// a raw HTTP Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// This displays the time that Application Signals used for the request. It might not
        /// match your request exactly, because it was rounded to the nearest hour.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value in your next use of this API to get next set of service dependencies.
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
        /// Gets and sets the property ServiceDependencies. 
        /// <para>
        /// An array, where each object in the array contains information about one of the dependencies
        /// of this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ServiceDependency> ServiceDependencies
        {
            get { return this._serviceDependencies; }
            set { this._serviceDependencies = value; }
        }

        // Check to see if ServiceDependencies property is set
        internal bool IsSetServiceDependencies()
        {
            return this._serviceDependencies != null && (this._serviceDependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period that the returned information applies to. When used in
        /// a raw HTTP Query API, it is formatted as be epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// This displays the time that Application Signals used for the request. It might not
        /// match your request exactly, because it was rounded to the nearest hour.
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