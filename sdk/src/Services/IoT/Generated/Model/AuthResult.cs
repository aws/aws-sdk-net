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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private Allowed _allowed;
        private AuthDecision _authDecision;
        private AuthInfo _authInfo;
        private Denied _denied;
        private List<string> _missingContextValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Allowed. 
        /// <para>
        /// The policies and statements that allowed the specified action.
        /// </para>
        /// </summary>
        public Allowed Allowed
        {
            get { return this._allowed; }
            set { this._allowed = value; }
        }

        // Check to see if Allowed property is set
        internal bool IsSetAllowed()
        {
            return this._allowed != null;
        }

        /// <summary>
        /// Gets and sets the property AuthDecision. 
        /// <para>
        /// The final authorization decision of this scenario. Multiple statements are taken into
        /// account when determining the authorization decision. An explicit deny statement can
        /// override multiple allow statements.
        /// </para>
        /// </summary>
        public AuthDecision AuthDecision
        {
            get { return this._authDecision; }
            set { this._authDecision = value; }
        }

        // Check to see if AuthDecision property is set
        internal bool IsSetAuthDecision()
        {
            return this._authDecision != null;
        }

        /// <summary>
        /// Gets and sets the property AuthInfo. 
        /// <para>
        /// Authorization information.
        /// </para>
        /// </summary>
        public AuthInfo AuthInfo
        {
            get { return this._authInfo; }
            set { this._authInfo = value; }
        }

        // Check to see if AuthInfo property is set
        internal bool IsSetAuthInfo()
        {
            return this._authInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Denied. 
        /// <para>
        /// The policies and statements that denied the specified action.
        /// </para>
        /// </summary>
        public Denied Denied
        {
            get { return this._denied; }
            set { this._denied = value; }
        }

        // Check to see if Denied property is set
        internal bool IsSetDenied()
        {
            return this._denied != null;
        }

        /// <summary>
        /// Gets and sets the property MissingContextValues. 
        /// <para>
        /// Contains any missing context values found while evaluating policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MissingContextValues
        {
            get { return this._missingContextValues; }
            set { this._missingContextValues = value; }
        }

        // Check to see if MissingContextValues property is set
        internal bool IsSetMissingContextValues()
        {
            return this._missingContextValues != null && (this._missingContextValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}