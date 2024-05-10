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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The number of conformance packs that are compliant and noncompliant.
    /// </summary>
    public partial class AggregateConformancePackComplianceCount
    {
        private int? _compliantConformancePackCount;
        private int? _nonCompliantConformancePackCount;

        /// <summary>
        /// Gets and sets the property CompliantConformancePackCount. 
        /// <para>
        /// Number of compliant conformance packs.
        /// </para>
        /// </summary>
        public int? CompliantConformancePackCount
        {
            get { return this._compliantConformancePackCount; }
            set { this._compliantConformancePackCount = value; }
        }

        // Check to see if CompliantConformancePackCount property is set
        internal bool IsSetCompliantConformancePackCount()
        {
            return this._compliantConformancePackCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantConformancePackCount. 
        /// <para>
        /// Number of noncompliant conformance packs.
        /// </para>
        /// </summary>
        public int? NonCompliantConformancePackCount
        {
            get { return this._nonCompliantConformancePackCount; }
            set { this._nonCompliantConformancePackCount = value; }
        }

        // Check to see if NonCompliantConformancePackCount property is set
        internal bool IsSetNonCompliantConformancePackCount()
        {
            return this._nonCompliantConformancePackCount.HasValue; 
        }

    }
}