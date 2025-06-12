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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Rules for retrieving content from data sources connected to a Amazon Q Business application
    /// for a specific topic control configuration.
    /// </summary>
    public partial class ContentRetrievalRule
    {
        private List<EligibleDataSource> _eligibleDataSources = AWSConfigs.InitializeCollections ? new List<EligibleDataSource>() : null;

        /// <summary>
        /// Gets and sets the property EligibleDataSources. 
        /// <para>
        /// Specifies data sources in a Amazon Q Business application to use for content generation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<EligibleDataSource> EligibleDataSources
        {
            get { return this._eligibleDataSources; }
            set { this._eligibleDataSources = value; }
        }

        // Check to see if EligibleDataSources property is set
        internal bool IsSetEligibleDataSources()
        {
            return this._eligibleDataSources != null && (this._eligibleDataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}