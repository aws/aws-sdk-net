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
    /// A summary of resources that aren't compliant. The summary is organized according to
    /// resource type.
    /// </summary>
    public partial class NonCompliantSummary
    {
        private int? _nonCompliantCount;
        private SeveritySummary _severitySummary;

        /// <summary>
        /// Gets and sets the property NonCompliantCount. 
        /// <para>
        /// The total number of compliance items that aren't compliant.
        /// </para>
        /// </summary>
        public int? NonCompliantCount
        {
            get { return this._nonCompliantCount; }
            set { this._nonCompliantCount = value; }
        }

        // Check to see if NonCompliantCount property is set
        internal bool IsSetNonCompliantCount()
        {
            return this._nonCompliantCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeveritySummary. 
        /// <para>
        /// A summary of the non-compliance severity by compliance type
        /// </para>
        /// </summary>
        public SeveritySummary SeveritySummary
        {
            get { return this._severitySummary; }
            set { this._severitySummary = value; }
        }

        // Check to see if SeveritySummary property is set
        internal bool IsSetSeveritySummary()
        {
            return this._severitySummary != null;
        }

    }
}