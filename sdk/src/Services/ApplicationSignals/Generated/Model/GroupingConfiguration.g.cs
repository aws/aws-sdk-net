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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains the complete grouping configuration for an account, including
    /// all defined grouping attributes and metadata about when it was last updated.
    /// </summary>
    public partial class GroupingConfiguration
    {
        /// <summary>
        /// Gets and sets the property GroupingAttributeDefinitions. 
        /// <para>
        /// An array of grouping attribute definitions that specify how services should be grouped
        /// based on various attributes and source keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<GroupingAttributeDefinition> GroupingAttributeDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupingAttributeDefinition>() : null;

        /// <summary>
        /// Checks to see if the GroupingAttributeDefinitions property is set.
        /// </summary>
        internal bool IsSetGroupingAttributeDefinitions() => this.GroupingAttributeDefinitions != null && (this.GroupingAttributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when this grouping configuration was last updated. When used in a raw
        /// HTTP Query API, it is formatted as epoch time in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
