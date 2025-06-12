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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A summary report for the attribute across all Regions.
    /// </summary>
    public partial class AttributeSummary
    {
        private string _attributeName;
        private string _mostFrequentValue;
        private int? _numberOfMatchedAccounts;
        private int? _numberOfUnmatchedAccounts;
        private List<RegionalSummary> _regionalSummaries = AWSConfigs.InitializeCollections ? new List<RegionalSummary>() : null;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        /// </summary>
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property MostFrequentValue. 
        /// <para>
        /// The configuration value that is most frequently observed for the attribute.
        /// </para>
        /// </summary>
        public string MostFrequentValue
        {
            get { return this._mostFrequentValue; }
            set { this._mostFrequentValue = value; }
        }

        // Check to see if MostFrequentValue property is set
        internal bool IsSetMostFrequentValue()
        {
            return this._mostFrequentValue != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfMatchedAccounts. 
        /// <para>
        /// The number of accounts with the same configuration value for the attribute that is
        /// most frequently observed.
        /// </para>
        /// </summary>
        public int? NumberOfMatchedAccounts
        {
            get { return this._numberOfMatchedAccounts; }
            set { this._numberOfMatchedAccounts = value; }
        }

        // Check to see if NumberOfMatchedAccounts property is set
        internal bool IsSetNumberOfMatchedAccounts()
        {
            return this._numberOfMatchedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfUnmatchedAccounts. 
        /// <para>
        /// The number of accounts with a configuration value different from the most frequently
        /// observed value for the attribute.
        /// </para>
        /// </summary>
        public int? NumberOfUnmatchedAccounts
        {
            get { return this._numberOfUnmatchedAccounts; }
            set { this._numberOfUnmatchedAccounts = value; }
        }

        // Check to see if NumberOfUnmatchedAccounts property is set
        internal bool IsSetNumberOfUnmatchedAccounts()
        {
            return this._numberOfUnmatchedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionalSummaries. 
        /// <para>
        /// The summary report for each Region for the attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionalSummary> RegionalSummaries
        {
            get { return this._regionalSummaries; }
            set { this._regionalSummaries = value; }
        }

        // Check to see if RegionalSummaries property is set
        internal bool IsSetRegionalSummaries()
        {
            return this._regionalSummaries != null && (this._regionalSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}