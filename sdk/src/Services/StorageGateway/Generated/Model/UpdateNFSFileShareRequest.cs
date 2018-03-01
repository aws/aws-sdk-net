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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNFSFileShare operation.
    /// Updates a file share. This operation is only supported in the file gateway type.
    /// 
    ///  <note> 
    /// <para>
    /// To leave a file share field unchanged, set the corresponding input field to null.
    /// </para>
    ///  </note> 
    /// <para>
    /// Updates the following file share setting:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Default storage class for your S3 bucket
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Metadata defaults for your S3 bucket
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Allowed NFS clients for your file share
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Squash settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Write status of your file share
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// To leave a file share field unchanged, set the corresponding input field to null.
    /// This operation is only supported in file gateways.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateNFSFileShareRequest : AmazonStorageGatewayRequest
    {
        private List<string> _clientList = new List<string>();
        private string _defaultStorageClass;
        private string _fileShareARN;
        private bool? _guessMIMETypeEnabled;
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private NFSFileShareDefaults _nfsFileShareDefaults;
        private ObjectACL _objectACL;
        private bool? _readOnly;
        private bool? _requesterPays;
        private string _squash;

        /// <summary>
        /// Gets and sets the property ClientList. 
        /// <para>
        /// The list of clients that are allowed to access the file gateway. The list must contain
        /// either valid IP addresses or valid CIDR blocks.
        /// </para>
        /// </summary>
        public List<string> ClientList
        {
            get { return this._clientList; }
            set { this._clientList = value; }
        }

        // Check to see if ClientList property is set
        internal bool IsSetClientList()
        {
            return this._clientList != null && this._clientList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultStorageClass. 
        /// <para>
        /// The default storage class for objects put into an Amazon S3 bucket by a file gateway.
        /// Possible values are S3_STANDARD or S3_STANDARD_IA. If this field is not populated,
        /// the default value S3_STANDARD is used. Optional.
        /// </para>
        /// </summary>
        public string DefaultStorageClass
        {
            get { return this._defaultStorageClass; }
            set { this._defaultStorageClass = value; }
        }

        // Check to see if DefaultStorageClass property is set
        internal bool IsSetDefaultStorageClass()
        {
            return this._defaultStorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file share to be updated. 
        /// </para>
        /// </summary>
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property GuessMIMETypeEnabled. 
        /// <para>
        /// Enables guessing of the MIME type for uploaded objects based on file extensions. Set
        /// this value to true to enable MIME type guessing, and otherwise to false. The default
        /// value is true.
        /// </para>
        /// </summary>
        public bool GuessMIMETypeEnabled
        {
            get { return this._guessMIMETypeEnabled.GetValueOrDefault(); }
            set { this._guessMIMETypeEnabled = value; }
        }

        // Check to see if GuessMIMETypeEnabled property is set
        internal bool IsSetGuessMIMETypeEnabled()
        {
            return this._guessMIMETypeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// True to use Amazon S3 server side encryption with your own AWS KMS key, or false to
        /// use a key managed by Amazon S3. Optional. 
        /// </para>
        /// </summary>
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The KMS key used for Amazon S3 server side encryption. This value can only be set
        /// when KmsEncrypted is true. Optional. 
        /// </para>
        /// </summary>
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property NFSFileShareDefaults. 
        /// <para>
        /// The default values for the file share. Optional.
        /// </para>
        /// </summary>
        public NFSFileShareDefaults NFSFileShareDefaults
        {
            get { return this._nfsFileShareDefaults; }
            set { this._nfsFileShareDefaults = value; }
        }

        // Check to see if NFSFileShareDefaults property is set
        internal bool IsSetNFSFileShareDefaults()
        {
            return this._nfsFileShareDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectACL. 
        /// <para>
        /// Sets the access control list permission for objects in the S3 bucket that a file gateway
        /// puts objects into. The default value is "private".
        /// </para>
        /// </summary>
        public ObjectACL ObjectACL
        {
            get { return this._objectACL; }
            set { this._objectACL = value; }
        }

        // Check to see if ObjectACL property is set
        internal bool IsSetObjectACL()
        {
            return this._objectACL != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Sets the write status of a file share. This value is true if the write status is read-only,
        /// and otherwise false.
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterPays. 
        /// <para>
        /// Sets who pays the cost of the request and the data download from the Amazon S3 bucket.
        /// Set this value to true if you want the requester to pay instead of the bucket owner,
        /// and otherwise to false.
        /// </para>
        /// </summary>
        public bool RequesterPays
        {
            get { return this._requesterPays.GetValueOrDefault(); }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Squash. 
        /// <para>
        /// The user mapped to anonymous user. Valid options are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "RootSquash" - Only root is mapped to anonymous user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NoSquash" - No one is mapped to anonymous user
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "AllSquash" - Everyone is mapped to anonymous user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Squash
        {
            get { return this._squash; }
            set { this._squash = value; }
        }

        // Check to see if Squash property is set
        internal bool IsSetSquash()
        {
            return this._squash != null;
        }

    }
}