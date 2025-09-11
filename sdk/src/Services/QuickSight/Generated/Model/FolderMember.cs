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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An asset in a QuickSight folder, such as a dashboard, analysis, or dataset.
    /// </summary>
    public partial class FolderMember
    {
        private string _memberId;
        private MemberType _memberType;

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The ID of an asset in the folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The type of asset that it is.
        /// </para>
        /// </summary>
        public MemberType MemberType
        {
            get { return this._memberType; }
            set { this._memberType = value; }
        }

        // Check to see if MemberType property is set
        internal bool IsSetMemberType()
        {
            return this._memberType != null;
        }

    }
}