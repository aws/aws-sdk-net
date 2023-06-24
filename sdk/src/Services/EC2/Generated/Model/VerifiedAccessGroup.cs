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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Verified Access group.
    /// </summary>
    public partial class VerifiedAccessGroup
    {
        private string _creationTime;
        private string _deletionTime;
        private string _description;
        private string _lastUpdatedTime;
        private string _owner;
        private List<Tag> _tags = new List<Tag>();
        private string _verifiedAccessGroupArn;
        private string _verifiedAccessGroupId;
        private string _verifiedAccessInstanceId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The deletion time.
        /// </para>
        /// </summary>
        public string DeletionTime
        {
            get { return this._deletionTime; }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access group.
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account number that owns the group.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupArn. 
        /// <para>
        /// The ARN of the Verified Access group.
        /// </para>
        /// </summary>
        public string VerifiedAccessGroupArn
        {
            get { return this._verifiedAccessGroupArn; }
            set { this._verifiedAccessGroupArn = value; }
        }

        // Check to see if VerifiedAccessGroupArn property is set
        internal bool IsSetVerifiedAccessGroupArn()
        {
            return this._verifiedAccessGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Verified Access group.
        /// </para>
        /// </summary>
        public string VerifiedAccessGroupId
        {
            get { return this._verifiedAccessGroupId; }
            set { this._verifiedAccessGroupId = value; }
        }

        // Check to see if VerifiedAccessGroupId property is set
        internal bool IsSetVerifiedAccessGroupId()
        {
            return this._verifiedAccessGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId
        {
            get { return this._verifiedAccessInstanceId; }
            set { this._verifiedAccessInstanceId = value; }
        }

        // Check to see if VerifiedAccessInstanceId property is set
        internal bool IsSetVerifiedAccessInstanceId()
        {
            return this._verifiedAccessInstanceId != null;
        }

    }
}