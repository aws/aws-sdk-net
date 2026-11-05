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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// An object that specifies the authorization service for a domain.
    /// </summary>
    public partial class AuthorizerConfig
    {
        /// <summary>
        /// Gets and sets the property AllowAuthorizerOverride. 
        /// <para>
        /// A Boolean that specifies whether the domain configuration's authorization service
        /// can be overridden.
        /// </para>
        /// </summary>
        public bool? AllowAuthorizerOverride { get; set; }

        /// <summary>
        /// Checks to see if the AllowAuthorizerOverride property is set.
        /// </summary>
        internal bool IsSetAllowAuthorizerOverride() => this.AllowAuthorizerOverride.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultAuthorizerName. 
        /// <para>
        /// The name of the authorization service for a domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DefaultAuthorizerName { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAuthorizerName property is set.
        /// </summary>
        internal bool IsSetDefaultAuthorizerName() => this.DefaultAuthorizerName != null;
    }
}
