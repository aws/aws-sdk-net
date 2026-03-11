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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// The contact or contact channel that's being engaged.
    /// </summary>
    public partial class Target
    {
        private ChannelTargetInfo _channelTargetInfo;
        private ContactTargetInfo _contactTargetInfo;

        /// <summary>
        /// Gets and sets the property ChannelTargetInfo. 
        /// <para>
        /// Information about the contact channel that Incident Manager engages.
        /// </para>
        /// </summary>
        public ChannelTargetInfo ChannelTargetInfo
        {
            get { return this._channelTargetInfo; }
            set { this._channelTargetInfo = value; }
        }

        // Check to see if ChannelTargetInfo property is set
        internal bool IsSetChannelTargetInfo()
        {
            return this._channelTargetInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ContactTargetInfo. 
        /// <para>
        /// Information about the contact that Incident Manager engages.
        /// </para>
        /// </summary>
        public ContactTargetInfo ContactTargetInfo
        {
            get { return this._contactTargetInfo; }
            set { this._contactTargetInfo = value; }
        }

        // Check to see if ContactTargetInfo property is set
        internal bool IsSetContactTargetInfo()
        {
            return this._contactTargetInfo != null;
        }

    }
}