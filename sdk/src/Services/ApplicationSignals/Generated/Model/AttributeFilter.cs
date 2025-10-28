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
    /// Represents a filter for service attributes. Used to narrow down results based on specific
    /// attribute names and values.
    /// </summary>
    public partial class AttributeFilter
    {
        private string _attributeFilterName;
        private List<string> _attributeFilterValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeFilterName. 
        /// <para>
        /// The name of the attribute to filter on. This corresponds to service metadata attributes
        /// such as environment, team, or custom tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttributeFilterName
        {
            get { return this._attributeFilterName; }
            set { this._attributeFilterName = value; }
        }

        // Check to see if AttributeFilterName property is set
        internal bool IsSetAttributeFilterName()
        {
            return this._attributeFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeFilterValues. 
        /// <para>
        /// An array of values to match against the specified attribute. Services with attribute
        /// values matching any of these values will be included in the results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<string> AttributeFilterValues
        {
            get { return this._attributeFilterValues; }
            set { this._attributeFilterValues = value; }
        }

        // Check to see if AttributeFilterValues property is set
        internal bool IsSetAttributeFilterValues()
        {
            return this._attributeFilterValues != null && (this._attributeFilterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}