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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePrivateConnection operation.
    /// Creates a private connection for reaching a self-hosted provider instance over private
    /// networking using Amazon VPC Lattice.
    /// </summary>
    public partial class CreatePrivateConnectionRequest : AmazonSecurityAgentRequest
    {
        private PrivateConnectionMode _mode;
        private string _privateConnectionName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The configuration for the private connection. Specify either a service-managed or
        /// a self-managed mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateConnectionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// A unique name for the private connection within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrivateConnectionName
        {
            get { return this._privateConnectionName; }
            set { this._privateConnectionName = value; }
        }

        // Check to see if PrivateConnectionName property is set
        internal bool IsSetPrivateConnectionName()
        {
            return this._privateConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the private connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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