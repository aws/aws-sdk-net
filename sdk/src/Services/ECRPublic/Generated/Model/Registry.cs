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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// The details of a public registry.
    /// </summary>
    public partial class Registry
    {
        private List<RegistryAlias> _aliases = new List<RegistryAlias>();
        private string _registryArn;
        private string _registryId;
        private string _registryUri;
        private bool? _verified;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// An array of objects that represents the aliases for a public registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RegistryAlias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && this._aliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the public registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the registry. If you do
        /// not specify a registry, the default public registry is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryUri. 
        /// <para>
        /// The URI of a public registry. The URI contains a universal prefix and the registry
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryUri
        {
            get { return this._registryUri; }
            set { this._registryUri = value; }
        }

        // Check to see if RegistryUri property is set
        internal bool IsSetRegistryUri()
        {
            return this._registryUri != null;
        }

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Indicates whether the account is a verified Amazon Web Services Marketplace vendor.
        /// If an account is verified, each public repository receives a verified account badge
        /// on the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Verified
        {
            get { return this._verified.GetValueOrDefault(); }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified.HasValue; 
        }

    }
}