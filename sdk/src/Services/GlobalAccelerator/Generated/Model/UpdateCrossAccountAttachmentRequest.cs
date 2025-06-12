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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
    /// Container for the parameters to the UpdateCrossAccountAttachment operation.
    /// Update a cross-account attachment to add or remove principals or resources. When you
    /// update an attachment to remove a principal (account ID or accelerator) or a resource,
    /// Global Accelerator revokes the permission for specific resources. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/cross-account-resources.html">
    /// Working with cross-account attachments and resources in Global Accelerator</a> in
    /// the <i> Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        private List<string> _addPrincipals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Resource> _addResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private string _attachmentArn;
        private string _name;
        private List<string> _removePrincipals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Resource> _removeResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddPrincipals
        {
            get { return this._addPrincipals; }
            set { this._addPrincipals = value; }
        }

        // Check to see if AddPrincipals property is set
        internal bool IsSetAddPrincipals()
        {
            return this._addPrincipals != null && (this._addPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> AddResources
        {
            get { return this._addResources; }
            set { this._addResources = value; }
        }

        // Check to see if AddResources property is set
        internal bool IsSetAddResources()
        {
            return this._addResources != null && (this._addResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cross-account attachment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AttachmentArn
        {
            get { return this._attachmentArn; }
            set { this._attachmentArn = value; }
        }

        // Check to see if AttachmentArn property is set
        internal bool IsSetAttachmentArn()
        {
            return this._attachmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cross-account attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemovePrincipals
        {
            get { return this._removePrincipals; }
            set { this._removePrincipals = value; }
        }

        // Check to see if RemovePrincipals property is set
        internal bool IsSetRemovePrincipals()
        {
            return this._removePrincipals != null && (this._removePrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> RemoveResources
        {
            get { return this._removeResources; }
            set { this._removeResources = value; }
        }

        // Check to see if RemoveResources property is set
        internal bool IsSetRemoveResources()
        {
            return this._removeResources != null && (this._removeResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}