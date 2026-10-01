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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// A map of key value pairs that is generated when you create a migration workflow. The
    /// key value pairs will differ based on your selection of the template.
    /// </summary>
    public partial class StepInput
    {
        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        /// The value of the integer.
        /// </para>
        /// </summary>
        public int? IntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the IntegerValue property is set.
        /// </summary>
        internal bool IsSetIntegerValue() => this.IntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property ListOfStringsValue. 
        /// <para>
        /// List of string values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListOfStringsValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ListOfStringsValue property is set.
        /// </summary>
        internal bool IsSetListOfStringsValue() => this.ListOfStringsValue != null && (this.ListOfStringsValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapOfStringValue. 
        /// <para>
        /// Map of string values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapOfStringValue { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MapOfStringValue property is set.
        /// </summary>
        internal bool IsSetMapOfStringValue() => this.MapOfStringValue != null && (this.MapOfStringValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// String value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
