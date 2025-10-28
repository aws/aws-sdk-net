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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
    /// Contains the complete configuration for how services are grouped and organized in
    /// Application Signals.
    /// </summary>
    public partial class GroupingConfiguration
    {
        private List<GroupingAttributeDefinition> _groupingAttributeDefinitions = AWSConfigs.InitializeCollections ? new List<GroupingAttributeDefinition>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property GroupingAttributeDefinitions. 
        /// <para>
        /// An array of grouping attribute definitions that specify the rules for organizing services
        /// into groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GroupingAttributeDefinition> GroupingAttributeDefinitions
        {
            get { return this._groupingAttributeDefinitions; }
            set { this._groupingAttributeDefinitions = value; }
        }

        // Check to see if GroupingAttributeDefinitions property is set
        internal bool IsSetGroupingAttributeDefinitions()
        {
            return this._groupingAttributeDefinitions != null && (this._groupingAttributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the grouping configuration was last updated, expressed as the number
        /// of milliseconds since January 1, 1970, 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}