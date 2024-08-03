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
    /// Provides information to create the ID namespace association.
    /// </summary>
    public partial class IdNamespaceAssociation
    {
        private string _arn;
        private string _collaborationArn;
        private string _collaborationId;
        private DateTime? _createTime;
        private string _description;
        private string _id;
        private IdMappingConfig _idMappingConfig;
        private IdNamespaceAssociationInputReferenceConfig _inputReferenceConfig;
        private IdNamespaceAssociationInputReferenceProperties _inputReferenceProperties;
        private string _membershipArn;
        private string _membershipId;
        private string _name;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collaboration that contains this ID namespace
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string CollaborationArn
        {
            get { return this._collaborationArn; }
            set { this._collaborationArn = value; }
        }

        // Check to see if CollaborationArn property is set
        internal bool IsSetCollaborationArn()
        {
            return this._collaborationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique identifier of the collaboration that contains this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the ID namespace association was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ID namespace association.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property InputReferenceConfig. 
        /// <para>
        /// The input reference configuration for the ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdNamespaceAssociationInputReferenceConfig InputReferenceConfig
        {
            get { return this._inputReferenceConfig; }
            set { this._inputReferenceConfig = value; }
        }

        // Check to see if InputReferenceConfig property is set
        internal bool IsSetInputReferenceConfig()
        {
            return this._inputReferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputReferenceProperties. 
        /// <para>
        /// The input reference properties for the ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdNamespaceAssociationInputReferenceProperties InputReferenceProperties
        {
            get { return this._inputReferenceProperties; }
            set { this._inputReferenceProperties = value; }
        }

        // Check to see if InputReferenceProperties property is set
        internal bool IsSetInputReferenceProperties()
        {
            return this._inputReferenceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the membership resource for this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique identifier of the membership resource for this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the ID namespace association was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}