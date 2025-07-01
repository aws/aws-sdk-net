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
        private string _displayName;
        private string _odbNetworkId;
        private List<string> _peeredCidrsToBeAdded = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _peeredCidrsToBeRemoved = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Access _s3Access;
        private string _s3PolicyDocument;
        private Access _zeroEtlAccess;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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