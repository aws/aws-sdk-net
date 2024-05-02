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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A node input port.
    /// </summary>
    public partial class NodeInputPort
    {
        private string _defaultValue;
        private string _description;
        private int? _maxConnections;
        private string _name;
        private PortType _type;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The input port's default value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The input port's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property MaxConnections. 
        /// <para>
        /// The input port's max connections.
        /// </para>
        /// </summary>
        public int? MaxConnections
        {
            get { return this._maxConnections; }
            set { this._maxConnections = value; }
        }

        // Check to see if MaxConnections property is set
        internal bool IsSetMaxConnections()
        {
            return this._maxConnections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The input port's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The input port's type.
        /// </para>
        /// </summary>
        public PortType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}