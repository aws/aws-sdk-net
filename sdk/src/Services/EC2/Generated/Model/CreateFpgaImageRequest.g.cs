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
    /// Container for the parameters to the CreateFpgaImage operation. Creates an Amazon FPGA
    /// Image (AFI) from the specified design checkpoint (DCP). <para> The create operation
    /// is asynchronous. To verify that the AFI was successfully created and is ready for
    /// use, check the output logs. </para> <para> An AFI contains the FPGA bitstream that
    /// is ready to download to an FPGA. You can securely deploy an AFI on multiple FPGA-accelerated
    /// instances. For more information, see the <a href="https://github.com/aws/aws-fpga/">Amazon
    /// Web Services FPGA Hardware Development Kit</a>. </para>
    /// </summary>
    public partial class CreateFpgaImageRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the AFI.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InputStorageLocation. 
        /// <para>
        /// The location of the encrypted design checkpoint in Amazon S3. The input must be a
        /// tarball.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageLocation InputStorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the InputStorageLocation property is set.
        /// </summary>
        internal bool IsSetInputStorageLocation() => this.InputStorageLocation != null;

        /// <summary>
        /// Gets and sets the property LogsStorageLocation. 
        /// <para>
        /// The location in Amazon S3 for the output logs.
        /// </para>
        /// </summary>
        public StorageLocation LogsStorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the LogsStorageLocation property is set.
        /// </summary>
        internal bool IsSetLogsStorageLocation() => this.LogsStorageLocation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the AFI.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the FPGA image during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
