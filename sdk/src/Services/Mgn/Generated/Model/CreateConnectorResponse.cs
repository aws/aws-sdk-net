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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the CreateConnector operation.
    /// </summary>
    public partial class CreateConnectorResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _connectorid;
        private string _name;
        private ConnectorSsmCommandConfig _ssmCommandConfig;
        private string _ssmInstanceID;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Connector arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorID. 
        /// <para>
        /// Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=27, Max=27)]
        public string ConnectorID
        {
            get { return this._connectorid; }
            set { this._connectorid = value; }
        }

        // Check to see if ConnectorID property is set
        internal bool IsSetConnectorID()
        {
            return this._connectorid != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Connector name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property SsmCommandConfig. 
        /// <para>
        /// Connector SSM command config.
        /// </para>
        /// </summary>
        public ConnectorSsmCommandConfig SsmCommandConfig
        {
            get { return this._ssmCommandConfig; }
            set { this._ssmCommandConfig = value; }
        }

        // Check to see if SsmCommandConfig property is set
        internal bool IsSetSsmCommandConfig()
        {
            return this._ssmCommandConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SsmInstanceID. 
        /// <para>
        /// Connector SSM instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=20)]
        public string SsmInstanceID
        {
            get { return this._ssmInstanceID; }
            set { this._ssmInstanceID = value; }
        }

        // Check to see if SsmInstanceID property is set
        internal bool IsSetSsmInstanceID()
        {
            return this._ssmInstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Connector tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}