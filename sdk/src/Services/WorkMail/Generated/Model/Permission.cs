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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Permission granted to a user, group, or resource to access a certain aspect of another
    /// user, group, or resource mailbox.
    /// </summary>
    public partial class Permission
    {
        private string _granteeId;
        private MemberType _granteeType;
        private List<string> _permissionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GranteeId. 
        /// <para>
        /// The identifier of the user, group, or resource to which the permissions are granted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=256)]
        public string GranteeId
        {
            get { return this._granteeId; }
            set { this._granteeId = value; }
        }

        // Check to see if GranteeId property is set
        internal bool IsSetGranteeId()
        {
            return this._granteeId != null;
        }

        /// <summary>
        /// Gets and sets the property GranteeType. 
        /// <para>
        /// The type of user, group, or resource referred to in GranteeId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberType GranteeType
        {
            get { return this._granteeType; }
            set { this._granteeType = value; }
        }

        // Check to see if GranteeType property is set
        internal bool IsSetGranteeType()
        {
            return this._granteeType != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionValues. 
        /// <para>
        /// The permissions granted to the grantee. SEND_AS allows the grantee to send email as
        /// the owner of the mailbox (the grantee is not mentioned on these emails). SEND_ON_BEHALF
        /// allows the grantee to send email on behalf of the owner of the mailbox (the grantee
        /// is not mentioned as the physical sender of these emails). FULL_ACCESS allows the grantee
        /// full access to the mailbox, irrespective of other folder-level permissions set on
        /// the mailbox.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PermissionValues
        {
            get { return this._permissionValues; }
            set { this._permissionValues = value; }
        }

        // Check to see if PermissionValues property is set
        internal bool IsSetPermissionValues()
        {
            return this._permissionValues != null && (this._permissionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}