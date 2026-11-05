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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The number of managed nodes found for each patch severity level defined in the request
    /// filter.
    /// </summary>
    public partial class SeveritySummary
    {
        /// <summary>
        /// Gets and sets the property CriticalCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of <c>Critical</c>.
        /// Critical severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? CriticalCount { get; set; }

        /// <summary>
        /// Checks to see if the CriticalCount property is set.
        /// </summary>
        internal bool IsSetCriticalCount() => this.CriticalCount.HasValue;

        /// <summary>
        /// Gets and sets the property HighCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of high.
        /// High severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? HighCount { get; set; }

        /// <summary>
        /// Checks to see if the HighCount property is set.
        /// </summary>
        internal bool IsSetHighCount() => this.HighCount.HasValue;

        /// <summary>
        /// Gets and sets the property InformationalCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of informational.
        /// Informational severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? InformationalCount { get; set; }

        /// <summary>
        /// Checks to see if the InformationalCount property is set.
        /// </summary>
        internal bool IsSetInformationalCount() => this.InformationalCount.HasValue;

        /// <summary>
        /// Gets and sets the property LowCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of low.
        /// Low severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? LowCount { get; set; }

        /// <summary>
        /// Checks to see if the LowCount property is set.
        /// </summary>
        internal bool IsSetLowCount() => this.LowCount.HasValue;

        /// <summary>
        /// Gets and sets the property MediumCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of medium.
        /// Medium severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? MediumCount { get; set; }

        /// <summary>
        /// Checks to see if the MediumCount property is set.
        /// </summary>
        internal bool IsSetMediumCount() => this.MediumCount.HasValue;

        /// <summary>
        /// Gets and sets the property UnspecifiedCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of unspecified.
        /// Unspecified severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? UnspecifiedCount { get; set; }

        /// <summary>
        /// Checks to see if the UnspecifiedCount property is set.
        /// </summary>
        internal bool IsSetUnspecifiedCount() => this.UnspecifiedCount.HasValue;
    }
}
