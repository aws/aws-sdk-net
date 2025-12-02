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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// An alias that provides a stable reference to a model version.
    /// </summary>
    public partial class ModelAlias
    {
        private string _aliasName;
        private string _latestModelId;
        private string _resolvedModelId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the model alias.
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
        /// Gets and sets the property LatestModelId. 
        /// <para>
        /// The model ID that this alias currently points to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string LatestModelId
        {
            get { return this._latestModelId; }
            set { this._latestModelId = value; }
        }

        // Check to see if LatestModelId property is set
        internal bool IsSetLatestModelId()
        {
            return this._latestModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedModelId. 
        /// <para>
        /// The resolved model ID after alias resolution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ResolvedModelId
        {
            get { return this._resolvedModelId; }
            set { this._resolvedModelId = value; }
        }

        // Check to see if ResolvedModelId property is set
        internal bool IsSetResolvedModelId()
        {
            return this._resolvedModelId != null;
        }

    }
}