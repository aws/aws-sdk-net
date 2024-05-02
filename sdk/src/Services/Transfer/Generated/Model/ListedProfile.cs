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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns the properties of the profile that was specified.
    /// </summary>
    public partial class ListedProfile
    {
        private string _arn;
        private string _as2Id;
        private string _profileId;
        private ProfileType _profileType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property As2Id. 
        /// <para>
        /// The <c>As2Id</c> is the <i>AS2-name</i>, as defined in the <a href="https://datatracker.ietf.org/doc/html/rfc4130">RFC
        /// 4130</a>. For inbound transfers, this is the <c>AS2-From</c> header for the AS2 messages
        /// sent from the partner. For outbound connectors, this is the <c>AS2-To</c> header for
        /// the AS2 messages sent to the partner using the <c>StartFileTransfer</c> API operation.
        /// This ID cannot include spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string As2Id
        {
            get { return this._as2Id; }
            set { this._as2Id = value; }
        }

        // Check to see if As2Id property is set
        internal bool IsSetAs2Id()
        {
            return this._as2Id != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// A unique identifier for the local or partner AS2 profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// Indicates whether to list only <c>LOCAL</c> type profiles or only <c>PARTNER</c> type
        /// profiles. If not supplied in the request, the command lists all types of profiles.
        /// </para>
        /// </summary>
        public ProfileType ProfileType
        {
            get { return this._profileType; }
            set { this._profileType = value; }
        }

        // Check to see if ProfileType property is set
        internal bool IsSetProfileType()
        {
            return this._profileType != null;
        }

    }
}