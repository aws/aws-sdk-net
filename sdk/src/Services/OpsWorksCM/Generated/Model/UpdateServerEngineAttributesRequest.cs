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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServerEngineAttributes operation.
    /// Updates engine-specific attributes on a specified server. The server enters the <code>MODIFYING</code>
    /// state when this operation is in progress. Only one update can occur at a time. You
    /// can use this command to reset a Chef server's public key (<code>CHEF_PIVOTAL_KEY</code>)
    /// or a Puppet server's admin password (<code>PUPPET_ADMIN_PASSWORD</code>). 
    /// 
    ///  
    /// <para>
    ///  This operation is asynchronous. 
    /// </para>
    ///  
    /// <para>
    ///  This operation can only be called for servers in <code>HEALTHY</code> or <code>UNHEALTHY</code>
    /// states. Otherwise, an <code>InvalidStateException</code> is raised. A <code>ResourceNotFoundException</code>
    /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
    /// when parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class UpdateServerEngineAttributesRequest : AmazonOpsWorksCMRequest
    {
        private string _attributeName;
        private string _attributeValue;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the engine attribute to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value to set for the attribute. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}