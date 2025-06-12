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
    /// Container for the parameters to the AssociateUserProficiencies operation.
    /// Associates a set of proficiencies with a user.
    /// </summary>
    public partial class AssociateUserProficienciesRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _userId;
        private List<UserProficiency> _userProficiencies = AWSConfigs.InitializeCollections ? new List<UserProficiency>() : null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN of the instance).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserProficiencies. 
        /// <para>
        /// The proficiencies to associate with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UserProficiency> UserProficiencies
        {
            get { return this._userProficiencies; }
            set { this._userProficiencies = value; }
        }

        // Check to see if UserProficiencies property is set
        internal bool IsSetUserProficiencies()
        {
            return this._userProficiencies != null && (this._userProficiencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}