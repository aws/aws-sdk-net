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
    /// Container for the parameters to the CreateConnector operation.
    /// Create Connector.
    /// </summary>
    public partial class CreateConnectorRequest : AmazonMgnRequest
    {
        private string _name;
        private ConnectorSsmCommandConfig _ssmCommandConfig;
        private string _ssmInstanceID;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Create Connector request name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Create Connector request SSM command config.
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
        /// Create Connector request SSM instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=20)]
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
        /// Create Connector request tags.
        /// </para>
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