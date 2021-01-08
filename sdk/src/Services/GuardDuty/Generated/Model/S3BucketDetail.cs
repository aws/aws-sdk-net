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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information on the S3 bucket.
    /// </summary>
    public partial class S3BucketDetail
    {
        private string _arn;
        private DateTime? _createdAt;
        private DefaultServerSideEncryption _defaultServerSideEncryption;
        private string _name;
        private Owner _owner;
        private PublicAccess _publicAccess;
        private List<Tag> _tags = new List<Tag>();
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
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
        /// The date and time the bucket was created at.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultServerSideEncryption. 
        /// <para>
        /// Describes the server side encryption method used in the S3 bucket.
        /// </para>
        /// </summary>
        public DefaultServerSideEncryption DefaultServerSideEncryption
        {
            get { return this._defaultServerSideEncryption; }
            set { this._defaultServerSideEncryption = value; }
        }

        // Check to see if DefaultServerSideEncryption property is set
        internal bool IsSetDefaultServerSideEncryption()
        {
            return this._defaultServerSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the S3 bucket.
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the S3 bucket.
        /// </para>
        /// </summary>
        public Owner Owner
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
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// Describes the public access policies that apply to the S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccess PublicAccess
        {
            get { return this._publicAccess; }
            set { this._publicAccess = value; }
        }

        // Check to see if PublicAccess property is set
        internal bool IsSetPublicAccess()
        {
            return this._publicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// All tags attached to the S3 bucket
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Describes whether the bucket is a source or destination bucket.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}