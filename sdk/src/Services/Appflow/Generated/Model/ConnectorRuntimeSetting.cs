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
    /// Contains information about the connector runtime settings that are required for flow
    /// execution.
    /// </summary>
    public partial class ConnectorRuntimeSetting
    {
        private List<string> _connectorSuppliedValueOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dataType;
        private string _description;
        private bool? _isRequired;
        private string _key;
        private string _label;
        private string _scope;

        /// <summary>
        /// Gets and sets the property ConnectorSuppliedValueOptions. 
        /// <para>
        /// Contains default values for the connector runtime setting that are supplied by the
        /// connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectorSuppliedValueOptions
        {
            get { return this._connectorSuppliedValueOptions; }
            set { this._connectorSuppliedValueOptions = value; }
        }

        // Check to see if ConnectorSuppliedValueOptions property is set
        internal bool IsSetConnectorSuppliedValueOptions()
        {
            return this._connectorSuppliedValueOptions != null && (this._connectorSuppliedValueOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Data type of the connector runtime setting.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DataType
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the connector runtime setting.
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
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether this connector runtime setting is required.
        /// </para>
        /// </summary>
        public bool? IsRequired
        {
            get { return this._isRequired; }
            set { this._isRequired = value; }
        }

        // Check to see if IsRequired property is set
        internal bool IsSetIsRequired()
        {
            return this._isRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Contains value information about the connector runtime setting.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A label used for connector runtime setting.
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// Indicates the scope of the connector runtime setting.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}