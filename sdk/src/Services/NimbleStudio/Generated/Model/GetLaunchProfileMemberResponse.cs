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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// This is the response object from the GetLaunchProfileMember operation.
    /// </summary>
    public partial class GetLaunchProfileMemberResponse : AmazonWebServiceResponse
    {
        private LaunchProfileMembership _member;

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The member.
        /// </para>
        /// </summary>
        public LaunchProfileMembership Member
        {
            get { return this._member; }
            set { this._member = value; }
        }

        // Check to see if Member property is set
        internal bool IsSetMember()
        {
            return this._member != null;
        }

    }
}