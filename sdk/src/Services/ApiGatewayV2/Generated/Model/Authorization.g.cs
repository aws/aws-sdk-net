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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents an authorization configuration for a portal.
    /// </summary>
    public partial class Authorization
    {
        /// <summary>
        /// Gets and sets the property CognitoConfig. 
        /// <para>
        /// The Amazon Cognito configuration.
        /// </para>
        /// </summary>
        public CognitoConfig CognitoConfig { get; set; }

        /// <summary>
        /// Checks to see if the CognitoConfig property is set.
        /// </summary>
        internal bool IsSetCognitoConfig() => this.CognitoConfig != null;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// Provide no authorization for your portal. This makes your portal publicly accesible
        /// on the web.
        /// </para>
        /// </summary>
        public None None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;
    }
}
