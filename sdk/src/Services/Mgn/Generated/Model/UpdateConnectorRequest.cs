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
    /// Container for the parameters to the UpdateConnector operation.
    /// Update Connector.
    /// </summary>
    public partial class UpdateConnectorRequest : AmazonMgnRequest
    {
        private string _connectorid;
        private string _name;
        private ConnectorSsmCommandConfig _ssmCommandConfig;

        /// <summary>
        /// Gets and sets the property ConnectorID. 
        /// <para>
        /// Update Connector request connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=27, Max=27)]
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
        /// Update Connector request name.
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
        /// Update Connector request SSM command config.
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

    }
}