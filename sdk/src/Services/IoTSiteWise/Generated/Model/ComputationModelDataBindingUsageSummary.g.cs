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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A summary of how a specific data binding is used across computation models. This tracks
    /// dependencies between data sources and computation models, allowing you to understand
    /// the impact of changes to data sources.
    /// </summary>
    public partial class ComputationModelDataBindingUsageSummary
    {
        /// <summary>
        /// Gets and sets the property ComputationModelIds. 
        /// <para>
        /// The list of computation model IDs that use this data binding. This allows identification
        /// of all computation models affected by changes to the referenced data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ComputationModelIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ComputationModelIds property is set.
        /// </summary>
        internal bool IsSetComputationModelIds() => this.ComputationModelIds != null && (this.ComputationModelIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchedDataBinding. 
        /// <para>
        /// The data binding matched by the filter criteria. Contains details about specific data
        /// binding values used by the computation models.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MatchedDataBinding MatchedDataBinding { get; set; }

        /// <summary>
        /// Checks to see if the MatchedDataBinding property is set.
        /// </summary>
        internal bool IsSetMatchedDataBinding() => this.MatchedDataBinding != null;
    }
}
