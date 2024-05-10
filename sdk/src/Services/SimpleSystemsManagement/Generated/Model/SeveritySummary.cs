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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private int? _criticalCount;
        private int? _highCount;
        private int? _informationalCount;
        private int? _lowCount;
        private int? _mediumCount;
        private int? _unspecifiedCount;

        /// <summary>
        /// Gets and sets the property CriticalCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of <c>Critical</c>.
        /// Critical severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? CriticalCount
        {
            get { return this._criticalCount; }
            set { this._criticalCount = value; }
        }

        // Check to see if CriticalCount property is set
        internal bool IsSetCriticalCount()
        {
            return this._criticalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HighCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of high.
        /// High severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? HighCount
        {
            get { return this._highCount; }
            set { this._highCount = value; }
        }

        // Check to see if HighCount property is set
        internal bool IsSetHighCount()
        {
            return this._highCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InformationalCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of informational.
        /// Informational severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? InformationalCount
        {
            get { return this._informationalCount; }
            set { this._informationalCount = value; }
        }

        // Check to see if InformationalCount property is set
        internal bool IsSetInformationalCount()
        {
            return this._informationalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LowCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of low.
        /// Low severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? LowCount
        {
            get { return this._lowCount; }
            set { this._lowCount = value; }
        }

        // Check to see if LowCount property is set
        internal bool IsSetLowCount()
        {
            return this._lowCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediumCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of medium.
        /// Medium severity is determined by the organization that published the compliance items.
        /// </para>
        /// </summary>
        public int? MediumCount
        {
            get { return this._mediumCount; }
            set { this._mediumCount = value; }
        }

        // Check to see if MediumCount property is set
        internal bool IsSetMediumCount()
        {
            return this._mediumCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnspecifiedCount. 
        /// <para>
        /// The total number of resources or compliance items that have a severity level of unspecified.
        /// Unspecified severity is determined by the organization that published the compliance
        /// items.
        /// </para>
        /// </summary>
        public int? UnspecifiedCount
        {
            get { return this._unspecifiedCount; }
            set { this._unspecifiedCount = value; }
        }

        // Check to see if UnspecifiedCount property is set
        internal bool IsSetUnspecifiedCount()
        {
            return this._unspecifiedCount.HasValue; 
        }

    }
}