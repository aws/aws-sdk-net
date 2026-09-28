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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the aggregate statistics for an external or unused access
    /// analyzer. Only one parameter can be used in a <c>FindingsStatistics</c> object.
    /// </summary>
    public partial class FindingsStatistics
    {
        /// <summary>
        /// Gets and sets the property ExternalAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an external access analyzer.
        /// </para>
        /// </summary>
        public ExternalAccessFindingsStatistics ExternalAccessFindingsStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ExternalAccessFindingsStatistics property is set.
        /// </summary>
        internal bool IsSetExternalAccessFindingsStatistics() => this.ExternalAccessFindingsStatistics != null;

        /// <summary>
        /// Gets and sets the property InternalAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an internal access analyzer. This includes information
        /// about active, archived, and resolved findings related to internal access within your
        /// Amazon Web Services organization or account.
        /// </para>
        /// </summary>
        public InternalAccessFindingsStatistics InternalAccessFindingsStatistics { get; set; }

        /// <summary>
        /// Checks to see if the InternalAccessFindingsStatistics property is set.
        /// </summary>
        internal bool IsSetInternalAccessFindingsStatistics() => this.InternalAccessFindingsStatistics != null;

        /// <summary>
        /// Gets and sets the property UnusedAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an unused access analyzer.
        /// </para>
        /// </summary>
        public UnusedAccessFindingsStatistics UnusedAccessFindingsStatistics { get; set; }

        /// <summary>
        /// Checks to see if the UnusedAccessFindingsStatistics property is set.
        /// </summary>
        internal bool IsSetUnusedAccessFindingsStatistics() => this.UnusedAccessFindingsStatistics != null;
    }
}
