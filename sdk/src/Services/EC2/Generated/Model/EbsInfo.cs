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
    /// Describes the Amazon EBS features supported by the instance type.
    /// </summary>
    public partial class EbsInfo
    {
        private AttachmentLimitType _attachmentLimitType;
        private EbsOptimizedInfo _ebsOptimizedInfo;
        private EbsOptimizedSupport _ebsOptimizedSupport;
        private EbsEncryptionSupport _encryptionSupport;
        private int? _maximumEbsAttachments;
        private EbsNvmeSupport _nvmeSupport;

        /// <summary>
        /// Gets and sets the property AttachmentLimitType. 
        /// <para>
        /// Indicates whether the instance type features a shared or dedicated Amazon EBS volume
        /// attachment limit. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/volume_limits.html">Amazon
        /// EBS volume limits for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public AttachmentLimitType AttachmentLimitType
        {
            get { return this._attachmentLimitType; }
            set { this._attachmentLimitType = value; }
        }

        // Check to see if AttachmentLimitType property is set
        internal bool IsSetAttachmentLimitType()
        {
            return this._attachmentLimitType != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimizedInfo. 
        /// <para>
        /// Describes the optimized EBS performance for the instance type.
        /// </para>
        /// </summary>
        public EbsOptimizedInfo EbsOptimizedInfo
        {
            get { return this._ebsOptimizedInfo; }
            set { this._ebsOptimizedInfo = value; }
        }

        // Check to see if EbsOptimizedInfo property is set
        internal bool IsSetEbsOptimizedInfo()
        {
            return this._ebsOptimizedInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimizedSupport. 
        /// <para>
        /// Indicates whether the instance type is Amazon EBS-optimized. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSOptimized.html">Amazon
        /// EBS-optimized instances</a> in <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public EbsOptimizedSupport EbsOptimizedSupport
        {
            get { return this._ebsOptimizedSupport; }
            set { this._ebsOptimizedSupport = value; }
        }

        // Check to see if EbsOptimizedSupport property is set
        internal bool IsSetEbsOptimizedSupport()
        {
            return this._ebsOptimizedSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionSupport. 
        /// <para>
        /// Indicates whether Amazon EBS encryption is supported.
        /// </para>
        /// </summary>
        public EbsEncryptionSupport EncryptionSupport
        {
            get { return this._encryptionSupport; }
            set { this._encryptionSupport = value; }
        }

        // Check to see if EncryptionSupport property is set
        internal bool IsSetEncryptionSupport()
        {
            return this._encryptionSupport != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumEbsAttachments. 
        /// <para>
        /// Indicates the maximum number of Amazon EBS volumes that can be attached to the instance
        /// type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/volume_limits.html">Amazon
        /// EBS volume limits for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public int? MaximumEbsAttachments
        {
            get { return this._maximumEbsAttachments; }
            set { this._maximumEbsAttachments = value; }
        }

        // Check to see if MaximumEbsAttachments property is set
        internal bool IsSetMaximumEbsAttachments()
        {
            return this._maximumEbsAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NvmeSupport. 
        /// <para>
        /// Indicates whether non-volatile memory express (NVMe) is supported.
        /// </para>
        /// </summary>
        public EbsNvmeSupport NvmeSupport
        {
            get { return this._nvmeSupport; }
            set { this._nvmeSupport = value; }
        }

        // Check to see if NvmeSupport property is set
        internal bool IsSetNvmeSupport()
        {
            return this._nvmeSupport != null;
        }

    }
}