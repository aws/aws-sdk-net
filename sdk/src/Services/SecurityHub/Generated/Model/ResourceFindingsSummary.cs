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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// A list of summaries for all finding types on a resource.
    /// </summary>
    public partial class ResourceFindingsSummary
    {
        private string _findingType;
        private string _productName;
        private ResourceSeverityBreakdown _severities;
        private int? _totalFindings;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The category or classification of the security finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product associated with the security finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        /// A breakdown of security findings by their severity levels.
        /// </para>
        /// </summary>
        public ResourceSeverityBreakdown Severities
        {
            get { return this._severities; }
            set { this._severities = value; }
        }

        // Check to see if Severities property is set
        internal bool IsSetSeverities()
        {
            return this._severities != null;
        }

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total count of security findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalFindings
        {
            get { return this._totalFindings; }
            set { this._totalFindings = value; }
        }

        // Check to see if TotalFindings property is set
        internal bool IsSetTotalFindings()
        {
            return this._totalFindings.HasValue; 
        }

    }
}