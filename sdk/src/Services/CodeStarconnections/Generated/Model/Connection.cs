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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// A resource that is used to connect third-party source providers with services like
    /// CodePipeline.
    /// 
    ///  
    /// <para>
    /// Note: A connection created through CloudFormation, the CLI, or the SDK is in `PENDING`
    /// status by default. You can make its status `AVAILABLE` by updating the connection
    /// in the console.
    /// </para>
    /// </summary>
    public partial class Connection
    {
        private string _connectionArn;
        private string _connectionName;
        private ConnectionStatus _connectionStatus;
        private string _hostArn;
        private string _ownerAccountId;
        private ProviderType _providerType;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection. The ARN is used as the connection
        /// reference when the connection is shared between Amazon Web Services services.
        /// </para>
        ///  <note> 
        /// <para>
        /// The ARN is never reused if the connection is deleted.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection. Connection names must be unique in an Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The current status of the connection. 
        /// </para>
        /// </summary>
        public ConnectionStatus ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }

        // Check to see if ConnectionStatus property is set
        internal bool IsSetConnectionStatus()
        {
            return this._connectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the host associated with the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string HostArn
        {
            get { return this._hostArn; }
            set { this._hostArn = value; }
        }

        // Check to see if HostArn property is set
        internal bool IsSetHostArn()
        {
            return this._hostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The identifier of the external provider where your third-party code repository is
        /// configured. For Bitbucket, this is the account ID of the owner of the Bitbucket repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The name of the external provider where your third-party code repository is configured.
        /// </para>
        /// </summary>
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

    }
}