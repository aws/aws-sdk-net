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
    /// Contains summary information about a system.
    /// </summary>
    public partial class SystemSummary
    {
        private DateTime? _createdAt;
        private string _name;
        private string _organizationId;
        private string _ouId;
        private int? _servicesCount;
        private string _systemArn;
        private string _systemId;
        private DateTime? _updatedAt;
        private int? _userJourneysCount;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the system was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=60)]
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// Displayed only if caller has access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property OuId. 
        /// <para>
        /// Displayed only if caller has access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=68)]
        public string OuId
        {
            get { return this._ouId; }
            set { this._ouId = value; }
        }

        // Check to see if OuId property is set
        internal bool IsSetOuId()
        {
            return this._ouId != null;
        }

        /// <summary>
        /// Gets and sets the property ServicesCount. 
        /// <para>
        /// The number of services in the system.
        /// </para>
        /// </summary>
        public int? ServicesCount
        {
            get { return this._servicesCount; }
            set { this._servicesCount = value; }
        }

        // Check to see if ServicesCount property is set
        internal bool IsSetServicesCount()
        {
            return this._servicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string SystemArn
        {
            get { return this._systemArn; }
            set { this._systemArn = value; }
        }

        // Check to see if SystemArn property is set
        internal bool IsSetSystemArn()
        {
            return this._systemArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        // Check to see if SystemId property is set
        internal bool IsSetSystemId()
        {
            return this._systemId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the system was last updated.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UserJourneysCount. 
        /// <para>
        /// The number of user journeys in the system.
        /// </para>
        /// </summary>
        public int? UserJourneysCount
        {
            get { return this._userJourneysCount; }
            set { this._userJourneysCount = value; }
        }

        // Check to see if UserJourneysCount property is set
        internal bool IsSetUserJourneysCount()
        {
            return this._userJourneysCount.HasValue; 
        }

    }
}