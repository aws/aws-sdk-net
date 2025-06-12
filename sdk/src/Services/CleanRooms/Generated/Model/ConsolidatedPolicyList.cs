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
    /// Controls on the analysis specifications that can be run on a configured table.
    /// </summary>
    public partial class ConsolidatedPolicyList
    {
        private AdditionalAnalyses _additionalAnalyses;
        private List<string> _allowedAdditionalAnalyses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedJoinOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedResultReceivers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _joinColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _listColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        ///  Additional analyses for the consolidated policy list.
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses
        {
            get { return this._additionalAnalyses; }
            set { this._additionalAnalyses = value; }
        }

        // Check to see if AdditionalAnalyses property is set
        internal bool IsSetAdditionalAnalyses()
        {
            return this._additionalAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedAdditionalAnalyses. 
        /// <para>
        ///  The additional analyses allowed by the consolidated policy list.
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
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        ///  The allowed join operators in the consolidated policy list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> AllowedJoinOperators
        {
            get { return this._allowedJoinOperators; }
            set { this._allowedJoinOperators = value; }
        }

        // Check to see if AllowedJoinOperators property is set
        internal bool IsSetAllowedJoinOperators()
        {
            return this._allowedJoinOperators != null && (this._allowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedResultReceivers. 
        /// <para>
        ///  The allowed result receivers.
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

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        ///  The columns to join on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> JoinColumns
        {
            get { return this._joinColumns; }
            set { this._joinColumns = value; }
        }

        // Check to see if JoinColumns property is set
        internal bool IsSetJoinColumns()
        {
            return this._joinColumns != null && (this._joinColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListColumns. 
        /// <para>
        ///  The columns in the consolidated policy list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ListColumns
        {
            get { return this._listColumns; }
            set { this._listColumns = value; }
        }

        // Check to see if ListColumns property is set
        internal bool IsSetListColumns()
        {
            return this._listColumns != null && (this._listColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}