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
    /// Date and time (UTC) format in RFC 3339 : 'yyyy-MM-dd'T'HH:mm:ss.SSSZZ'.
    /// </summary>
    public partial class DateInterval
    {
        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        ///  End Date Time (UTC). RFC 3339 format : 'yyyy-MM-dd'T'HH:mm:ss.SSSZZ'. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 30)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime != null;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        ///  A JSON object containing start and date time (UTC). Date and time format is RFC 3339
        /// : 'yyyy-MM-dd'T'HH:mm:ss.SSSZZ'. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 30)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime != null;
    }
}
