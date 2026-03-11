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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContactFlowModuleAlias operation.
    /// Creates a named alias that points to a specific version of a contact flow module.
    /// </summary>
    public partial class CreateContactFlowModuleAliasRequest : AmazonConnectRequest
    {
        private string _aliasName;
        private string _contactFlowModuleId;
        private long? _contactFlowModuleVersion;
        private string _description;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowModuleId. 
        /// <para>
        /// The identifier of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactFlowModuleId
        {
            get { return this._contactFlowModuleId; }
            set { this._contactFlowModuleId = value; }
        }

        // Check to see if ContactFlowModuleId property is set
        internal bool IsSetContactFlowModuleId()
        {
            return this._contactFlowModuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowModuleVersion. 
        /// <para>
        /// The version of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? ContactFlowModuleVersion
        {
            get { return this._contactFlowModuleVersion; }
            set { this._contactFlowModuleVersion = value; }
        }

        // Check to see if ContactFlowModuleVersion property is set
        internal bool IsSetContactFlowModuleVersion()
        {
            return this._contactFlowModuleVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the alias.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}