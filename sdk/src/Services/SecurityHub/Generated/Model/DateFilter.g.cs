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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A date filter for querying findings.
    /// </summary>
    public partial class DateFilter
    {
        /// <summary>
        /// Gets and sets the property DateRange. 
        /// <para>
        /// A date range for the date filter.
        /// </para>
        /// </summary>
        public DateRange DateRange { get; set; }

        /// <summary>
        /// Checks to see if the DateRange property is set.
        /// </summary>
        internal bool IsSetDateRange() => this.DateRange != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// A timestamp that provides the end date for the date filter.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// A timestamp that provides the start date for the date filter.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;
    }
}
