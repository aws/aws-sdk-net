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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Type-specific metadata for each system event type.
    /// </summary>
    public partial class SystemEventMetadata
    {
        /// <summary>
        /// Gets and sets the property SystemCreated. 
        /// <para>
        /// Metadata for a system created event.
        /// </para>
        /// </summary>
        public SystemCreatedMetadata SystemCreated { get; set; }

        /// <summary>
        /// Checks to see if the SystemCreated property is set.
        /// </summary>
        internal bool IsSetSystemCreated() => this.SystemCreated != null;

        /// <summary>
        /// Gets and sets the property SystemDeleted. 
        /// <para>
        /// Metadata for a system deleted event.
        /// </para>
        /// </summary>
        public SystemDeletedMetadata SystemDeleted { get; set; }

        /// <summary>
        /// Checks to see if the SystemDeleted property is set.
        /// </summary>
        internal bool IsSetSystemDeleted() => this.SystemDeleted != null;

        /// <summary>
        /// Gets and sets the property SystemPolicyAssociated. 
        /// <para>
        /// Metadata for a system policy associated event.
        /// </para>
        /// </summary>
        public SystemPolicyAssociatedMetadata SystemPolicyAssociated { get; set; }

        /// <summary>
        /// Checks to see if the SystemPolicyAssociated property is set.
        /// </summary>
        internal bool IsSetSystemPolicyAssociated() => this.SystemPolicyAssociated != null;

        /// <summary>
        /// Gets and sets the property SystemPolicyDisassociated. 
        /// <para>
        /// Metadata for a system policy disassociated event.
        /// </para>
        /// </summary>
        public SystemPolicyDisassociatedMetadata SystemPolicyDisassociated { get; set; }

        /// <summary>
        /// Checks to see if the SystemPolicyDisassociated property is set.
        /// </summary>
        internal bool IsSetSystemPolicyDisassociated() => this.SystemPolicyDisassociated != null;

        /// <summary>
        /// Gets and sets the property SystemServiceAssociated. 
        /// <para>
        /// Metadata for a system service associated event.
        /// </para>
        /// </summary>
        public SystemServiceAssociatedMetadata SystemServiceAssociated { get; set; }

        /// <summary>
        /// Checks to see if the SystemServiceAssociated property is set.
        /// </summary>
        internal bool IsSetSystemServiceAssociated() => this.SystemServiceAssociated != null;

        /// <summary>
        /// Gets and sets the property SystemServiceDisassociated. 
        /// <para>
        /// Metadata for a system service disassociated event.
        /// </para>
        /// </summary>
        public SystemServiceDisassociatedMetadata SystemServiceDisassociated { get; set; }

        /// <summary>
        /// Checks to see if the SystemServiceDisassociated property is set.
        /// </summary>
        internal bool IsSetSystemServiceDisassociated() => this.SystemServiceDisassociated != null;

        /// <summary>
        /// Gets and sets the property SystemUserJourneyCreated. 
        /// <para>
        /// Metadata for a system user journey created event.
        /// </para>
        /// </summary>
        public SystemUserJourneyCreatedMetadata SystemUserJourneyCreated { get; set; }

        /// <summary>
        /// Checks to see if the SystemUserJourneyCreated property is set.
        /// </summary>
        internal bool IsSetSystemUserJourneyCreated() => this.SystemUserJourneyCreated != null;

        /// <summary>
        /// Gets and sets the property SystemUserJourneyDeleted. 
        /// <para>
        /// Metadata for a system user journey deleted event.
        /// </para>
        /// </summary>
        public SystemUserJourneyDeletedMetadata SystemUserJourneyDeleted { get; set; }

        /// <summary>
        /// Checks to see if the SystemUserJourneyDeleted property is set.
        /// </summary>
        internal bool IsSetSystemUserJourneyDeleted() => this.SystemUserJourneyDeleted != null;

        /// <summary>
        /// Gets and sets the property SystemUserJourneyUpdated. 
        /// <para>
        /// Metadata for a system user journey updated event.
        /// </para>
        /// </summary>
        public SystemUserJourneyUpdatedMetadata SystemUserJourneyUpdated { get; set; }

        /// <summary>
        /// Checks to see if the SystemUserJourneyUpdated property is set.
        /// </summary>
        internal bool IsSetSystemUserJourneyUpdated() => this.SystemUserJourneyUpdated != null;
    }
}
