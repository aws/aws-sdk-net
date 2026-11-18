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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The number of entities of one type that a point-in-time recovery creates, updates,
    /// and deletes.
    /// </summary>
    public partial class RestorePreviewType
    {
        /// <summary>
        /// Gets and sets the property CreateCount. 
        /// <para>
        /// The number of entities of this type that the recovery creates. These entities existed
        /// at the recovery point and were deleted after it.
        /// </para>
        /// </summary>
        public long? CreateCount { get; set; }

        /// <summary>
        /// Checks to see if the CreateCount property is set.
        /// </summary>
        internal bool IsSetCreateCount() => this.CreateCount.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteCount. 
        /// <para>
        /// The number of entities of this type that the recovery deletes. These entities were
        /// created after the recovery point.
        /// </para>
        /// </summary>
        public long? DeleteCount { get; set; }

        /// <summary>
        /// Checks to see if the DeleteCount property is set.
        /// </summary>
        internal bool IsSetDeleteCount() => this.DeleteCount.HasValue;

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The type of user pool entity that the recovery changes. Can be one of the following
        /// values.
        /// </para>
        ///  <dl> <dt>Users</dt> <dd> 
        /// <para>
        /// User profiles, including their attributes.
        /// </para>
        ///  </dd> <dt>Groups</dt> <dd> 
        /// <para>
        /// User pool groups.
        /// </para>
        ///  </dd> <dt>User MFAs</dt> <dd> 
        /// <para>
        /// The MFA settings of users.
        /// </para>
        ///  </dd> <dt>Passkeys</dt> <dd> 
        /// <para>
        /// The passkeys that users registered.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string Entity { get; set; }

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null;

        /// <summary>
        /// Gets and sets the property UpdateCount. 
        /// <para>
        /// The number of entities of this type that the recovery reverts to their state at the
        /// recovery point. These entities were modified after the recovery point.
        /// </para>
        /// </summary>
        public long? UpdateCount { get; set; }

        /// <summary>
        /// Checks to see if the UpdateCount property is set.
        /// </summary>
        internal bool IsSetUpdateCount() => this.UpdateCount.HasValue;
    }
}
