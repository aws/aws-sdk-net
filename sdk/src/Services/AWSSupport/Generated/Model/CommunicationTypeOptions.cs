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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// <code>chat</code>, <code>web</code> and <code>call</code>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CommunicationTypeOptions
    {
        private List<DateInterval> _datesWithoutSupport = new List<DateInterval>();
        private List<SupportedHour> _supportedHours = new List<SupportedHour>();
        private string _type;

        /// <summary>
        /// Gets and sets the property DatesWithoutSupport. 
        /// <para>
        ///  A JSON-formatted list containing date and time ranges for periods without support
        /// 
        /// </para>
        /// </summary>
        public List<DateInterval> DatesWithoutSupport
        {
            get { return this._datesWithoutSupport; }
            set { this._datesWithoutSupport = value; }
        }

        // Check to see if DatesWithoutSupport property is set
        internal bool IsSetDatesWithoutSupport()
        {
            return this._datesWithoutSupport != null && this._datesWithoutSupport.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedHours. 
        /// <para>
        ///  A JSON-formatted list containing time ranges when support is available. 
        /// </para>
        /// </summary>
        public List<SupportedHour> SupportedHours
        {
            get { return this._supportedHours; }
            set { this._supportedHours = value; }
        }

        // Check to see if SupportedHours property is set
        internal bool IsSetSupportedHours()
        {
            return this._supportedHours != null && this._supportedHours.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  A string value indicating the communication type. At the moment the type value can
        /// assume one of 3 values at the moment chat, web and call. 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}