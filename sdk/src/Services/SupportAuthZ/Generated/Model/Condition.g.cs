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

namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// A time-window condition that constrains when a support permit is valid.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property AllowAfter. 
        /// <para>
        /// The earliest time at which the permit becomes valid.
        /// </para>
        /// </summary>
        public DateTime? AllowAfter { get; set; }

        /// <summary>
        /// Checks to see if the AllowAfter property is set.
        /// </summary>
        internal bool IsSetAllowAfter() => this.AllowAfter.HasValue;

        /// <summary>
        /// Gets and sets the property AllowBefore. 
        /// <para>
        /// The latest time at which the permit remains valid.
        /// </para>
        /// </summary>
        public DateTime? AllowBefore { get; set; }

        /// <summary>
        /// Checks to see if the AllowBefore property is set.
        /// </summary>
        internal bool IsSetAllowBefore() => this.AllowBefore.HasValue;
    }
}
