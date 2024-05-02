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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// A summary of configuration properties for a member.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class MemberSummary
    {
        private string _arn;
        private DateTime? _creationDate;
        private string _description;
        private string _id;
        private bool? _isOwned;
        private string _name;
        private MemberStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the member. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the member was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// The unique identifier of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property IsOwned. 
        /// <para>
        /// An indicator of whether the member is owned by your Amazon Web Services account or
        /// a different Amazon Web Services account.
        /// </para>
        /// </summary>
        public bool? IsOwned
        {
            get { return this._isOwned; }
            set { this._isOwned = value; }
        }

        // Check to see if IsOwned property is set
        internal bool IsSetIsOwned()
        {
            return this._isOwned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the member.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the member.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The Amazon Web Services account is in the process of creating a
        /// member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The member has been created and can participate in the network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> - The Amazon Web Services account attempted to create a member
        /// and creation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The member is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The member and all associated resources are in the process of being
        /// deleted. Either the Amazon Web Services account that owns the member deleted it, or
        /// the member is being deleted as the result of an <c>APPROVED</c> <c>PROPOSAL</c> to
        /// remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The member can no longer participate on the network and all associated
        /// resources are deleted. Either the Amazon Web Services account that owns the member
        /// deleted it, or the member is being deleted as the result of an <c>APPROVED</c> <c>PROPOSAL</c>
        /// to remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_KEY</c> - The member is impaired and might not function
        /// as expected because it cannot access the specified customer managed key in Key Management
        /// Service (KMS) for encryption at rest. Either the KMS key was disabled or deleted,
        /// or the grants on the key were revoked.
        /// </para>
        ///  
        /// <para>
        /// The effect of disabling or deleting a key or of revoking a grant isn't immediate.
        /// It might take some time for the member resource to discover that the key is inaccessible.
        /// When a resource is in this state, we recommend deleting and recreating the resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberStatus Status
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