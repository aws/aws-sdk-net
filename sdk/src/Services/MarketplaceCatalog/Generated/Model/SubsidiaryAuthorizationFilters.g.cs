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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The filters that you can use with the <c>ListEntities</c> operation to filter subsidiary
    /// authorizations. You can filter by <c>EntityId</c>, <c>Status</c>, <c>ResourceId</c>,
    /// <c>ResourceName</c>, <c>Name</c>, <c>SubsidiaryAccountId</c>, <c>CreatedDate</c>,
    /// and <c>LastModifiedDate</c>. You can add only one wildcard filter in a single <c>ListEntities</c>
    /// request.
    /// </summary>
    public partial class SubsidiaryAuthorizationFilters
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// A filter that matches subsidiary authorizations by creation date.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationCreatedDateFilter CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// A filter that matches subsidiary authorizations by entity ID.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationEntityIdFilter EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// A filter that matches subsidiary authorizations by last modified date.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationLastModifiedDateFilter LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A filter that matches subsidiary authorizations by name.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationNameFilter Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// A filter that matches subsidiary authorizations by the ID of the authorized resource.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationResourceIdFilter ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// A filter that matches subsidiary authorizations by the name of the authorized resource.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationResourceNameFilter ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A filter that matches subsidiary authorizations by status.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationStatusFilter Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubsidiaryAccountId. 
        /// <para>
        /// A filter that matches subsidiary authorizations by the AWS account ID of the subsidiary
        /// account.
        /// </para>
        /// </summary>
        public SubsidiaryAuthorizationSubsidiaryAccountIdFilter SubsidiaryAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SubsidiaryAccountId property is set.
        /// </summary>
        internal bool IsSetSubsidiaryAccountId() => this.SubsidiaryAccountId != null;
    }
}
