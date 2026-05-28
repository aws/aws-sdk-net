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
    /// Type-specific metadata for each service event type.
    /// </summary>
    public partial class ServiceEventMetadata
    {
        private AssertionCreatedMetadata _assertionCreated;
        private AssertionDeletedMetadata _assertionDeleted;
        private AssertionUpdatedMetadata _assertionUpdated;
        private ServiceAchievabilityUpdatedMetadata _serviceAchievabilityUpdated;
        private ServiceCreatedMetadata _serviceCreated;
        private ServiceDeletedMetadata _serviceDeleted;
        private ServiceFunctionCreatedMetadata _serviceFunctionCreated;
        private ServiceFunctionDeletedMetadata _serviceFunctionDeleted;
        private ServiceFunctionResourcesAddedMetadata _serviceFunctionResourcesAdded;
        private ServiceFunctionResourcesRemovedMetadata _serviceFunctionResourcesRemoved;
        private ServiceFunctionUpdatedMetadata _serviceFunctionUpdated;
        private ServiceInputSourcesUpdatedMetadata _serviceInputSourcesUpdated;
        private ServicePolicyAssociatedMetadata _servicePolicyAssociated;
        private ServicePolicyDisassociatedMetadata _servicePolicyDisassociated;
        private ServiceResourcesAssociatedMetadata _serviceResourcesAssociated;
        private ServiceResourcesDisassociatedMetadata _serviceResourcesDisassociated;
        private ServiceSystemAssociatedMetadata _serviceSystemAssociated;
        private ServiceSystemDisassociatedMetadata _serviceSystemDisassociated;
        private ServiceWorkflowUpdatedMetadata _serviceWorkflowUpdated;

        /// <summary>
        /// Gets and sets the property AssertionCreated. 
        /// <para>
        /// Metadata for an assertion created event.
        /// </para>
        /// </summary>
        public AssertionCreatedMetadata AssertionCreated
        {
            get { return this._assertionCreated; }
            set { this._assertionCreated = value; }
        }

        // Check to see if AssertionCreated property is set
        internal bool IsSetAssertionCreated()
        {
            return this._assertionCreated != null;
        }

        /// <summary>
        /// Gets and sets the property AssertionDeleted. 
        /// <para>
        /// Metadata for an assertion deleted event.
        /// </para>
        /// </summary>
        public AssertionDeletedMetadata AssertionDeleted
        {
            get { return this._assertionDeleted; }
            set { this._assertionDeleted = value; }
        }

        // Check to see if AssertionDeleted property is set
        internal bool IsSetAssertionDeleted()
        {
            return this._assertionDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property AssertionUpdated. 
        /// <para>
        /// Metadata for an assertion updated event.
        /// </para>
        /// </summary>
        public AssertionUpdatedMetadata AssertionUpdated
        {
            get { return this._assertionUpdated; }
            set { this._assertionUpdated = value; }
        }

        // Check to see if AssertionUpdated property is set
        internal bool IsSetAssertionUpdated()
        {
            return this._assertionUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAchievabilityUpdated. 
        /// <para>
        /// Metadata for a service achievability updated event.
        /// </para>
        /// </summary>
        public ServiceAchievabilityUpdatedMetadata ServiceAchievabilityUpdated
        {
            get { return this._serviceAchievabilityUpdated; }
            set { this._serviceAchievabilityUpdated = value; }
        }

        // Check to see if ServiceAchievabilityUpdated property is set
        internal bool IsSetServiceAchievabilityUpdated()
        {
            return this._serviceAchievabilityUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCreated. 
        /// <para>
        /// Metadata for a service created event.
        /// </para>
        /// </summary>
        public ServiceCreatedMetadata ServiceCreated
        {
            get { return this._serviceCreated; }
            set { this._serviceCreated = value; }
        }

        // Check to see if ServiceCreated property is set
        internal bool IsSetServiceCreated()
        {
            return this._serviceCreated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceDeleted. 
        /// <para>
        /// Metadata for a service deleted event.
        /// </para>
        /// </summary>
        public ServiceDeletedMetadata ServiceDeleted
        {
            get { return this._serviceDeleted; }
            set { this._serviceDeleted = value; }
        }

        // Check to see if ServiceDeleted property is set
        internal bool IsSetServiceDeleted()
        {
            return this._serviceDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionCreated. 
        /// <para>
        /// Metadata for a service function created event.
        /// </para>
        /// </summary>
        public ServiceFunctionCreatedMetadata ServiceFunctionCreated
        {
            get { return this._serviceFunctionCreated; }
            set { this._serviceFunctionCreated = value; }
        }

        // Check to see if ServiceFunctionCreated property is set
        internal bool IsSetServiceFunctionCreated()
        {
            return this._serviceFunctionCreated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionDeleted. 
        /// <para>
        /// Metadata for a service function deleted event.
        /// </para>
        /// </summary>
        public ServiceFunctionDeletedMetadata ServiceFunctionDeleted
        {
            get { return this._serviceFunctionDeleted; }
            set { this._serviceFunctionDeleted = value; }
        }

        // Check to see if ServiceFunctionDeleted property is set
        internal bool IsSetServiceFunctionDeleted()
        {
            return this._serviceFunctionDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionResourcesAdded. 
        /// <para>
        /// Metadata for a service function resources added event.
        /// </para>
        /// </summary>
        public ServiceFunctionResourcesAddedMetadata ServiceFunctionResourcesAdded
        {
            get { return this._serviceFunctionResourcesAdded; }
            set { this._serviceFunctionResourcesAdded = value; }
        }

        // Check to see if ServiceFunctionResourcesAdded property is set
        internal bool IsSetServiceFunctionResourcesAdded()
        {
            return this._serviceFunctionResourcesAdded != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionResourcesRemoved. 
        /// <para>
        /// Metadata for a service function resources removed event.
        /// </para>
        /// </summary>
        public ServiceFunctionResourcesRemovedMetadata ServiceFunctionResourcesRemoved
        {
            get { return this._serviceFunctionResourcesRemoved; }
            set { this._serviceFunctionResourcesRemoved = value; }
        }

        // Check to see if ServiceFunctionResourcesRemoved property is set
        internal bool IsSetServiceFunctionResourcesRemoved()
        {
            return this._serviceFunctionResourcesRemoved != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionUpdated. 
        /// <para>
        /// Metadata for a service function updated event.
        /// </para>
        /// </summary>
        public ServiceFunctionUpdatedMetadata ServiceFunctionUpdated
        {
            get { return this._serviceFunctionUpdated; }
            set { this._serviceFunctionUpdated = value; }
        }

        // Check to see if ServiceFunctionUpdated property is set
        internal bool IsSetServiceFunctionUpdated()
        {
            return this._serviceFunctionUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInputSourcesUpdated. 
        /// <para>
        /// Metadata for a service input sources updated event.
        /// </para>
        /// </summary>
        public ServiceInputSourcesUpdatedMetadata ServiceInputSourcesUpdated
        {
            get { return this._serviceInputSourcesUpdated; }
            set { this._serviceInputSourcesUpdated = value; }
        }

        // Check to see if ServiceInputSourcesUpdated property is set
        internal bool IsSetServiceInputSourcesUpdated()
        {
            return this._serviceInputSourcesUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePolicyAssociated. 
        /// <para>
        /// Metadata for a service policy associated event.
        /// </para>
        /// </summary>
        public ServicePolicyAssociatedMetadata ServicePolicyAssociated
        {
            get { return this._servicePolicyAssociated; }
            set { this._servicePolicyAssociated = value; }
        }

        // Check to see if ServicePolicyAssociated property is set
        internal bool IsSetServicePolicyAssociated()
        {
            return this._servicePolicyAssociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePolicyDisassociated. 
        /// <para>
        /// Metadata for a service policy disassociated event.
        /// </para>
        /// </summary>
        public ServicePolicyDisassociatedMetadata ServicePolicyDisassociated
        {
            get { return this._servicePolicyDisassociated; }
            set { this._servicePolicyDisassociated = value; }
        }

        // Check to see if ServicePolicyDisassociated property is set
        internal bool IsSetServicePolicyDisassociated()
        {
            return this._servicePolicyDisassociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceResourcesAssociated. 
        /// <para>
        /// Metadata for a service resources associated event.
        /// </para>
        /// </summary>
        public ServiceResourcesAssociatedMetadata ServiceResourcesAssociated
        {
            get { return this._serviceResourcesAssociated; }
            set { this._serviceResourcesAssociated = value; }
        }

        // Check to see if ServiceResourcesAssociated property is set
        internal bool IsSetServiceResourcesAssociated()
        {
            return this._serviceResourcesAssociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceResourcesDisassociated. 
        /// <para>
        /// Metadata for a service resources disassociated event.
        /// </para>
        /// </summary>
        public ServiceResourcesDisassociatedMetadata ServiceResourcesDisassociated
        {
            get { return this._serviceResourcesDisassociated; }
            set { this._serviceResourcesDisassociated = value; }
        }

        // Check to see if ServiceResourcesDisassociated property is set
        internal bool IsSetServiceResourcesDisassociated()
        {
            return this._serviceResourcesDisassociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSystemAssociated. 
        /// <para>
        /// Metadata for a service system associated event.
        /// </para>
        /// </summary>
        public ServiceSystemAssociatedMetadata ServiceSystemAssociated
        {
            get { return this._serviceSystemAssociated; }
            set { this._serviceSystemAssociated = value; }
        }

        // Check to see if ServiceSystemAssociated property is set
        internal bool IsSetServiceSystemAssociated()
        {
            return this._serviceSystemAssociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSystemDisassociated. 
        /// <para>
        /// Metadata for a service system disassociated event.
        /// </para>
        /// </summary>
        public ServiceSystemDisassociatedMetadata ServiceSystemDisassociated
        {
            get { return this._serviceSystemDisassociated; }
            set { this._serviceSystemDisassociated = value; }
        }

        // Check to see if ServiceSystemDisassociated property is set
        internal bool IsSetServiceSystemDisassociated()
        {
            return this._serviceSystemDisassociated != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceWorkflowUpdated. 
        /// <para>
        /// Metadata for a service workflow updated event.
        /// </para>
        /// </summary>
        public ServiceWorkflowUpdatedMetadata ServiceWorkflowUpdated
        {
            get { return this._serviceWorkflowUpdated; }
            set { this._serviceWorkflowUpdated = value; }
        }

        // Check to see if ServiceWorkflowUpdated property is set
        internal bool IsSetServiceWorkflowUpdated()
        {
            return this._serviceWorkflowUpdated != null;
        }

    }
}