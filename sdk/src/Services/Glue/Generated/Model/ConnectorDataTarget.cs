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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a target generated with standard connection options.
    /// </summary>
    public partial class ConnectorDataTarget
    {
        private string _connectionType;
        private Dictionary<string, string> _data = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The <c>connectionType</c>, as provided to the underlying Glue library. This node type
        /// supports the following connection types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>opensearch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>azuresql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>azurecosmos</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bigquery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>saphana</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>teradata</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vertica</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// A map specifying connection options for the node. You can find standard connection
        /// options for the corresponding connection type in the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-connect.html">
        /// Connection parameters</a> section of the Glue documentation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null && (this._data.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The nodes that are inputs to the data target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this target node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}