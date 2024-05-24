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
    /// A resource that represents the infrastructure where a third-party provider is installed.
    /// The host is used when you create connections to an installed third-party provider
    /// type, such as GitHub Enterprise Server. You create one host for all connections to
    /// that provider.
    /// 
    ///  <note> 
    /// <para>
    /// A host created through the CLI or the SDK is in `PENDING` status by default. You can
    /// make its status `AVAILABLE` by setting up the host in the console.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Host
    {
        private string _hostArn;
        private string _name;
        private string _providerEndpoint;
        private ProviderType _providerType;
        private string _status;
        private string _statusMessage;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property HostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the host.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ProviderEndpoint. 
        /// <para>
        /// The endpoint of the infrastructure where your provider type is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ProviderEndpoint
        {
            get { return this._providerEndpoint; }
            set { this._providerEndpoint = value; }
        }

        // Check to see if ProviderEndpoint property is set
        internal bool IsSetProviderEndpoint()
        {
            return this._providerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The name of the installed provider to be associated with your connection. The host
        /// resource represents the infrastructure where your provider type is installed. The
        /// valid provider type is GitHub Enterprise Server.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the host, such as PENDING, AVAILABLE, VPC_CONFIG_DELETING, VPC_CONFIG_INITIALIZING,
        /// and VPC_CONFIG_FAILED_INITIALIZATION.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status description for the host.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration provisioned for the host.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}