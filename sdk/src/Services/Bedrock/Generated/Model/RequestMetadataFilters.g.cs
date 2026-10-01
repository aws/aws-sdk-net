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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Rules for filtering invocation logs. A filter can be a mapping of a metadata key to
    /// a value that it should or should not equal (a base filter), or a list of base filters
    /// that are all applied with <c>AND</c> or <c>OR</c> logical operators
    /// </summary>
    public partial class RequestMetadataFilters
    {
        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Include results where all of the based filters match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<RequestMetadataBaseFilters> AndAll { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestMetadataBaseFilters>() : null;

        /// <summary>
        /// Checks to see if the AndAll property is set.
        /// </summary>
        internal bool IsSetAndAll() => this.AndAll != null && (this.AndAll.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Include results where the key equals the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1)]
        public new Dictionary<string, string> Equals { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Equals property is set.
        /// </summary>
        internal bool IsSetEquals() => this.Equals != null && (this.Equals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Include results where the key does not equal the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1)]
        public Dictionary<string, string> NotEquals { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the NotEquals property is set.
        /// </summary>
        internal bool IsSetNotEquals() => this.NotEquals != null && (this.NotEquals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Include results where any of the base filters match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<RequestMetadataBaseFilters> OrAll { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestMetadataBaseFilters>() : null;

        /// <summary>
        /// Checks to see if the OrAll property is set.
        /// </summary>
        internal bool IsSetOrAll() => this.OrAll != null && (this.OrAll.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
