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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about agent-first preview mode outbound strategy configuration.
    /// </summary>
    public partial class Preview
    {
        private List<string> _allowedUserActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PostAcceptTimeoutConfig _postAcceptTimeoutConfig;

        /// <summary>
        /// Gets and sets the property AllowedUserActions. 
        /// <para>
        /// The actions the agent can perform after accepting the preview outbound contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllowedUserActions
        {
            get { return this._allowedUserActions; }
            set { this._allowedUserActions = value; }
        }

        // Check to see if AllowedUserActions property is set
        internal bool IsSetAllowedUserActions()
        {
            return this._allowedUserActions != null && (this._allowedUserActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PostAcceptTimeoutConfig. 
        /// <para>
        /// Countdown timer configuration after the agent accepted the preview outbound contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PostAcceptTimeoutConfig PostAcceptTimeoutConfig
        {
            get { return this._postAcceptTimeoutConfig; }
            set { this._postAcceptTimeoutConfig = value; }
        }

        // Check to see if PostAcceptTimeoutConfig property is set
        internal bool IsSetPostAcceptTimeoutConfig()
        {
            return this._postAcceptTimeoutConfig != null;
        }

    }
}