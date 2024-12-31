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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
        private DateTime? _afterTimestamp;
        private DateTime? _beforeTimestamp;

        /// <summary>
        /// Gets and sets the property AfterTimestamp. 
        /// <para>
        ///  Include results after this timestamp. 
        /// </para>
        /// </summary>
        public DateTime? AfterTimestamp
        {
            get { return this._afterTimestamp; }
            set { this._afterTimestamp = value; }
        }

        // Check to see if AfterTimestamp property is set
        internal bool IsSetAfterTimestamp()
        {
            return this._afterTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeTimestamp. 
        /// <para>
        ///  Include results before this timestamp. 
        /// </para>
        /// </summary>
        public DateTime? BeforeTimestamp
        {
            get { return this._beforeTimestamp; }
            set { this._beforeTimestamp = value; }
        }

        // Check to see if BeforeTimestamp property is set
        internal bool IsSetBeforeTimestamp()
        {
            return this._beforeTimestamp.HasValue; 
        }

    }
}