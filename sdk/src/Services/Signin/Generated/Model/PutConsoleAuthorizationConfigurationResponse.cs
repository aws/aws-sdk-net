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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Output for PutConsoleAuthorizationConfiguration operation
    /// </summary>
    public partial class PutConsoleAuthorizationConfigurationResponse : AmazonWebServiceResponse
    {
        private bool? _consoleAuthorizationEnabled;
        private string _scope;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property ConsoleAuthorizationEnabled. 
        /// <para>
        /// Whether console authorization is enabled
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ConsoleAuthorizationEnabled
        {
            get { return this._consoleAuthorizationEnabled; }
            set { this._consoleAuthorizationEnabled = value; }
        }

        // Check to see if ConsoleAuthorizationEnabled property is set
        internal bool IsSetConsoleAuthorizationEnabled()
        {
            return this._consoleAuthorizationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Authorization scope
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// Target account identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=32)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}