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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The value of a time range filter.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class TimeRangeFilterValue
    {
        /// <summary>
        /// Gets and sets the property Parameter. 
        /// <para>
        /// The parameter type input value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Parameter { get; set; }

        /// <summary>
        /// Checks to see if the Parameter property is set.
        /// </summary>
        internal bool IsSetParameter() => this.Parameter != null;

        /// <summary>
        /// Gets and sets the property RollingDate. 
        /// <para>
        /// The rolling date input value.
        /// </para>
        /// </summary>
        public RollingDateConfiguration RollingDate { get; set; }

        /// <summary>
        /// Checks to see if the RollingDate property is set.
        /// </summary>
        internal bool IsSetRollingDate() => this.RollingDate != null;

        /// <summary>
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The static input value.
        /// </para>
        /// </summary>
        public DateTime? StaticValue { get; set; }

        /// <summary>
        /// Checks to see if the StaticValue property is set.
        /// </summary>
        internal bool IsSetStaticValue() => this.StaticValue.HasValue;
    }
}
