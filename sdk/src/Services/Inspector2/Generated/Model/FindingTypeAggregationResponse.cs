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
    /// A response that contains the results of a finding type aggregation.
    /// </summary>
    public partial class FindingTypeAggregationResponse
    {
        private string _accountId;
        private long? _exploitAvailableCount;
        private long? _fixAvailableCount;
        private SeverityCounts _severityCounts;

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
        /// Gets and sets the property ExploitAvailableCount. 
        /// <para>
        /// The number of findings that have an exploit available.
        /// </para>
        /// </summary>
        public long? ExploitAvailableCount
        {
            get { return this._exploitAvailableCount; }
            set { this._exploitAvailableCount = value; }
        }

        // Check to see if ExploitAvailableCount property is set
        internal bool IsSetExploitAvailableCount()
        {
            return this._exploitAvailableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixAvailableCount. 
        /// <para>
        ///  Details about the number of fixes. 
        /// </para>
        /// </summary>
        public long? FixAvailableCount
        {
            get { return this._fixAvailableCount; }
            set { this._fixAvailableCount = value; }
        }

        // Check to see if FixAvailableCount property is set
        internal bool IsSetFixAvailableCount()
        {
            return this._fixAvailableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// The value to sort results by.
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

    }
}