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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Amazon EBS features supported by the instance type.
    /// </summary>
    public partial class EbsInfo
    {
        /// <summary>
        /// Gets and sets the property AttachmentLimitType. 
        /// <para>
        /// Indicates whether the instance type features a shared or dedicated Amazon EBS volume
        /// attachment limit. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/volume_limits.html">Amazon
        /// EBS volume limits for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public AttachmentLimitType AttachmentLimitType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentLimitType property is set.
        /// </summary>
        internal bool IsSetAttachmentLimitType() => this.AttachmentLimitType != null;

        /// <summary>
        /// Gets and sets the property EbsCards. 
        /// <para>
        /// Describes the EBS cards available for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EbsCardInfo> EbsCards { get; set; } = AWSConfigs.InitializeCollections ? new List<EbsCardInfo>() : null;

        /// <summary>
        /// Checks to see if the EbsCards property is set.
        /// </summary>
        internal bool IsSetEbsCards() => this.EbsCards != null && (this.EbsCards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EbsOptimizedInfo. 
        /// <para>
        /// Describes the optimized EBS performance for the instance type.
        /// </para>
        /// </summary>
        public EbsOptimizedInfo EbsOptimizedInfo { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimizedInfo property is set.
        /// </summary>
        internal bool IsSetEbsOptimizedInfo() => this.EbsOptimizedInfo != null;

        /// <summary>
        /// Gets and sets the property EbsOptimizedSupport. 
        /// <para>
        /// Indicates whether the instance type is Amazon EBS-optimized. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSOptimized.html">Amazon
        /// EBS-optimized instances</a> in <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public EbsOptimizedSupport EbsOptimizedSupport { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimizedSupport property is set.
        /// </summary>
        internal bool IsSetEbsOptimizedSupport() => this.EbsOptimizedSupport != null;

        /// <summary>
        /// Gets and sets the property EncryptionSupport. 
        /// <para>
        /// Indicates whether Amazon EBS encryption is supported.
        /// </para>
        /// </summary>
        public EbsEncryptionSupport EncryptionSupport { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSupport property is set.
        /// </summary>
        internal bool IsSetEncryptionSupport() => this.EncryptionSupport != null;

        /// <summary>
        /// Gets and sets the property MaximumEbsAttachments. 
        /// <para>
        /// Indicates the maximum number of Amazon EBS volumes that can be attached to the instance
        /// type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/volume_limits.html">Amazon
        /// EBS volume limits for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public int? MaximumEbsAttachments { get; set; }

        /// <summary>
        /// Checks to see if the MaximumEbsAttachments property is set.
        /// </summary>
        internal bool IsSetMaximumEbsAttachments() => this.MaximumEbsAttachments.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumEbsCards. 
        /// <para>
        /// Indicates the number of EBS cards supported by the instance type.
        /// </para>
        /// </summary>
        public int? MaximumEbsCards { get; set; }

        /// <summary>
        /// Checks to see if the MaximumEbsCards property is set.
        /// </summary>
        internal bool IsSetMaximumEbsCards() => this.MaximumEbsCards.HasValue;

        /// <summary>
        /// Gets and sets the property NvmeSupport. 
        /// <para>
        /// Indicates whether non-volatile memory express (NVMe) is supported.
        /// </para>
        /// </summary>
        public EbsNvmeSupport NvmeSupport { get; set; }

        /// <summary>
        /// Checks to see if the NvmeSupport property is set.
        /// </summary>
        internal bool IsSetNvmeSupport() => this.NvmeSupport != null;
    }
}
