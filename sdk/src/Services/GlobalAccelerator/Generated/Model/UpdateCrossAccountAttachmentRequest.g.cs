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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCrossAccountAttachment operation. Update
    /// a cross-account attachment to add or remove principals or resources. When you update
    /// an attachment to remove a principal (account ID or accelerator) or a resource, Global
    /// Accelerator revokes the permission for specific resources. <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/cross-account-resources.html">
    /// Working with cross-account attachments and resources in Global Accelerator</a> in
    /// the <i> Global Accelerator Developer Guide</i>. </para>
    /// </summary>
    public partial class UpdateCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        /// <summary>
        /// Gets and sets the property AddPrincipals. 
        /// <para>
        /// The principals to add to the cross-account attachment. A principal is an account or
        /// the Amazon Resource Name (ARN) of an accelerator that the attachment gives permission
        /// to work with resources from another account. The resources are also listed in the
        /// attachment.
        /// </para>
        ///  
        /// <para>
        /// To add more than one principal, separate the account numbers or accelerator ARNs,
        /// or both, with commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddPrincipals property is set.
        /// </summary>
        internal bool IsSetAddPrincipals() => this.AddPrincipals != null && (this.AddPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddResources. 
        /// <para>
        /// The resources to add to the cross-account attachment. A resource listed in a cross-account
        /// attachment can be used with an accelerator by the principals that are listed in the
        /// attachment.
        /// </para>
        ///  
        /// <para>
        /// To add more than one resource, separate the resource ARNs with commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> AddResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the AddResources property is set.
        /// </summary>
        internal bool IsSetAddResources() => this.AddResources != null && (this.AddResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cross-account attachment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string AttachmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentArn property is set.
        /// </summary>
        internal bool IsSetAttachmentArn() => this.AttachmentArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cross-account attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RemovePrincipals. 
        /// <para>
        /// The principals to remove from the cross-account attachment. A principal is an account
        /// or the Amazon Resource Name (ARN) of an accelerator that the attachment gives permission
        /// to work with resources from another account. The resources are also listed in the
        /// attachment.
        /// </para>
        ///  
        /// <para>
        /// To remove more than one principal, separate the account numbers or accelerator ARNs,
        /// or both, with commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemovePrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemovePrincipals property is set.
        /// </summary>
        internal bool IsSetRemovePrincipals() => this.RemovePrincipals != null && (this.RemovePrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveResources. 
        /// <para>
        /// The resources to remove from the cross-account attachment. A resource listed in a
        /// cross-account attachment can be used with an accelerator by the principals that are
        /// listed in the attachment.
        /// </para>
        ///  
        /// <para>
        /// To remove more than one resource, separate the resource ARNs with commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RemoveResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the RemoveResources property is set.
        /// </summary>
        internal bool IsSetRemoveResources() => this.RemoveResources != null && (this.RemoveResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
