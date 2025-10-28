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
    /// Defines how services should be grouped based on specific attributes. This allows logical
    /// organization of services in dashboards and service maps.
    /// </summary>
    public partial class GroupingAttributeDefinition
    {
        private string _defaultGroupingValue;
        private string _groupingName;
        private List<string> _groupingSourceKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultGroupingValue. 
        /// <para>
        /// The default value to use for grouping when a service doesn't have any of the specified
        /// source keys, such as "Unknown" or "Unassigned".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DefaultGroupingValue
        {
            get { return this._defaultGroupingValue; }
            set { this._defaultGroupingValue = value; }
        }

        // Check to see if DefaultGroupingValue property is set
        internal bool IsSetDefaultGroupingValue()
        {
            return this._defaultGroupingValue != null;
        }

        /// <summary>
        /// Gets and sets the property GroupingName. 
        /// <para>
        /// The name of the grouping attribute, such as "Environment", "Team", or "Application".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupingName
        {
            get { return this._groupingName; }
            set { this._groupingName = value; }
        }

        // Check to see if GroupingName property is set
        internal bool IsSetGroupingName()
        {
            return this._groupingName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupingSourceKeys. 
        /// <para>
        /// An array of source attribute keys that will be used to determine the grouping value
        /// for each service. These keys correspond to service metadata or tags.
        /// </para>
        /// </summary>
        public List<string> GroupingSourceKeys
        {
            get { return this._groupingSourceKeys; }
            set { this._groupingSourceKeys = value; }
        }

        // Check to see if GroupingSourceKeys property is set
        internal bool IsSetGroupingSourceKeys()
        {
            return this._groupingSourceKeys != null && (this._groupingSourceKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}