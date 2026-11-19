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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// The type of Azure resource to list. Specify one type.
    /// </summary>
    public partial class AzureConnectorQuery
    {
        /// <summary>
        /// Gets and sets the property EventHubs. 
        /// <para>
        /// Lists Azure Event Hubs.
        /// </para>
        /// </summary>
        public AzureEventHubsQuery EventHubs { get; set; }

        /// <summary>
        /// Checks to see if the EventHubs property is set.
        /// </summary>
        internal bool IsSetEventHubs() => this.EventHubs != null;

        /// <summary>
        /// Gets and sets the property ManagementGroups. 
        /// <para>
        /// Lists Azure management groups.
        /// </para>
        /// </summary>
        public AzureManagementGroupsQuery ManagementGroups { get; set; }

        /// <summary>
        /// Checks to see if the ManagementGroups property is set.
        /// </summary>
        internal bool IsSetManagementGroups() => this.ManagementGroups != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Lists the Azure Regions that have resources in scope.
        /// </para>
        /// </summary>
        public AzureRegionsQuery Regions { get; set; }

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null;

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// Lists Azure resources.
        /// </para>
        /// </summary>
        public AzureResourceIdsQuery ResourceIds { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIds property is set.
        /// </summary>
        internal bool IsSetResourceIds() => this.ResourceIds != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// Lists the Azure resource types that have resources in scope.
        /// </para>
        /// </summary>
        public AzureResourceTypesQuery ResourceTypes { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null;

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// Lists Azure subscriptions.
        /// </para>
        /// </summary>
        public AzureSubscriptionsQuery Subscriptions { get; set; }

        /// <summary>
        /// Checks to see if the Subscriptions property is set.
        /// </summary>
        internal bool IsSetSubscriptions() => this.Subscriptions != null;
    }
}
