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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessToken operation.
    /// Creates a personal access token (PAT) for the current user. A personal access token
    /// (PAT) is similar to a password. It is associated with your user account. You use PATs
    /// to access Amazon CodeCatalyst resources such as source repositories from third-party
    /// applications like Git and integrated development environments (IDEs). For more information,
    /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
    /// personal access tokens in Amazon CodeCatalyst</a>.
    /// </summary>
    public partial class CreateAccessTokenRequest : AmazonCodeCatalystRequest
    {
        private DateTime? _expiresTime;
        private string _name;

        /// <summary>
        /// Gets and sets the property ExpiresTime. 
        /// <para>
        /// The date and time the personal access token expires, in coordinated universal time
        /// (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>.
        /// </para>
        /// </summary>
        public DateTime ExpiresTime
        {
            get { return this._expiresTime.GetValueOrDefault(); }
            set { this._expiresTime = value; }
        }

        // Check to see if ExpiresTime property is set
        internal bool IsSetExpiresTime()
        {
            return this._expiresTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the personal access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}