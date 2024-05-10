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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Indicates that a login attempt was made to the potentially compromised database from
    /// a remote IP address.
    /// </summary>
    public partial class RdsLoginAttemptAction
    {
        private List<LoginAttribute> _loginAttributes = AWSConfigs.InitializeCollections ? new List<LoginAttribute>() : null;
        private RemoteIpDetails _remoteIpDetails;

        /// <summary>
        /// Gets and sets the property LoginAttributes. 
        /// <para>
        /// Indicates the login attributes used in the login attempt.
        /// </para>
        /// </summary>
        public List<LoginAttribute> LoginAttributes
        {
            get { return this._loginAttributes; }
            set { this._loginAttributes = value; }
        }

        // Check to see if LoginAttributes property is set
        internal bool IsSetLoginAttributes()
        {
            return this._loginAttributes != null && (this._loginAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteIpDetails.
        /// </summary>
        public RemoteIpDetails RemoteIpDetails
        {
            get { return this._remoteIpDetails; }
            set { this._remoteIpDetails = value; }
        }

        // Check to see if RemoteIpDetails property is set
        internal bool IsSetRemoteIpDetails()
        {
            return this._remoteIpDetails != null;
        }

    }
}