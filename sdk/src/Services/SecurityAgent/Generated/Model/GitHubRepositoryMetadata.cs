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
    /// Metadata specific to a GitHub repository integrated resource
    /// </summary>
    public partial class GitHubRepositoryMetadata
    {
        private AccessType _accessType;
        private string _name;
        private string _owner;
        private string _providerResourceId;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// Access / Visibility Type of the integrated resource
        /// </para>
        /// </summary>
        public AccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the resource e.g. repository name, etc
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Owner of the repository
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderResourceId. 
        /// <para>
        /// Unique resource identifier from the vendor
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderResourceId
        {
            get { return this._providerResourceId; }
            set { this._providerResourceId = value; }
        }

        // Check to see if ProviderResourceId property is set
        internal bool IsSetProviderResourceId()
        {
            return this._providerResourceId != null;
        }

    }
}