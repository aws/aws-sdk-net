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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An activation registers one or more on-premises servers or virtual machines (VMs)
    /// with Amazon Web Services so that you can configure those servers or VMs using Run
    /// Command. A server or VM that has been registered with Amazon Web Services Systems
    /// Manager is called a managed node.
    /// </summary>
    public partial class Activation
    {
        private string _activationId;
        private DateTime? _createdDate;
        private string _defaultInstanceName;
        private string _description;
        private DateTime? _expirationDate;
        private bool? _expired;
        private string _iamRole;
        private int? _registrationLimit;
        private int? _registrationsCount;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The ID created by Systems Manager when you submitted the activation.
        /// </para>
        /// </summary>
        public string ActivationId
        {
            get { return this._activationId; }
            set { this._activationId = value; }
        }

        // Check to see if ActivationId property is set
        internal bool IsSetActivationId()
        {
            return this._activationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the activation was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultInstanceName. 
        /// <para>
        /// A name for the managed node when it is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DefaultInstanceName
        {
            get { return this._defaultInstanceName; }
            set { this._defaultInstanceName = value; }
        }

        // Check to see if DefaultInstanceName property is set
        internal bool IsSetDefaultInstanceName()
        {
            return this._defaultInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user defined description of the activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when this activation can no longer be used to register managed nodes.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        /// Whether or not the activation is expired.
        /// </para>
        /// </summary>
        public bool? Expired
        {
            get { return this._expired; }
            set { this._expired = value; }
        }

        // Check to see if Expired property is set
        internal bool IsSetExpired()
        {
            return this._expired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The Identity and Access Management (IAM) role to assign to the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationLimit. 
        /// <para>
        /// The maximum number of managed nodes that can be registered using this activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? RegistrationLimit
        {
            get { return this._registrationLimit; }
            set { this._registrationLimit = value; }
        }

        // Check to see if RegistrationLimit property is set
        internal bool IsSetRegistrationLimit()
        {
            return this._registrationLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationsCount. 
        /// <para>
        /// The number of managed nodes already registered with this activation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? RegistrationsCount
        {
            get { return this._registrationsCount; }
            set { this._registrationsCount = value; }
        }

        // Check to see if RegistrationsCount property is set
        internal bool IsSetRegistrationsCount()
        {
            return this._registrationsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the activation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}