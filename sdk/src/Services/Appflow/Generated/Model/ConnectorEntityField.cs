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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the data model of a connector field. For example, for an <i>account</i>
    /// entity, the fields would be <i>account name</i>, <i>account ID</i>, and so on.
    /// </summary>
    public partial class ConnectorEntityField
    {
        private Dictionary<string, string> _customProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _defaultValue;
        private string _description;
        private DestinationFieldProperties _destinationProperties;
        private string _identifier;
        private bool? _isDeprecated;
        private bool? _isPrimaryKey;
        private string _label;
        private string _parentIdentifier;
        private SourceFieldProperties _sourceProperties;
        private SupportedFieldTypeDetails _supportedFieldTypeDetails;

        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// A map that has specific properties related to the ConnectorEntityField.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }

        // Check to see if CustomProperties property is set
        internal bool IsSetCustomProperties()
        {
            return this._customProperties != null && (this._customProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// Default value that can be assigned to this field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        ///  The properties applied to a field when the connector is being used as a destination.
        /// 
        /// </para>
        /// </summary>
        public DestinationFieldProperties DestinationProperties
        {
            get { return this._destinationProperties; }
            set { this._destinationProperties = value; }
        }

        // Check to see if DestinationProperties property is set
        internal bool IsSetDestinationProperties()
        {
            return this._destinationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  The unique identifier of the connector field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property IsDeprecated. 
        /// <para>
        /// Booelan value that indicates whether this field is deprecated or not.
        /// </para>
        /// </summary>
        public bool? IsDeprecated
        {
            get { return this._isDeprecated; }
            set { this._isDeprecated = value; }
        }

        // Check to see if IsDeprecated property is set
        internal bool IsSetIsDeprecated()
        {
            return this._isDeprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPrimaryKey. 
        /// <para>
        /// Booelan value that indicates whether this field can be used as a primary key.
        /// </para>
        /// </summary>
        public bool? IsPrimaryKey
        {
            get { return this._isPrimaryKey; }
            set { this._isPrimaryKey = value; }
        }

        // Check to see if IsPrimaryKey property is set
        internal bool IsSetIsPrimaryKey()
        {
            return this._isPrimaryKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  The label applied to a connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property ParentIdentifier. 
        /// <para>
        /// The parent identifier of the connector field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ParentIdentifier
        {
            get { return this._parentIdentifier; }
            set { this._parentIdentifier = value; }
        }

        // Check to see if ParentIdentifier property is set
        internal bool IsSetParentIdentifier()
        {
            return this._parentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        ///  The properties that can be applied to a field when the connector is being used as
        /// a source. 
        /// </para>
        /// </summary>
        public SourceFieldProperties SourceProperties
        {
            get { return this._sourceProperties; }
            set { this._sourceProperties = value; }
        }

        // Check to see if SourceProperties property is set
        internal bool IsSetSourceProperties()
        {
            return this._sourceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedFieldTypeDetails. 
        /// <para>
        ///  Contains details regarding the supported <c>FieldType</c>, including the corresponding
        /// <c>filterOperators</c> and <c>supportedValues</c>. 
        /// </para>
        /// </summary>
        public SupportedFieldTypeDetails SupportedFieldTypeDetails
        {
            get { return this._supportedFieldTypeDetails; }
            set { this._supportedFieldTypeDetails = value; }
        }

        // Check to see if SupportedFieldTypeDetails property is set
        internal bool IsSetSupportedFieldTypeDetails()
        {
            return this._supportedFieldTypeDetails != null;
        }

    }
}