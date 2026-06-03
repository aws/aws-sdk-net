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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Type-specific metadata for each system event type.
    /// </summary>
    public partial class SystemEventMetadata
    {
        private SystemCreatedMetadata _systemCreated;
        private SystemDeletedMetadata _systemDeleted;
        private SystemPolicyAssociatedMetadata _systemPolicyAssociated;
        private SystemPolicyDisassociatedMetadata _systemPolicyDisassociated;
        private SystemServiceAssociatedMetadata _systemServiceAssociated;
        private SystemServiceDisassociatedMetadata _systemServiceDisassociated;
        private SystemUserJourneyCreatedMetadata _systemUserJourneyCreated;
        private SystemUserJourneyDeletedMetadata _systemUserJourneyDeleted;
        private SystemUserJourneyUpdatedMetadata _systemUserJourneyUpdated;

        /// <summary>
        /// Gets and sets the property SystemCreated. 
        /// <para>
        /// Metadata for a system created event.
        /// </para>
        /// </summary>
        public SystemCreatedMetadata SystemCreated
        {
            get { return this._systemCreated; }
            set { this._systemCreated = value; }
        }

        // Check to see if SystemCreated property is set
        internal bool IsSetSystemCreated()
        {
            return this._systemCreated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemDeleted. 
        /// <para>
        /// Metadata for a system deleted event.
        /// </para>
        /// </summary>
        public SystemDeletedMetadata SystemDeleted
        {
            get { return this._systemDeleted; }
            set { this._systemDeleted = value; }
        }

        // Check to see if SystemDeleted property is set
        internal bool IsSetSystemDeleted()
        {
            return this._systemDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property SystemPolicyAssociated. 
        /// <para>
        /// Metadata for a system policy associated event.
        /// </para>
        /// </summary>
        public SystemPolicyAssociatedMetadata SystemPolicyAssociated
        {
            get { return this._systemPolicyAssociated; }
            set { this._systemPolicyAssociated = value; }
        }

        // Check to see if SystemPolicyAssociated property is set
        internal bool IsSetSystemPolicyAssociated()
        {
            return this._systemPolicyAssociated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemPolicyDisassociated. 
        /// <para>
        /// Metadata for a system policy disassociated event.
        /// </para>
        /// </summary>
        public SystemPolicyDisassociatedMetadata SystemPolicyDisassociated
        {
            get { return this._systemPolicyDisassociated; }
            set { this._systemPolicyDisassociated = value; }
        }

        // Check to see if SystemPolicyDisassociated property is set
        internal bool IsSetSystemPolicyDisassociated()
        {
            return this._systemPolicyDisassociated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemServiceAssociated. 
        /// <para>
        /// Metadata for a system service associated event.
        /// </para>
        /// </summary>
        public SystemServiceAssociatedMetadata SystemServiceAssociated
        {
            get { return this._systemServiceAssociated; }
            set { this._systemServiceAssociated = value; }
        }

        // Check to see if SystemServiceAssociated property is set
        internal bool IsSetSystemServiceAssociated()
        {
            return this._systemServiceAssociated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemServiceDisassociated. 
        /// <para>
        /// Metadata for a system service disassociated event.
        /// </para>
        /// </summary>
        public SystemServiceDisassociatedMetadata SystemServiceDisassociated
        {
            get { return this._systemServiceDisassociated; }
            set { this._systemServiceDisassociated = value; }
        }

        // Check to see if SystemServiceDisassociated property is set
        internal bool IsSetSystemServiceDisassociated()
        {
            return this._systemServiceDisassociated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemUserJourneyCreated. 
        /// <para>
        /// Metadata for a system user journey created event.
        /// </para>
        /// </summary>
        public SystemUserJourneyCreatedMetadata SystemUserJourneyCreated
        {
            get { return this._systemUserJourneyCreated; }
            set { this._systemUserJourneyCreated = value; }
        }

        // Check to see if SystemUserJourneyCreated property is set
        internal bool IsSetSystemUserJourneyCreated()
        {
            return this._systemUserJourneyCreated != null;
        }

        /// <summary>
        /// Gets and sets the property SystemUserJourneyDeleted. 
        /// <para>
        /// Metadata for a system user journey deleted event.
        /// </para>
        /// </summary>
        public SystemUserJourneyDeletedMetadata SystemUserJourneyDeleted
        {
            get { return this._systemUserJourneyDeleted; }
            set { this._systemUserJourneyDeleted = value; }
        }

        // Check to see if SystemUserJourneyDeleted property is set
        internal bool IsSetSystemUserJourneyDeleted()
        {
            return this._systemUserJourneyDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property SystemUserJourneyUpdated. 
        /// <para>
        /// Metadata for a system user journey updated event.
        /// </para>
        /// </summary>
        public SystemUserJourneyUpdatedMetadata SystemUserJourneyUpdated
        {
            get { return this._systemUserJourneyUpdated; }
            set { this._systemUserJourneyUpdated = value; }
        }

        // Check to see if SystemUserJourneyUpdated property is set
        internal bool IsSetSystemUserJourneyUpdated()
        {
            return this._systemUserJourneyUpdated != null;
        }

    }
}