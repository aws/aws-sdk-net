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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Endpoint settings.
    /// </summary>
    public partial class EndpointSetting
    {
        /// <summary>
        /// Gets and sets the property Applicability. 
        /// <para>
        /// The relevance or validity of an endpoint setting for an engine name and its endpoint
        /// type.
        /// </para>
        /// </summary>
        public string Applicability { get; set; }

        /// <summary>
        /// Checks to see if the Applicability property is set.
        /// </summary>
        internal bool IsSetApplicability() => this.Applicability != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the endpoint setting if no value is specified using <c>CreateEndpoint</c>
        /// or <c>ModifyEndpoint</c>.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property EnumValues. 
        /// <para>
        /// Enumerated values to use for this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnumValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnumValues property is set.
        /// </summary>
        internal bool IsSetEnumValues() => this.EnumValues != null && (this.EnumValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntValueMax. 
        /// <para>
        /// The maximum value of an endpoint setting that is of type <c>int</c>.
        /// </para>
        /// </summary>
        public int? IntValueMax { get; set; }

        /// <summary>
        /// Checks to see if the IntValueMax property is set.
        /// </summary>
        internal bool IsSetIntValueMax() => this.IntValueMax.HasValue;

        /// <summary>
        /// Gets and sets the property IntValueMin. 
        /// <para>
        /// The minimum value of an endpoint setting that is of type <c>int</c>.
        /// </para>
        /// </summary>
        public int? IntValueMin { get; set; }

        /// <summary>
        /// Checks to see if the IntValueMin property is set.
        /// </summary>
        internal bool IsSetIntValueMin() => this.IntValueMin.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to give the endpoint settings.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// A value that marks this endpoint setting as sensitive.
        /// </para>
        /// </summary>
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Checks to see if the Sensitive property is set.
        /// </summary>
        internal bool IsSetSensitive() => this.Sensitive.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of endpoint. Valid values are <c>source</c> and <c>target</c>.
        /// </para>
        /// </summary>
        public EndpointSettingTypeValue Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// The unit of measure for this endpoint setting.
        /// </para>
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Checks to see if the Units property is set.
        /// </summary>
        internal bool IsSetUnits() => this.Units != null;
    }
}
