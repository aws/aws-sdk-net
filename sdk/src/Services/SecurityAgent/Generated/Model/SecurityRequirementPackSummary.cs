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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains summary information about a security requirement pack.
    /// </summary>
    public partial class SecurityRequirementPackSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private ManagementType _managementType;
        private string _name;
        private string _packId;
        private SecurityRequirementPackStatus _status;
        private DateTime? _updatedAt;
        private string _vendorName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the security requirement pack was created, in UTC format.
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
        /// A description of the security requirement pack.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// The management type of the pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagementType ManagementType
        {
            get { return this._managementType; }
            set { this._managementType = value; }
        }

        // Check to see if ManagementType property is set
        internal bool IsSetManagementType()
        {
            return this._managementType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PackId. 
        /// <para>
        /// The unique identifier of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackId
        {
            get { return this._packId; }
            set { this._packId = value; }
        }

        // Check to see if PackId property is set
        internal bool IsSetPackId()
        {
            return this._packId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityRequirementPackStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the security requirement pack was last updated, in UTC format.
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

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The vendor name for AWS managed packs.
        /// </para>
        /// </summary>
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

    }
}