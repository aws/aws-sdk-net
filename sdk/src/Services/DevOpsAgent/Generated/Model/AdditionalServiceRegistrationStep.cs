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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Additional steps required to complete service registration.
    /// </summary>
    public partial class AdditionalServiceRegistrationStep
    {
        private OAuthAdditionalStepDetails _oauth;

        /// <summary>
        /// Gets and sets the property Oauth. 
        /// <para>
        /// OAuth authorization step required.
        /// </para>
        /// </summary>
        public OAuthAdditionalStepDetails Oauth
        {
            get { return this._oauth; }
            set { this._oauth = value; }
        }

        // Check to see if Oauth property is set
        internal bool IsSetOauth()
        {
            return this._oauth != null;
        }

    }
}