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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the StartRecommendationReportGeneration operation.
    /// Starts generating a recommendation report.
    /// </summary>
    public partial class StartRecommendationReportGenerationRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        private List<Group> _groupIdFilter = AWSConfigs.InitializeCollections ? new List<Group>() : null;
        private OutputFormat _outputFormat;

        /// <summary>
        /// Gets and sets the property GroupIdFilter. 
        /// <para>
        ///  Groups the resources in the recommendation report with a unique name. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Group> GroupIdFilter
        {
            get { return this._groupIdFilter; }
            set { this._groupIdFilter = value; }
        }

        // Check to see if GroupIdFilter property is set
        internal bool IsSetGroupIdFilter()
        {
            return this._groupIdFilter != null && (this._groupIdFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        ///  The output format for the recommendation report file. The default format is Microsoft
        /// Excel. 
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

    }
}