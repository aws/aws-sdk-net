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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstance operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Initiates an Amazon Connect instance with all the supported channels enabled. It does
    /// not attach any storage, such as Amazon Simple Storage Service (Amazon S3) or Amazon
    /// Kinesis. It also does not allow for any configurations on features, such as Contact
    /// Lens for Amazon Connect. 
    /// </para>
    ///  
    /// <para>
    /// Amazon Connect enforces a limit on the total number of instances that you can create
    /// or delete in 30 days. If you exceed this limit, you will get an error message indicating
    /// there has been an excessive number of attempts at creating or deleting instances.
    /// You must wait 30 days before you can restart creating and deleting instances in your
    /// account.
    /// </para>
    /// </summary>
    public partial class CreateInstanceRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private string _directoryId;
        private DirectoryType _identityManagementType;
        private bool? _inboundCallsEnabled;
        private string _instanceAlias;
        private bool? _outboundCallsEnabled;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityManagementType. 
        /// <para>
        /// The type of identity management for your Amazon Connect users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DirectoryType IdentityManagementType
        {
            get { return this._identityManagementType; }
            set { this._identityManagementType = value; }
        }

        // Check to see if IdentityManagementType property is set
        internal bool IsSetIdentityManagementType()
        {
            return this._identityManagementType != null;
        }

        /// <summary>
        /// Gets and sets the property InboundCallsEnabled. 
        /// <para>
        /// Your contact center handles incoming contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool InboundCallsEnabled
        {
            get { return this._inboundCallsEnabled.GetValueOrDefault(); }
            set { this._inboundCallsEnabled = value; }
        }

        // Check to see if InboundCallsEnabled property is set
        internal bool IsSetInboundCallsEnabled()
        {
            return this._inboundCallsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceAlias. 
        /// <para>
        /// The name for your instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=62)]
        public string InstanceAlias
        {
            get { return this._instanceAlias; }
            set { this._instanceAlias = value; }
        }

        // Check to see if InstanceAlias property is set
        internal bool IsSetInstanceAlias()
        {
            return this._instanceAlias != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallsEnabled. 
        /// <para>
        /// Your contact center allows outbound calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool OutboundCallsEnabled
        {
            get { return this._outboundCallsEnabled.GetValueOrDefault(); }
            set { this._outboundCallsEnabled = value; }
        }

        // Check to see if OutboundCallsEnabled property is set
        internal bool IsSetOutboundCallsEnabled()
        {
            return this._outboundCallsEnabled.HasValue; 
        }

    }
}