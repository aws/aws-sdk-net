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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// A JSON-formatted object that contains the CommunicationTypeOptions for creating a
    /// case for a certain communication channel. It is contained in the response from a <a>DescribeCreateCaseOptions</a>
    /// request. <b>CommunicationTypeOptions</b> contains the following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>datesWithoutSupport</b> - A JSON-formatted list containing date and time ranges
    /// for periods without support in UTC time. Date and time format is RFC 3339 : 'yyyy-MM-dd'T'HH:mm:ss.SSSZZ'.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>supportedHours</b> - A JSON-formatted list containing time ranges when support
    /// are available. Time format is RFC 3339 : 'HH:mm:ss.SSS'. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>type</b> - A string value indicating the communication type that the aforementioned
    /// rules apply to. At the moment the type value can assume one of 3 values at the moment
    /// <c>chat</c>, <c>web</c> and <c>call</c>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CommunicationTypeOptions
    {
        /// <summary>
        /// Gets and sets the property DatesWithoutSupport. 
        /// <para>
        ///  A JSON-formatted list containing date and time ranges for periods without support
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateInterval> DatesWithoutSupport { get; set; } = AWSConfigs.InitializeCollections ? new List<DateInterval>() : null;

        /// <summary>
        /// Checks to see if the DatesWithoutSupport property is set.
        /// </summary>
        internal bool IsSetDatesWithoutSupport() => this.DatesWithoutSupport != null && (this.DatesWithoutSupport.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedHours. 
        /// <para>
        ///  A JSON-formatted list containing time ranges when support is available. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SupportedHour> SupportedHours { get; set; } = AWSConfigs.InitializeCollections ? new List<SupportedHour>() : null;

        /// <summary>
        /// Checks to see if the SupportedHours property is set.
        /// </summary>
        internal bool IsSetSupportedHours() => this.SupportedHours != null && (this.SupportedHours.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  A string value indicating the communication type. At the moment the type value can
        /// assume one of 3 values at the moment chat, web and call. 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
