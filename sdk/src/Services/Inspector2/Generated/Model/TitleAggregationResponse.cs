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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains details on the results of a finding aggregation by title.
    /// </summary>
    public partial class TitleAggregationResponse
    {
        private string _accountId;
        private SeverityCounts _severityCounts;
        private string _title;
        private string _vulnerabilityId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account associated with the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that represent the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title that the findings were aggregated on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property VulnerabilityId. 
        /// <para>
        /// The vulnerability ID of the finding.
        /// </para>
        /// </summary>
        public string VulnerabilityId
        {
            get { return this._vulnerabilityId; }
            set { this._vulnerabilityId = value; }
        }

        // Check to see if VulnerabilityId property is set
        internal bool IsSetVulnerabilityId()
        {
            return this._vulnerabilityId != null;
        }

    }
}