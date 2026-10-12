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
    /// Contains information about a replica user pool, including Region, status, role, and
    /// ARN.
    /// </summary>
    public partial class UserPoolReplicaType
    {
        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region where the replica is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 32)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the user pool replica that determines which API operations are enabled.
        /// </para>
        ///  <dl> <dt>PRIMARY</dt> <dd> 
        /// <para>
        /// The primary replica supports all end user and administrator operations.
        /// </para>
        ///  </dd> <dt>SECONDARY</dt> <dd> 
        /// <para>
        /// The secondary replica supports a limited set of end user and administrator operations.
        /// Generally, only administrator operations that set configurations specific to the replica,
        /// and only end-user operations that do not create or change attributes of a user are
        /// supported. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReplicaRoleType Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the replica.
        /// </para>
        ///  <dl> <dt>CREATING</dt> <dd> 
        /// <para>
        /// The replica is being created.
        /// </para>
        ///  </dd> <dt>INACTIVE</dt> <dd> 
        /// <para>
        /// The replica has been created, but is not accepting requests for end-users. Administrator
        /// configuration operations are supported.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The replica is available for both end-user and administrator operations.
        /// </para>
        ///  </dd> <dt>DELETING</dt> <dd> 
        /// <para>
        /// The replica is being deleted.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReplicaStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replica user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string UserPoolArn { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolArn property is set.
        /// </summary>
        internal bool IsSetUserPoolArn() => this.UserPoolArn != null;
    }
}
