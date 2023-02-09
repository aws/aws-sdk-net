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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// Creates an Amazon Web Services Migration Hub Refactor Spaces environment. The caller
    /// owns the environment resource, and all Refactor Spaces applications, services, and
    /// routes created within the environment. They are referred to as the <i>environment
    /// owner</i>. The environment owner has cross-account visibility and control of Refactor
    /// Spaces resources that are added to the environment by other accounts that the environment
    /// is shared with.
    /// 
    ///  
    /// <para>
    /// When creating an environment with a network fabric type of <code>TRANSIT_GATEWAY</code>,
    /// Refactor Spaces provisions a transit gateway in your account.
    /// </para>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private NetworkFabricType _networkFabricType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property NetworkFabricType. 
        /// <para>
        /// The network fabric type of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkFabricType NetworkFabricType
        {
            get { return this._networkFabricType; }
            set { this._networkFabricType = value; }
        }

        // Check to see if NetworkFabricType property is set
        internal bool IsSetNetworkFabricType()
        {
            return this._networkFabricType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the environment. A tag is a label that you assign to an Amazon
        /// Web Services resource. Each tag consists of a key-value pair.
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}