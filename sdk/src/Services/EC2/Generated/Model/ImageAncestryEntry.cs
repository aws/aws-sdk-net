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
    /// Information about a single AMI in the ancestry chain and its source (parent) AMI.
    /// </summary>
    public partial class ImageAncestryEntry
    {
        private DateTime? _creationDate;
        private string _imageId;
        private string _imageOwnerAlias;
        private string _sourceImageId;
        private string _sourceImageRegion;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when this AMI was created.
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
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of this AMI.
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
        /// The owner alias (<c>amazon</c> | <c>aws-backup-vault</c> | <c>aws-marketplace</c>
        /// ) of this AMI, if one is assigned. Otherwise, the value is <c>null</c>.
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
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The ID of the parent AMI.
        /// </para>
        /// </summary>
        public string SourceImageId
        {
            get { return this._sourceImageId; }
            set { this._sourceImageId = value; }
        }

        // Check to see if SourceImageId property is set
        internal bool IsSetSourceImageId()
        {
            return this._sourceImageId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceImageRegion. 
        /// <para>
        /// The Amazon Web Services Region of the parent AMI.
        /// </para>
        /// </summary>
        public string SourceImageRegion
        {
            get { return this._sourceImageRegion; }
            set { this._sourceImageRegion = value; }
        }

        // Check to see if SourceImageRegion property is set
        internal bool IsSetSourceImageRegion()
        {
            return this._sourceImageRegion != null;
        }

    }
}