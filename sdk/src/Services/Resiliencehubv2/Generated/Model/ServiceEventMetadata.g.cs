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
    /// Type-specific metadata for each service event type.
    /// </summary>
    public partial class ServiceEventMetadata
    {
        /// <summary>
        /// Gets and sets the property AssertionCreated. 
        /// <para>
        /// Metadata for an assertion created event.
        /// </para>
        /// </summary>
        public AssertionCreatedMetadata AssertionCreated { get; set; }

        /// <summary>
        /// Checks to see if the AssertionCreated property is set.
        /// </summary>
        internal bool IsSetAssertionCreated() => this.AssertionCreated != null;

        /// <summary>
        /// Gets and sets the property AssertionDeleted. 
        /// <para>
        /// Metadata for an assertion deleted event.
        /// </para>
        /// </summary>
        public AssertionDeletedMetadata AssertionDeleted { get; set; }

        /// <summary>
        /// Checks to see if the AssertionDeleted property is set.
        /// </summary>
        internal bool IsSetAssertionDeleted() => this.AssertionDeleted != null;

        /// <summary>
        /// Gets and sets the property AssertionUpdated. 
        /// <para>
        /// Metadata for an assertion updated event.
        /// </para>
        /// </summary>
        public AssertionUpdatedMetadata AssertionUpdated { get; set; }

        /// <summary>
        /// Checks to see if the AssertionUpdated property is set.
        /// </summary>
        internal bool IsSetAssertionUpdated() => this.AssertionUpdated != null;

        /// <summary>
        /// Gets and sets the property ServiceAchievabilityUpdated. 
        /// <para>
        /// Metadata for a service achievability updated event.
        /// </para>
        /// </summary>
        public ServiceAchievabilityUpdatedMetadata ServiceAchievabilityUpdated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAchievabilityUpdated property is set.
        /// </summary>
        internal bool IsSetServiceAchievabilityUpdated() => this.ServiceAchievabilityUpdated != null;

        /// <summary>
        /// Gets and sets the property ServiceCreated. 
        /// <para>
        /// Metadata for a service created event.
        /// </para>
        /// </summary>
        public ServiceCreatedMetadata ServiceCreated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCreated property is set.
        /// </summary>
        internal bool IsSetServiceCreated() => this.ServiceCreated != null;

        /// <summary>
        /// Gets and sets the property ServiceDeleted. 
        /// <para>
        /// Metadata for a service deleted event.
        /// </para>
        /// </summary>
        public ServiceDeletedMetadata ServiceDeleted { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDeleted property is set.
        /// </summary>
        internal bool IsSetServiceDeleted() => this.ServiceDeleted != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctionCreated. 
        /// <para>
        /// Metadata for a service function created event.
        /// </para>
        /// </summary>
        public ServiceFunctionCreatedMetadata ServiceFunctionCreated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceFunctionCreated property is set.
        /// </summary>
        internal bool IsSetServiceFunctionCreated() => this.ServiceFunctionCreated != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctionDeleted. 
        /// <para>
        /// Metadata for a service function deleted event.
        /// </para>
        /// </summary>
        public ServiceFunctionDeletedMetadata ServiceFunctionDeleted { get; set; }

        /// <summary>
        /// Checks to see if the ServiceFunctionDeleted property is set.
        /// </summary>
        internal bool IsSetServiceFunctionDeleted() => this.ServiceFunctionDeleted != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctionResourcesAdded. 
        /// <para>
        /// Metadata for a service function resources added event.
        /// </para>
        /// </summary>
        public ServiceFunctionResourcesAddedMetadata ServiceFunctionResourcesAdded { get; set; }

        /// <summary>
        /// Checks to see if the ServiceFunctionResourcesAdded property is set.
        /// </summary>
        internal bool IsSetServiceFunctionResourcesAdded() => this.ServiceFunctionResourcesAdded != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctionResourcesRemoved. 
        /// <para>
        /// Metadata for a service function resources removed event.
        /// </para>
        /// </summary>
        public ServiceFunctionResourcesRemovedMetadata ServiceFunctionResourcesRemoved { get; set; }

        /// <summary>
        /// Checks to see if the ServiceFunctionResourcesRemoved property is set.
        /// </summary>
        internal bool IsSetServiceFunctionResourcesRemoved() => this.ServiceFunctionResourcesRemoved != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctionUpdated. 
        /// <para>
        /// Metadata for a service function updated event.
        /// </para>
        /// </summary>
        public ServiceFunctionUpdatedMetadata ServiceFunctionUpdated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceFunctionUpdated property is set.
        /// </summary>
        internal bool IsSetServiceFunctionUpdated() => this.ServiceFunctionUpdated != null;

        /// <summary>
        /// Gets and sets the property ServiceInputSourcesUpdated. 
        /// <para>
        /// Metadata for a service input sources updated event.
        /// </para>
        /// </summary>
        public ServiceInputSourcesUpdatedMetadata ServiceInputSourcesUpdated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInputSourcesUpdated property is set.
        /// </summary>
        internal bool IsSetServiceInputSourcesUpdated() => this.ServiceInputSourcesUpdated != null;

        /// <summary>
        /// Gets and sets the property ServicePolicyAssociated. 
        /// <para>
        /// Metadata for a service policy associated event.
        /// </para>
        /// </summary>
        public ServicePolicyAssociatedMetadata ServicePolicyAssociated { get; set; }

        /// <summary>
        /// Checks to see if the ServicePolicyAssociated property is set.
        /// </summary>
        internal bool IsSetServicePolicyAssociated() => this.ServicePolicyAssociated != null;

        /// <summary>
        /// Gets and sets the property ServicePolicyDisassociated. 
        /// <para>
        /// Metadata for a service policy disassociated event.
        /// </para>
        /// </summary>
        public ServicePolicyDisassociatedMetadata ServicePolicyDisassociated { get; set; }

        /// <summary>
        /// Checks to see if the ServicePolicyDisassociated property is set.
        /// </summary>
        internal bool IsSetServicePolicyDisassociated() => this.ServicePolicyDisassociated != null;

        /// <summary>
        /// Gets and sets the property ServiceResourcesAssociated. 
        /// <para>
        /// Metadata for a service resources associated event.
        /// </para>
        /// </summary>
        public ServiceResourcesAssociatedMetadata ServiceResourcesAssociated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceResourcesAssociated property is set.
        /// </summary>
        internal bool IsSetServiceResourcesAssociated() => this.ServiceResourcesAssociated != null;

        /// <summary>
        /// Gets and sets the property ServiceResourcesDisassociated. 
        /// <para>
        /// Metadata for a service resources disassociated event.
        /// </para>
        /// </summary>
        public ServiceResourcesDisassociatedMetadata ServiceResourcesDisassociated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceResourcesDisassociated property is set.
        /// </summary>
        internal bool IsSetServiceResourcesDisassociated() => this.ServiceResourcesDisassociated != null;

        /// <summary>
        /// Gets and sets the property ServiceSystemAssociated. 
        /// <para>
        /// Metadata for a service system associated event.
        /// </para>
        /// </summary>
        public ServiceSystemAssociatedMetadata ServiceSystemAssociated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSystemAssociated property is set.
        /// </summary>
        internal bool IsSetServiceSystemAssociated() => this.ServiceSystemAssociated != null;

        /// <summary>
        /// Gets and sets the property ServiceSystemDisassociated. 
        /// <para>
        /// Metadata for a service system disassociated event.
        /// </para>
        /// </summary>
        public ServiceSystemDisassociatedMetadata ServiceSystemDisassociated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSystemDisassociated property is set.
        /// </summary>
        internal bool IsSetServiceSystemDisassociated() => this.ServiceSystemDisassociated != null;

        /// <summary>
        /// Gets and sets the property ServiceWorkflowUpdated. 
        /// <para>
        /// Metadata for a service workflow updated event.
        /// </para>
        /// </summary>
        public ServiceWorkflowUpdatedMetadata ServiceWorkflowUpdated { get; set; }

        /// <summary>
        /// Checks to see if the ServiceWorkflowUpdated property is set.
        /// </summary>
        internal bool IsSetServiceWorkflowUpdated() => this.ServiceWorkflowUpdated != null;
    }
}
