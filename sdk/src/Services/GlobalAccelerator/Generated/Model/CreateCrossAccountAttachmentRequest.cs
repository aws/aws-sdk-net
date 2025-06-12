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
    /// Container for the parameters to the CreateCrossAccountAttachment operation.
    /// Create a cross-account attachment in Global Accelerator. You create a cross-account
    /// attachment to specify the <i>principals</i> who have permission to work with <i>resources</i>
    /// in accelerators in their own account. You specify, in the same attachment, the resources
    /// that are shared.
    /// 
    ///  
    /// <para>
    /// A principal can be an Amazon Web Services account number or the Amazon Resource Name
    /// (ARN) for an accelerator. For account numbers that are listed as principals, to work
    /// with a resource listed in the attachment, you must sign in to an account specified
    /// as a principal. Then, you can work with resources that are listed, with any of your
    /// accelerators. If an accelerator ARN is listed in the cross-account attachment as a
    /// principal, anyone with permission to make updates to the accelerator can work with
    /// resources that are listed in the attachment. 
    /// </para>
    ///  
    /// <para>
    /// Specify each principal and resource separately. To specify two CIDR address pools,
    /// list them individually under <c>Resources</c>, and so on. For a command line operation,
    /// for example, you might use a statement like the following:
    /// </para>
    ///  
    /// <para>
    ///  <c> "Resources": [{"Cidr": "169.254.60.0/24"},{"Cidr": "169.254.59.0/24"}]</c> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/cross-account-resources.html">
    /// Working with cross-account attachments and resources in Global Accelerator</a> in
    /// the <i> Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        private string _idempotencyToken;
        private string _name;
        private List<string> _principals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cross-account attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// Gets and sets the property Principals. 
        /// <para>
        /// The principals to include in the cross-account attachment. A principal can be an Amazon
        /// Web Services account number or the Amazon Resource Name (ARN) for an accelerator.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && (this._principals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the resources to include in the cross-account
        /// attachment. A resource can be any supported Amazon Web Services resource type for
        /// Global Accelerator or a CIDR range for a bring your own IP address (BYOIP) address
        /// pool. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Add tags for a cross-account attachment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in Global Accelerator</a> in the <i>Global Accelerator Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}