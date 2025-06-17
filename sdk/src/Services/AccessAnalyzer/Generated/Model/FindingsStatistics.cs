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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
        private ExternalAccessFindingsStatistics _externalAccessFindingsStatistics;
        private InternalAccessFindingsStatistics _internalAccessFindingsStatistics;
        private UnusedAccessFindingsStatistics _unusedAccessFindingsStatistics;

        /// <summary>
        /// Gets and sets the property ExternalAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an external access analyzer.
        /// </para>
        /// </summary>
        public ExternalAccessFindingsStatistics ExternalAccessFindingsStatistics
        {
            get { return this._externalAccessFindingsStatistics; }
            set { this._externalAccessFindingsStatistics = value; }
        }

        // Check to see if ExternalAccessFindingsStatistics property is set
        internal bool IsSetExternalAccessFindingsStatistics()
        {
            return this._externalAccessFindingsStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property InternalAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an internal access analyzer. This includes information
        /// about active, archived, and resolved findings related to internal access within your
        /// Amazon Web Services organization or account.
        /// </para>
        /// </summary>
        public InternalAccessFindingsStatistics InternalAccessFindingsStatistics
        {
            get { return this._internalAccessFindingsStatistics; }
            set { this._internalAccessFindingsStatistics = value; }
        }

        // Check to see if InternalAccessFindingsStatistics property is set
        internal bool IsSetInternalAccessFindingsStatistics()
        {
            return this._internalAccessFindingsStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedAccessFindingsStatistics. 
        /// <para>
        /// The aggregate statistics for an unused access analyzer.
        /// </para>
        /// </summary>
        public UnusedAccessFindingsStatistics UnusedAccessFindingsStatistics
        {
            get { return this._unusedAccessFindingsStatistics; }
            set { this._unusedAccessFindingsStatistics = value; }
        }

        // Check to see if UnusedAccessFindingsStatistics property is set
        internal bool IsSetUnusedAccessFindingsStatistics()
        {
            return this._unusedAccessFindingsStatistics != null;
        }

    }
}