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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the ListServiceOperations operation.
    /// </summary>
    public partial class ListServiceOperationsResponse : AmazonWebServiceResponse
    {
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
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value in your next use of this API to get next set of service operations.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceOperations. 
        /// <para>
        /// An array of structures that each contain information about one operation of this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public List<ServiceOperation> ServiceOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceOperation>() : null;

        /// <summary>
        /// Checks to see if the ServiceOperations property is set.
        /// </summary>
        internal bool IsSetServiceOperations() => this.ServiceOperations != null && (this.ServiceOperations.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
