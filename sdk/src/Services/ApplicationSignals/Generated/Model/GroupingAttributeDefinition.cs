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
    /// A structure that defines how services should be grouped based on specific attributes.
    /// This includes the friendly name for the grouping, the source keys to derive values
    /// from, and an optional default value.
    /// </summary>
    public partial class GroupingAttributeDefinition
    {
        private string _defaultGroupingValue;
        private string _groupingName;
        private List<string> _groupingSourceKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultGroupingValue. 
        /// <para>
        /// The default value to use for this grouping attribute when no value can be derived
        /// from the source keys. This ensures all services have a grouping value even if the
        /// source data is missing.
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
        /// The friendly name for this grouping attribute, such as <c>BusinessUnit</c> or <c>Environment</c>.
        /// This name is used to identify the grouping in the console and APIs.
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
        /// An array of source keys used to derive the grouping attribute value from telemetry
        /// data, Amazon Web Services tags, or other sources. For example, ["business_unit", "team"]
        /// would look for values in those fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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