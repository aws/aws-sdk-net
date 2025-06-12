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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private string _applicability;
        private string _defaultValue;
        private List<string> _enumValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _intValueMax;
        private int? _intValueMin;
        private string _name;
        private bool? _sensitive;
        private EndpointSettingTypeValue _type;
        private string _units;

        /// <summary>
        /// Gets and sets the property Applicability. 
        /// <para>
        /// The relevance or validity of an endpoint setting for an engine name and its endpoint
        /// type.
        /// </para>
        /// </summary>
        public string Applicability
        {
            get { return this._applicability; }
            set { this._applicability = value; }
        }

        // Check to see if Applicability property is set
        internal bool IsSetApplicability()
        {
            return this._applicability != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the endpoint setting if no value is specified using <c>CreateEndpoint</c>
        /// or <c>ModifyEndpoint</c>.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property EnumValues. 
        /// <para>
        /// Enumerated values to use for this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnumValues
        {
            get { return this._enumValues; }
            set { this._enumValues = value; }
        }

        // Check to see if EnumValues property is set
        internal bool IsSetEnumValues()
        {
            return this._enumValues != null && (this._enumValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntValueMax. 
        /// <para>
        /// The maximum value of an endpoint setting that is of type <c>int</c>.
        /// </para>
        /// </summary>
        public int? IntValueMax
        {
            get { return this._intValueMax; }
            set { this._intValueMax = value; }
        }

        // Check to see if IntValueMax property is set
        internal bool IsSetIntValueMax()
        {
            return this._intValueMax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntValueMin. 
        /// <para>
        /// The minimum value of an endpoint setting that is of type <c>int</c>.
        /// </para>
        /// </summary>
        public int? IntValueMin
        {
            get { return this._intValueMin; }
            set { this._intValueMin = value; }
        }

        // Check to see if IntValueMin property is set
        internal bool IsSetIntValueMin()
        {
            return this._intValueMin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to give the endpoint settings.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// A value that marks this endpoint setting as sensitive.
        /// </para>
        /// </summary>
        public bool? Sensitive
        {
            get { return this._sensitive; }
            set { this._sensitive = value; }
        }

        // Check to see if Sensitive property is set
        internal bool IsSetSensitive()
        {
            return this._sensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of endpoint. Valid values are <c>source</c> and <c>target</c>.
        /// </para>
        /// </summary>
        public EndpointSettingTypeValue Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// The unit of measure for this endpoint setting.
        /// </para>
        /// </summary>
        public string Units
        {
            get { return this._units; }
            set { this._units = value; }
        }

        // Check to see if Units property is set
        internal bool IsSetUnits()
        {
            return this._units != null;
        }

    }
}