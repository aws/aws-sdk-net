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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the model alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property LatestModelId. 
        /// <para>
        /// The model ID that this alias currently points to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string LatestModelId { get; set; }

        /// <summary>
        /// Checks to see if the LatestModelId property is set.
        /// </summary>
        internal bool IsSetLatestModelId() => this.LatestModelId != null;

        /// <summary>
        /// Gets and sets the property ResolvedModelId. 
        /// <para>
        /// The resolved model ID after alias resolution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResolvedModelId { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedModelId property is set.
        /// </summary>
        internal bool IsSetResolvedModelId() => this.ResolvedModelId != null;
    }
}
