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
    /// This is the response object from the GetService operation.
    /// </summary>
    public partial class GetServiceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the data included in the response. In a raw HTTP Query API, it is
        /// formatted as be epoch time in seconds. For example: <c>1698778057</c>.
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
        /// Gets and sets the property LogGroupReferences. 
        /// <para>
        /// An array of string-to-string maps that each contain information about one log group
        /// associated with this service. Each string-to-string map includes the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"Type": "AWS::Resource"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"ResourceType": "AWS::Logs::LogGroup"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Identifier": "<i>name-of-log-group</i>"</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> LogGroupReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the LogGroupReferences property is set.
        /// </summary>
        internal bool IsSetLogGroupReferences() => this.LogGroupReferences != null && (this.LogGroupReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// A structure containing information about the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Service Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the data included in the response. In a raw HTTP Query API, it is
        /// formatted as be epoch time in seconds. For example: <c>1698778057</c>.
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
