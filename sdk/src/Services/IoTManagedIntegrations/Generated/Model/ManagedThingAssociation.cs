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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
        private string _accountAssociationId;
        private ManagedThingAssociationStatus _managedThingAssociationStatus;
        private string _managedThingId;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AccountAssociationId
        {
            get { return this._accountAssociationId; }
            set { this._accountAssociationId = value; }
        }

        // Check to see if AccountAssociationId property is set
        internal bool IsSetAccountAssociationId()
        {
            return this._accountAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedThingAssociationStatus. 
        /// <para>
        /// The status of the registration between the managed thing and the account association.
        /// Indicates whether the device is pre-associated or fully associated with the account
        /// association.
        /// </para>
        /// </summary>
        public ManagedThingAssociationStatus ManagedThingAssociationStatus
        {
            get { return this._managedThingAssociationStatus; }
            set { this._managedThingAssociationStatus = value; }
        }

        // Check to see if ManagedThingAssociationStatus property is set
        internal bool IsSetManagedThingAssociationStatus()
        {
            return this._managedThingAssociationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The identifier of the managed thing in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

    }
}