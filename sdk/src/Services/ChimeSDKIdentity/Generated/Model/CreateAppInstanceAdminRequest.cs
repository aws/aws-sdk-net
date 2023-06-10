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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppInstanceAdmin operation.
    /// Promotes an <code>AppInstanceUser</code> or <code>AppInstanceBot</code> to an <code>AppInstanceAdmin</code>.
    /// The promoted entity can perform the following actions. 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>ChannelModerator</code> actions across all channels in the <code>AppInstance</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteChannelMessage</code> actions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Only an <code>AppInstanceUser</code> and <code>AppInstanceBot</code> can be promoted
    /// to an <code>AppInstanceAdmin</code> role.
    /// </para>
    /// </summary>
    public partial class CreateAppInstanceAdminRequest : AmazonChimeSDKIdentityRequest
    {
        private string _appInstanceAdminArn;
        private string _appInstanceArn;

        /// <summary>
        /// Gets and sets the property AppInstanceAdminArn. 
        /// <para>
        /// The ARN of the administrator of the current <code>AppInstance</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceAdminArn
        {
            get { return this._appInstanceAdminArn; }
            set { this._appInstanceAdminArn = value; }
        }

        // Check to see if AppInstanceAdminArn property is set
        internal bool IsSetAppInstanceAdminArn()
        {
            return this._appInstanceAdminArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <code>AppInstance</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

    }
}