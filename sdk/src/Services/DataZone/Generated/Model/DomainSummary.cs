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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private DomainVersion _domainVersion;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _managedAccountId;
        private string _name;
        private string _portalUrl;
        private DomainStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when a Amazon DataZone domain was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of an Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainVersion. 
        /// <para>
        /// The domain version.
        /// </para>
        /// </summary>
        public DomainVersion DomainVersion
        {
            get { return this._domainVersion; }
            set { this._domainVersion = value; }
        }

        // Check to see if DomainVersion property is set
        internal bool IsSetDomainVersion()
        {
            return this._domainVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp of when a Amazon DataZone domain was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that manages the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedAccountId
        {
            get { return this._managedAccountId; }
            set { this._managedAccountId = value; }
        }

        // Check to see if ManagedAccountId property is set
        internal bool IsSetManagedAccountId()
        {
            return this._managedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name of an Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property PortalUrl. 
        /// <para>
        /// The data portal URL for the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string PortalUrl
        {
            get { return this._portalUrl; }
            set { this._portalUrl = value; }
        }

        // Check to see if PortalUrl property is set
        internal bool IsSetPortalUrl()
        {
            return this._portalUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}