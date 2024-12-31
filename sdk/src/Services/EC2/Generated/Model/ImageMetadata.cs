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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the AMI.
    /// </summary>
    public partial class ImageMetadata
    {
        private string _creationDate;
        private string _deprecationTime;
        private bool? _imageAllowed;
        private string _imageId;
        private string _imageOwnerAlias;
        private bool? _isPublic;
        private string _name;
        private string _ownerId;
        private ImageState _state;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the AMI was created.
        /// </para>
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecationTime. 
        /// <para>
        /// The deprecation date and time of the AMI, in UTC, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z.
        /// </para>
        /// </summary>
        public string DeprecationTime
        {
            get { return this._deprecationTime; }
            set { this._deprecationTime = value; }
        }

        // Check to see if DeprecationTime property is set
        internal bool IsSetDeprecationTime()
        {
            return this._deprecationTime != null;
        }

        /// <summary>
        /// Gets and sets the property ImageAllowed. 
        /// <para>
        /// If <c>true</c>, the AMI satisfies the criteria for Allowed AMIs and can be discovered
        /// and used in the account. If <c>false</c>, the AMI can't be discovered or used in the
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html">Control
        /// the discovery and use of AMIs in Amazon EC2 with Allowed AMIs</a> in <i>Amazon EC2
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public bool? ImageAllowed
        {
            get { return this._imageAllowed; }
            set { this._imageAllowed = value; }
        }

        // Check to see if ImageAllowed property is set
        internal bool IsSetImageAllowed()
        {
            return this._imageAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageOwnerAlias. 
        /// <para>
        /// The alias of the AMI owner.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>amazon</c> | <c>aws-backup-vault</c> | <c>aws-marketplace</c> 
        /// </para>
        /// </summary>
        public string ImageOwnerAlias
        {
            get { return this._imageOwnerAlias; }
            set { this._imageOwnerAlias = value; }
        }

        // Check to see if ImageOwnerAlias property is set
        internal bool IsSetImageOwnerAlias()
        {
            return this._imageOwnerAlias != null;
        }

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Indicates whether the AMI has public launch permissions. A value of <c>true</c> means
        /// this AMI has public launch permissions, while <c>false</c> means it has only implicit
        /// (AMI owner) or explicit (shared with your account) launch permissions.
        /// </para>
        /// </summary>
        public bool? IsPublic
        {
            get { return this._isPublic; }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AMI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the AMI.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the AMI. If the state is <c>available</c>, the AMI is successfully
        /// registered and can be used to launch an instance.
        /// </para>
        /// </summary>
        public ImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}