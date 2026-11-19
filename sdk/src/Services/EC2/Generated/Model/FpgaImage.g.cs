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
    /// Describes an Amazon FPGA image (AFI).
    /// </summary>
    public partial class FpgaImage
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the AFI was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataRetentionSupport. 
        /// <para>
        /// Indicates whether data retention support is enabled for the AFI.
        /// </para>
        /// </summary>
        public bool? DataRetentionSupport { get; set; }

        /// <summary>
        /// Checks to see if the DataRetentionSupport property is set.
        /// </summary>
        internal bool IsSetDataRetentionSupport() => this.DataRetentionSupport.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AFI.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FpgaImageGlobalId. 
        /// <para>
        /// The global FPGA image identifier (AGFI ID).
        /// </para>
        /// </summary>
        public string FpgaImageGlobalId { get; set; }

        /// <summary>
        /// Checks to see if the FpgaImageGlobalId property is set.
        /// </summary>
        internal bool IsSetFpgaImageGlobalId() => this.FpgaImageGlobalId != null;

        /// <summary>
        /// Gets and sets the property FpgaImageId. 
        /// <para>
        /// The FPGA image identifier (AFI ID).
        /// </para>
        /// </summary>
        public string FpgaImageId { get; set; }

        /// <summary>
        /// Checks to see if the FpgaImageId property is set.
        /// </summary>
        internal bool IsSetFpgaImageId() => this.FpgaImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types supported by the AFI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AFI.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The alias of the AFI owner. Possible values include <c>self</c>, <c>amazon</c>, and
        /// <c>aws-marketplace</c>.
        /// </para>
        /// </summary>
        public string OwnerAlias { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAlias property is set.
        /// </summary>
        internal bool IsSetOwnerAlias() => this.OwnerAlias != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the AFI.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PciId. 
        /// <para>
        /// Information about the PCI bus.
        /// </para>
        /// </summary>
        public PciId PciId { get; set; }

        /// <summary>
        /// Checks to see if the PciId property is set.
        /// </summary>
        internal bool IsSetPciId() => this.PciId != null;

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes for the AFI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Checks to see if the ProductCodes property is set.
        /// </summary>
        internal bool IsSetProductCodes() => this.ProductCodes != null && (this.ProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Public. 
        /// <para>
        /// Indicates whether the AFI is public.
        /// </para>
        /// </summary>
        public bool? Public { get; set; }

        /// <summary>
        /// Checks to see if the Public property is set.
        /// </summary>
        internal bool IsSetPublic() => this.Public.HasValue;

        /// <summary>
        /// Gets and sets the property ShellVersion. 
        /// <para>
        /// The version of the Amazon Web Services Shell that was used to create the bitstream.
        /// </para>
        /// </summary>
        public string ShellVersion { get; set; }

        /// <summary>
        /// Checks to see if the ShellVersion property is set.
        /// </summary>
        internal bool IsSetShellVersion() => this.ShellVersion != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Information about the state of the AFI.
        /// </para>
        /// </summary>
        public FpgaImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the AFI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time of the most recent update to the AFI.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
