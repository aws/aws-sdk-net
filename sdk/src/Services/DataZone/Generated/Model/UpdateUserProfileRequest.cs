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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserProfile operation.
    /// Updates the specified user profile in Amazon DataZone.
    /// </summary>
    public partial class UpdateUserProfileRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private UserProfileStatus _status;
        private UserProfileType _type;
        private string _userIdentifier;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a user profile is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the user profile that are to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the user profile that are to be updated.
        /// </para>
        /// </summary>
        public UserProfileType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentifier. 
        /// <para>
        /// The identifier of the user whose user profile is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserIdentifier
        {
            get { return this._userIdentifier; }
            set { this._userIdentifier = value; }
        }

        // Check to see if UserIdentifier property is set
        internal bool IsSetUserIdentifier()
        {
            return this._userIdentifier != null;
        }

    }
}