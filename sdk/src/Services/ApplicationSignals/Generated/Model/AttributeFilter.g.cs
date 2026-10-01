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
    /// A structure that defines a filter for narrowing down results based on specific attribute
    /// values. This can be used to filter services by platform, environment, or other service
    /// characteristics.
    /// </summary>
    public partial class AttributeFilter
    {
        /// <summary>
        /// Gets and sets the property AttributeFilterName. 
        /// <para>
        /// The name of the attribute to filter by, such as <c>Platform</c>, <c>Environment</c>,
        /// or <c>BusinessUnit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AttributeFilterName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeFilterName property is set.
        /// </summary>
        internal bool IsSetAttributeFilterName() => this.AttributeFilterName != null;

        /// <summary>
        /// Gets and sets the property AttributeFilterValues. 
        /// <para>
        /// An array of values to match for the specified attribute. Services that have any of
        /// these values for the attribute will be included in the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public List<string> AttributeFilterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeFilterValues property is set.
        /// </summary>
        internal bool IsSetAttributeFilterValues() => this.AttributeFilterValues != null && (this.AttributeFilterValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
