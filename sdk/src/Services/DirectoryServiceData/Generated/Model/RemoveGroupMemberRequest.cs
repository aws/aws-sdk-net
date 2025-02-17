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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveGroupMember operation.
    /// Removes a member from a group.
    /// </summary>
    public partial class RemoveGroupMemberRequest : AmazonDirectoryServiceDataRequest
    {
        private string _clientToken;
        private string _directoryId;
        private string _groupName;
        private string _memberName;
        private string _memberRealm;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique and case-sensitive identifier that you provide to make sure the idempotency
        /// of the request, so multiple identical calls have the same effect as one single call.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A client token is valid for 8 hours after the first request that uses it completes.
        /// After 8 hours, any request with the same client token is treated as a new request.
        /// If the request succeeds, any future uses of that token will be idempotent for another
        /// 8 hours. 
        /// </para>
        ///  
        /// <para>
        ///  If you submit a request with the same client token but change one of the other parameters
        /// within the 8-hour idempotency window, Directory Service Data returns an <c>ConflictException</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional when using the CLI or SDK. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the member. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  The name of the group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property MemberName. 
        /// <para>
        ///  The <c>SAMAccountName</c> of the user, group, or computer to remove from the group.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MemberName
        {
            get { return this._memberName; }
            set { this._memberName = value; }
        }

        // Check to see if MemberName property is set
        internal bool IsSetMemberName()
        {
            return this._memberName != null;
        }

        /// <summary>
        /// Gets and sets the property MemberRealm. 
        /// <para>
        ///  The domain name that's associated with the group member. This parameter defaults
        /// to the Managed Microsoft AD domain. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional and case insensitive. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MemberRealm
        {
            get { return this._memberRealm; }
            set { this._memberRealm = value; }
        }

        // Check to see if MemberRealm property is set
        internal bool IsSetMemberRealm()
        {
            return this._memberRealm != null;
        }

    }
}