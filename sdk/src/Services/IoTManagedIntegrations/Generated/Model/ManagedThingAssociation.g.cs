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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing an association between a managed thing and an account association,
    /// which connects a device to a third-party account.
    /// </summary>
    public partial class ManagedThingAssociation
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property ManagedThingAssociationStatus. 
        /// <para>
        /// The status of the registration between the managed thing and the account association.
        /// Indicates whether the device is pre-associated or fully associated with the account
        /// association.
        /// </para>
        /// </summary>
        public ManagedThingAssociationStatus ManagedThingAssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ManagedThingAssociationStatus property is set.
        /// </summary>
        internal bool IsSetManagedThingAssociationStatus() => this.ManagedThingAssociationStatus != null;

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The identifier of the managed thing in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ManagedThingId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedThingId property is set.
        /// </summary>
        internal bool IsSetManagedThingId() => this.ManagedThingId != null;
    }
}
