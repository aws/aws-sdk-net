/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes an SSM document.
    /// </summary>
    public partial class DocumentDescription
    {
        private DateTime? _createdDate;
        private string _description;
        private string _hash;
        private DocumentHashType _hashType;
        private string _name;
        private string _owner;
        private List<DocumentParameter> _parameters = new List<DocumentParameter>();
        private List<string> _platformTypes = new List<string>();
        private string _sha1;
        private DocumentStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        ///  The date when the SSM document was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the document. 
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
        /// Gets and sets the property Hash. 
        /// <para>
        /// The Sha256 or Sha1 hash created by the system when the document was created. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public string Hash
        {
            get { return this._hash; }
            set { this._hash = value; }
        }

        // Check to see if Hash property is set
        internal bool IsSetHash()
        {
            return this._hash != null;
        }

        /// <summary>
        /// Gets and sets the property HashType. 
        /// <para>
        /// Sha256 or Sha1.
        /// </para>
        ///  <note> 
        /// <para>
        /// Sha1 hashes have been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        public DocumentHashType HashType
        {
            get { return this._hashType; }
            set { this._hashType = value; }
        }

        // Check to see if HashType property is set
        internal bool IsSetHashType()
        {
            return this._hashType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
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
        /// The AWS user account of the person who created the document.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A description of the parameters for a document.
        /// </para>
        /// </summary>
        public List<DocumentParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformTypes. 
        /// <para>
        /// The list of OS platforms compatible with this SSM document. 
        /// </para>
        /// </summary>
        public List<string> PlatformTypes
        {
            get { return this._platformTypes; }
            set { this._platformTypes = value; }
        }

        // Check to see if PlatformTypes property is set
        internal bool IsSetPlatformTypes()
        {
            return this._platformTypes != null && this._platformTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sha1. 
        /// <para>
        /// The SHA1 hash of the document, which you can use for verification purposes.
        /// </para>
        /// </summary>
        public string Sha1
        {
            get { return this._sha1; }
            set { this._sha1 = value; }
        }

        // Check to see if Sha1 property is set
        internal bool IsSetSha1()
        {
            return this._sha1 != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSM document.
        /// </para>
        /// </summary>
        public DocumentStatus Status
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