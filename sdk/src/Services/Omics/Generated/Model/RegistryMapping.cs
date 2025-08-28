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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// If you are using the ECR pull through cache feature, the registry mapping maps between
    /// the ECR repository and the upstream registry where container images are pulled and
    /// synchronized.
    /// </summary>
    public partial class RegistryMapping
    {
        private string _ecrAccountId;
        private string _ecrRepositoryPrefix;
        private string _upstreamRegistryUrl;
        private string _upstreamRepositoryPrefix;

        /// <summary>
        /// Gets and sets the property EcrAccountId. 
        /// <para>
        /// Account ID of the account that owns the upstream container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string EcrAccountId
        {
            get { return this._ecrAccountId; }
            set { this._ecrAccountId = value; }
        }

        // Check to see if EcrAccountId property is set
        internal bool IsSetEcrAccountId()
        {
            return this._ecrAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EcrRepositoryPrefix. 
        /// <para>
        /// The repository prefix to use in the ECR private repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EcrRepositoryPrefix
        {
            get { return this._ecrRepositoryPrefix; }
            set { this._ecrRepositoryPrefix = value; }
        }

        // Check to see if EcrRepositoryPrefix property is set
        internal bool IsSetEcrRepositoryPrefix()
        {
            return this._ecrRepositoryPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property UpstreamRegistryUrl. 
        /// <para>
        /// The URI of the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string UpstreamRegistryUrl
        {
            get { return this._upstreamRegistryUrl; }
            set { this._upstreamRegistryUrl = value; }
        }

        // Check to see if UpstreamRegistryUrl property is set
        internal bool IsSetUpstreamRegistryUrl()
        {
            return this._upstreamRegistryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UpstreamRepositoryPrefix. 
        /// <para>
        /// The repository prefix of the corresponding repository in the upstream registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string UpstreamRepositoryPrefix
        {
            get { return this._upstreamRepositoryPrefix; }
            set { this._upstreamRepositoryPrefix = value; }
        }

        // Check to see if UpstreamRepositoryPrefix property is set
        internal bool IsSetUpstreamRepositoryPrefix()
        {
            return this._upstreamRepositoryPrefix != null;
        }

    }
}