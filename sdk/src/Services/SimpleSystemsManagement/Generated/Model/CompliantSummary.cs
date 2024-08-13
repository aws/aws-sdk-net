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
    /// A summary of resources that are compliant. The summary is organized according to the
    /// resource count for each compliance type.
    /// </summary>
    public partial class CompliantSummary
    {
        private int? _compliantCount;
        private SeveritySummary _severitySummary;

        /// <summary>
        /// Gets and sets the property CompliantCount. 
        /// <para>
        /// The total number of resources that are compliant.
        /// </para>
        /// </summary>
        public int? CompliantCount
        {
            get { return this._compliantCount; }
            set { this._compliantCount = value; }
        }

        // Check to see if CompliantCount property is set
        internal bool IsSetCompliantCount()
        {
            return this._compliantCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeveritySummary. 
        /// <para>
        /// A summary of the compliance severity by compliance type.
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