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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOdbNetwork operation.
    /// Updates properties of a specified ODB network.
    /// </summary>
    public partial class UpdateOdbNetworkRequest : AmazonOdbRequest
    {
        private List<string> _crossRegionS3RestoreSourcesToDisable = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _crossRegionS3RestoreSourcesToEnable = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _displayName;
        private Access _kmsAccess;
        private string _kmsPolicyDocument;
        private string _odbNetworkId;
        private List<string> _peeredCidrsToBeAdded = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _peeredCidrsToBeRemoved = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Access _s3Access;
        private string _s3PolicyDocument;
        private Access _stsAccess;
        private string _stsPolicyDocument;
        private Access _zeroEtlAccess;

        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToDisable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to disable for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> CrossRegionS3RestoreSourcesToDisable
        {
            get { return this._crossRegionS3RestoreSourcesToDisable; }
            set { this._crossRegionS3RestoreSourcesToDisable = value; }
        }

        // Check to see if CrossRegionS3RestoreSourcesToDisable property is set
        internal bool IsSetCrossRegionS3RestoreSourcesToDisable()
        {
            return this._crossRegionS3RestoreSourcesToDisable != null && (this._crossRegionS3RestoreSourcesToDisable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToEnable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to enable for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> CrossRegionS3RestoreSourcesToEnable
        {
            get { return this._crossRegionS3RestoreSourcesToEnable; }
            set { this._crossRegionS3RestoreSourcesToEnable = value; }
        }

        // Check to see if CrossRegionS3RestoreSourcesToEnable property is set
        internal bool IsSetCrossRegionS3RestoreSourcesToEnable()
        {
            return this._crossRegionS3RestoreSourcesToEnable != null && (this._crossRegionS3RestoreSourcesToEnable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new user-friendly name of the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsAccess. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access KmsAccess
        {
            get { return this._kmsAccess; }
            set { this._kmsAccess = value; }
        }

        // Check to see if KmsAccess property is set
        internal bool IsSetKmsAccess()
        {
            return this._kmsAccess != null;
        }

        /// <summary>
        /// Gets and sets the property KmsPolicyDocument. 
        /// <para>
        /// The KMS policy document that defines permissions for key usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string KmsPolicyDocument
        {
            get { return this._kmsPolicyDocument; }
            set { this._kmsPolicyDocument = value; }
        }

        // Check to see if KmsPolicyDocument property is set
        internal bool IsSetKmsPolicyDocument()
        {
            return this._kmsPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbNetworkId
        {
            get { return this._odbNetworkId; }
            set { this._odbNetworkId = value; }
        }

        // Check to see if OdbNetworkId property is set
        internal bool IsSetOdbNetworkId()
        {
            return this._odbNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeredCidrsToBeAdded. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC that allow access to the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> PeeredCidrsToBeAdded
        {
            get { return this._peeredCidrsToBeAdded; }
            set { this._peeredCidrsToBeAdded = value; }
        }

        // Check to see if PeeredCidrsToBeAdded property is set
        internal bool IsSetPeeredCidrsToBeAdded()
        {
            return this._peeredCidrsToBeAdded != null && (this._peeredCidrsToBeAdded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PeeredCidrsToBeRemoved. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC to remove from the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> PeeredCidrsToBeRemoved
        {
            get { return this._peeredCidrsToBeRemoved; }
            set { this._peeredCidrsToBeRemoved = value; }
        }

        // Check to see if PeeredCidrsToBeRemoved property is set
        internal bool IsSetPeeredCidrsToBeRemoved()
        {
            return this._peeredCidrsToBeRemoved != null && (this._peeredCidrsToBeRemoved.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// Specifies the updated configuration for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        public Access S3Access
        {
            get { return this._s3Access; }
            set { this._s3Access = value; }
        }

        // Check to see if S3Access property is set
        internal bool IsSetS3Access()
        {
            return this._s3Access != null;
        }

        /// <summary>
        /// Gets and sets the property S3PolicyDocument. 
        /// <para>
        /// Specifies the updated endpoint policy for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string S3PolicyDocument
        {
            get { return this._s3PolicyDocument; }
            set { this._s3PolicyDocument = value; }
        }

        // Check to see if S3PolicyDocument property is set
        internal bool IsSetS3PolicyDocument()
        {
            return this._s3PolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property StsAccess. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access StsAccess
        {
            get { return this._stsAccess; }
            set { this._stsAccess = value; }
        }

        // Check to see if StsAccess property is set
        internal bool IsSetStsAccess()
        {
            return this._stsAccess != null;
        }

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The STS policy document that defines permissions for token service usage within the
        /// ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string StsPolicyDocument
        {
            get { return this._stsPolicyDocument; }
            set { this._stsPolicyDocument = value; }
        }

        // Check to see if StsPolicyDocument property is set
        internal bool IsSetStsPolicyDocument()
        {
            return this._stsPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// Specifies the updated configuration for Zero-ETL access from the ODB network.
        /// </para>
        /// </summary>
        public Access ZeroEtlAccess
        {
            get { return this._zeroEtlAccess; }
            set { this._zeroEtlAccess = value; }
        }

        // Check to see if ZeroEtlAccess property is set
        internal bool IsSetZeroEtlAccess()
        {
            return this._zeroEtlAccess != null;
        }

    }
}