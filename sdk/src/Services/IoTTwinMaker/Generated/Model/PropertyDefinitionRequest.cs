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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that sets information about a property.
    /// </summary>
    public partial class PropertyDefinitionRequest
    {
        private Dictionary<string, string> _configuration = new Dictionary<string, string>();
        private DataType _dataType;
        private DataValue _defaultValue;
        private string _displayName;
        private bool? _isExternalId;
        private bool? _isRequiredInEntity;
        private bool? _isStoredExternally;
        private bool? _isTimeSeries;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A mapping that specifies configuration information about the property. Use this field
        /// to specify information that you read from and write to an external source.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && this._configuration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// An object that contains information about the data type.
        /// </para>
        /// </summary>
        public DataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// An object that contains the default value.
        /// </para>
        /// </summary>
        public DataValue DefaultValue
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A friendly name for the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IsExternalId. 
        /// <para>
        /// A Boolean value that specifies whether the property ID comes from an external data
        /// store.
        /// </para>
        /// </summary>
        public bool IsExternalId
        {
            get { return this._isExternalId.GetValueOrDefault(); }
            set { this._isExternalId = value; }
        }

        // Check to see if IsExternalId property is set
        internal bool IsSetIsExternalId()
        {
            return this._isExternalId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRequiredInEntity. 
        /// <para>
        /// A Boolean value that specifies whether the property is required.
        /// </para>
        /// </summary>
        public bool IsRequiredInEntity
        {
            get { return this._isRequiredInEntity.GetValueOrDefault(); }
            set { this._isRequiredInEntity = value; }
        }

        // Check to see if IsRequiredInEntity property is set
        internal bool IsSetIsRequiredInEntity()
        {
            return this._isRequiredInEntity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsStoredExternally. 
        /// <para>
        /// A Boolean value that specifies whether the property is stored externally.
        /// </para>
        /// </summary>
        public bool IsStoredExternally
        {
            get { return this._isStoredExternally.GetValueOrDefault(); }
            set { this._isStoredExternally = value; }
        }

        // Check to see if IsStoredExternally property is set
        internal bool IsSetIsStoredExternally()
        {
            return this._isStoredExternally.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsTimeSeries. 
        /// <para>
        /// A Boolean value that specifies whether the property consists of time series data.
        /// </para>
        /// </summary>
        public bool IsTimeSeries
        {
            get { return this._isTimeSeries.GetValueOrDefault(); }
            set { this._isTimeSeries = value; }
        }

        // Check to see if IsTimeSeries property is set
        internal bool IsSetIsTimeSeries()
        {
            return this._isTimeSeries.HasValue; 
        }

    }
}