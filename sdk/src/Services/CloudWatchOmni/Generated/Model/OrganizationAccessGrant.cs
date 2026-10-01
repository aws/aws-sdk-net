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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
    /// An organization-scoped access grant.
    /// </summary>
    public partial class OrganizationAccessGrant
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private string _grantArn;
        private string _grantId;
        private AccessGrantType _grantType;
        private string _name;
        private OrganizationGrantPermission _permission;
        private OrganizationAccessGrantPrincipal _principal;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the grant was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that created the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the organization domain the grant belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string GrantArn
        {
            get { return this._grantArn; }
            set { this._grantArn = value; }
        }

        // Check to see if GrantArn property is set
        internal bool IsSetGrantArn()
        {
            return this._grantArn != null;
        }

        /// <summary>
        /// Gets and sets the property GrantId. 
        /// <para>
        /// The unique ID of the access grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GrantId
        {
            get { return this._grantId; }
            set { this._grantId = value; }
        }

        // Check to see if GrantId property is set
        internal bool IsSetGrantId()
        {
            return this._grantId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// Who manages the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessGrantType GrantType
        {
            get { return this._grantType; }
            set { this._grantType = value; }
        }

        // Check to see if GrantType property is set
        internal bool IsSetGrantType()
        {
            return this._grantType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that identifies the access grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The permission granted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationGrantPermission Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal receiving the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationAccessGrantPrincipal Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the grant was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}