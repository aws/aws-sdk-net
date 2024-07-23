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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIdNamespaceAssociation operation.
    /// Provides the details that are necessary to update an ID namespace association.
    /// </summary>
    public partial class UpdateIdNamespaceAssociationRequest : AmazonCleanRoomsRequest
    {
        private string _description;
        private IdMappingConfig _idMappingConfig;
        private string _idNamespaceAssociationIdentifier;
        private string _membershipIdentifier;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property IdMappingConfig. 
        /// <para>
        /// The configuration settings for the ID mapping table.
        /// </para>
        /// </summary>
        public IdMappingConfig IdMappingConfig
        {
            get { return this._idMappingConfig; }
            set { this._idMappingConfig = value; }
        }

        // Check to see if IdMappingConfig property is set
        internal bool IsSetIdMappingConfig()
        {
            return this._idMappingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IdNamespaceAssociationIdentifier. 
        /// <para>
        /// The unique identifier of the ID namespace association that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IdNamespaceAssociationIdentifier
        {
            get { return this._idNamespaceAssociationIdentifier; }
            set { this._idNamespaceAssociationIdentifier = value; }
        }

        // Check to see if IdNamespaceAssociationIdentifier property is set
        internal bool IsSetIdNamespaceAssociationIdentifier()
        {
            return this._idNamespaceAssociationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the ID namespace association
        /// that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

    }
}