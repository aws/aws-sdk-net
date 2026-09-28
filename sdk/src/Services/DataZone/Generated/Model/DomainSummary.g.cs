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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A summary of a Amazon DataZone domain.
    /// </summary>
    public partial class DomainSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when a Amazon DataZone domain was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of an Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainVersion. 
        /// <para>
        /// The domain version.
        /// </para>
        /// </summary>
        public DomainVersion DomainVersion { get; set; }

        /// <summary>
        /// Checks to see if the DomainVersion property is set.
        /// </summary>
        internal bool IsSetDomainVersion() => this.DomainVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp of when a Amazon DataZone domain was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that manages the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManagedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedAccountId property is set.
        /// </summary>
        internal bool IsSetManagedAccountId() => this.ManagedAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name of an Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortalUrl. 
        /// <para>
        /// The data portal URL for the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string PortalUrl { get; set; }

        /// <summary>
        /// Checks to see if the PortalUrl property is set.
        /// </summary>
        internal bool IsSetPortalUrl() => this.PortalUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DomainStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
