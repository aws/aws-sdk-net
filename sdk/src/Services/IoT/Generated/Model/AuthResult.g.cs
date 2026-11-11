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
    /// The authorizer result.
    /// </summary>
    public partial class AuthResult
    {
        /// <summary>
        /// Gets and sets the property Allowed. 
        /// <para>
        /// The policies and statements that allowed the specified action.
        /// </para>
        /// </summary>
        public Allowed Allowed { get; set; }

        /// <summary>
        /// Checks to see if the Allowed property is set.
        /// </summary>
        internal bool IsSetAllowed() => this.Allowed != null;

        /// <summary>
        /// Gets and sets the property AuthDecision. 
        /// <para>
        /// The final authorization decision of this scenario. Multiple statements are taken into
        /// account when determining the authorization decision. An explicit deny statement can
        /// override multiple allow statements.
        /// </para>
        /// </summary>
        public AuthDecision AuthDecision { get; set; }

        /// <summary>
        /// Checks to see if the AuthDecision property is set.
        /// </summary>
        internal bool IsSetAuthDecision() => this.AuthDecision != null;

        /// <summary>
        /// Gets and sets the property AuthInfo. 
        /// <para>
        /// Authorization information.
        /// </para>
        /// </summary>
        public AuthInfo AuthInfo { get; set; }

        /// <summary>
        /// Checks to see if the AuthInfo property is set.
        /// </summary>
        internal bool IsSetAuthInfo() => this.AuthInfo != null;

        /// <summary>
        /// Gets and sets the property Denied. 
        /// <para>
        /// The policies and statements that denied the specified action.
        /// </para>
        /// </summary>
        public Denied Denied { get; set; }

        /// <summary>
        /// Checks to see if the Denied property is set.
        /// </summary>
        internal bool IsSetDenied() => this.Denied != null;

        /// <summary>
        /// Gets and sets the property MissingContextValues. 
        /// <para>
        /// Contains any missing context values found while evaluating policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MissingContextValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MissingContextValues property is set.
        /// </summary>
        internal bool IsSetMissingContextValues() => this.MissingContextValues != null && (this.MissingContextValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
