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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The configured table association analysis rule applied to a configured table with
    /// the custom analysis rule.
    /// </summary>
    public partial class ConfiguredTableAssociationAnalysisRuleCustom
    {
        private List<string> _allowedAdditionalAnalyses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedResultReceivers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedAdditionalAnalyses. 
        /// <para>
        ///  The list of resources or wildcards (ARNs) that are allowed to perform additional
        /// analysis on query output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> AllowedAdditionalAnalyses
        {
            get { return this._allowedAdditionalAnalyses; }
            set { this._allowedAdditionalAnalyses = value; }
        }

        // Check to see if AllowedAdditionalAnalyses property is set
        internal bool IsSetAllowedAdditionalAnalyses()
        {
            return this._allowedAdditionalAnalyses != null && (this._allowedAdditionalAnalyses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedResultReceivers. 
        /// <para>
        ///  The list of collaboration members who are allowed to receive results of queries run
        /// with this configured table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedResultReceivers
        {
            get { return this._allowedResultReceivers; }
            set { this._allowedResultReceivers = value; }
        }

        // Check to see if AllowedResultReceivers property is set
        internal bool IsSetAllowedResultReceivers()
        {
            return this._allowedResultReceivers != null && (this._allowedResultReceivers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}