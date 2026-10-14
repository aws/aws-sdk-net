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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes a time range, in ISO8601-UTC format.
    /// </summary>
    public partial class DatetimeRange
    {
        /// <summary>
        /// Gets and sets the property Begin. 
        /// <para>
        /// Start of the time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string Begin { get; set; }

        /// <summary>
        /// Checks to see if the Begin property is set.
        /// </summary>
        internal bool IsSetBegin() => this.Begin != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// End of the time range.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;
    }
}
