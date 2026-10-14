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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateOdbNetwork operation. Updates properties
    /// of a specified ODB network.
    /// </summary>
    public partial class UpdateOdbNetworkRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToDisable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to disable for the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> CrossRegionS3RestoreSourcesToDisable { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionS3RestoreSourcesToDisable property is set.
        /// </summary>
        internal bool IsSetCrossRegionS3RestoreSourcesToDisable() => this.CrossRegionS3RestoreSourcesToDisable != null && (this.CrossRegionS3RestoreSourcesToDisable.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToEnable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to enable for the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> CrossRegionS3RestoreSourcesToEnable { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionS3RestoreSourcesToEnable property is set.
        /// </summary>
        internal bool IsSetCrossRegionS3RestoreSourcesToEnable() => this.CrossRegionS3RestoreSourcesToEnable != null && (this.CrossRegionS3RestoreSourcesToEnable.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new user-friendly name of the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property KmsAccess. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access KmsAccess { get; set; }

        /// <summary>
        /// Checks to see if the KmsAccess property is set.
        /// </summary>
        internal bool IsSetKmsAccess() => this.KmsAccess != null;

        /// <summary>
        /// Gets and sets the property KmsPolicyDocument. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) policy document that defines
        /// permissions for key usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string KmsPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the KmsPolicyDocument property is set.
        /// </summary>
        internal bool IsSetKmsPolicyDocument() => this.KmsPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property PeeredCidrsToBeAdded. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC that allow access to the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> PeeredCidrsToBeAdded { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeeredCidrsToBeAdded property is set.
        /// </summary>
        internal bool IsSetPeeredCidrsToBeAdded() => this.PeeredCidrsToBeAdded != null && (this.PeeredCidrsToBeAdded.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PeeredCidrsToBeRemoved. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC to remove from the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> PeeredCidrsToBeRemoved { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeeredCidrsToBeRemoved property is set.
        /// </summary>
        internal bool IsSetPeeredCidrsToBeRemoved() => this.PeeredCidrsToBeRemoved != null && (this.PeeredCidrsToBeRemoved.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// Specifies the updated configuration for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        public Access S3Access { get; set; }

        /// <summary>
        /// Checks to see if the S3Access property is set.
        /// </summary>
        internal bool IsSetS3Access() => this.S3Access != null;

        /// <summary>
        /// Gets and sets the property S3PolicyDocument. 
        /// <para>
        /// Specifies the updated endpoint policy for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string S3PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the S3PolicyDocument property is set.
        /// </summary>
        internal bool IsSetS3PolicyDocument() => this.S3PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property StsAccess. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access StsAccess { get; set; }

        /// <summary>
        /// Checks to see if the StsAccess property is set.
        /// </summary>
        internal bool IsSetStsAccess() => this.StsAccess != null;

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) policy document that defines
        /// permissions for token service usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string StsPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the StsPolicyDocument property is set.
        /// </summary>
        internal bool IsSetStsPolicyDocument() => this.StsPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// Specifies the updated configuration for Zero-ETL access from the ODB network.
        /// </para>
        /// </summary>
        public Access ZeroEtlAccess { get; set; }

        /// <summary>
        /// Checks to see if the ZeroEtlAccess property is set.
        /// </summary>
        internal bool IsSetZeroEtlAccess() => this.ZeroEtlAccess != null;
    }
}
