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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a time-based filter.
    /// </summary>
    public partial class FilterTimestamp
    {
        /// <summary>
        /// Gets and sets the property AfterTimestamp. 
        /// <para>
        ///  Include results after this timestamp. 
        /// </para>
        /// </summary>
        public DateTime? AfterTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AfterTimestamp property is set.
        /// </summary>
        internal bool IsSetAfterTimestamp() => this.AfterTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property BeforeTimestamp. 
        /// <para>
        ///  Include results before this timestamp. 
        /// </para>
        /// </summary>
        public DateTime? BeforeTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the BeforeTimestamp property is set.
        /// </summary>
        internal bool IsSetBeforeTimestamp() => this.BeforeTimestamp.HasValue;
    }
}
