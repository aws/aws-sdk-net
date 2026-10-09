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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Summary of an organization access grant. Call GetDomainAccessGrantForOrganization
    /// for the full grant.
    /// </summary>
    public partial class OrganizationAccessGrantSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the access grant was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. The ID of the organization domain the grant belongs
        /// to.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property GrantArn. The Amazon Resource Name (ARN) of the access
        /// grant.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string GrantArn { get; set; }

        /// <summary>
        /// Checks to see if the GrantArn property is set.
        /// </summary>
        internal bool IsSetGrantArn() => this.GrantArn != null;

        /// <summary>
        /// Gets and sets the property GrantId. The unique ID of the access grant.
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantId { get; set; }

        /// <summary>
        /// Checks to see if the GrantId property is set.
        /// </summary>
        internal bool IsSetGrantId() => this.GrantId != null;

        /// <summary>
        /// Gets and sets the property GrantType. Who manages the grant.
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessGrantType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property Name. A name that identifies the access grant.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Permission. The permission granted.
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationGrantPermission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;

        /// <summary>
        /// Gets and sets the property Principal. The principal receiving the grant.
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationAccessGrantPrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The timestamp when the access grant was last
        /// updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
