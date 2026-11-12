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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a Lightsail subdomain. A subdomain is the name that you choose, such as
    /// <c>mysite</c> or <c>blog.mysite</c>. Its web address is the subdomain followed by
    /// <c>amazonlightsail.com</c>, such as <c>blog.mysite.amazonlightsail.com</c>. You can
    /// associate a subdomain with a Lightsail resource to make the resource reachable at
    /// the web address.
    /// </summary>
    public partial class Subdomain
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the subdomain.
        /// </para>
        ///  
        /// <para>
        /// If you create a subdomain with a depth of 2, such as <c>blog.mysite</c>, without first
        /// creating the subdomain with a depth of 1 (<c>mysite</c>), Lightsail holds <c>mysite</c>
        /// for your account in the <c>IMPLICIT</c> state. It doesn't have an ARN until you create
        /// a subdomain with that name.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AttachedResource. 
        /// <para>
        /// An object that describes the resource that the subdomain is associated with.
        /// </para>
        ///  
        /// <para>
        /// When the subdomain is in the <c>TRANSFERRING</c> state, this is the resource that
        /// the subdomain is being moved from.
        /// </para>
        /// </summary>
        public SubdomainAttachableResource AttachedResource { get; set; }

        /// <summary>
        /// Checks to see if the AttachedResource property is set.
        /// </summary>
        internal bool IsSetAttachedResource() => this.AttachedResource != null;

        /// <summary>
        /// Gets and sets the property AttachingResource. 
        /// <para>
        /// An object that describes the resource that the subdomain is being associated with.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only when the subdomain is in the <c>ATTACHING</c> or <c>TRANSFERRING</c>
        /// state.
        /// </para>
        /// </summary>
        public SubdomainAttachableResource AttachingResource { get; set; }

        /// <summary>
        /// Checks to see if the AttachingResource property is set.
        /// </summary>
        internal bool IsSetAttachingResource() => this.AttachingResource != null;

        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// An array of objects that describe the nested subdomains of the subdomain.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only by the <c>GetSubdomains</c> action when you don't
        /// specify a subdomain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subdomain> Children { get; set; } = AWSConfigs.InitializeCollections ? new List<Subdomain>() : null;

        /// <summary>
        /// Checks to see if the Children property is set.
        /// </summary>
        internal bool IsSetChildren() => this.Children != null && (this.Children.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the subdomain was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Depth. 
        /// <para>
        /// The number of labels in the subdomain. A top-level subdomain, such as <c>mysite</c>,
        /// has a depth of <c>1</c>. A nested subdomain, such as <c>blog.mysite</c>, has a depth
        /// of <c>2</c>.
        /// </para>
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Checks to see if the Depth property is set.
        /// </summary>
        internal bool IsSetDepth() => this.Depth.HasValue;

        /// <summary>
        /// Gets and sets the property Fqdn. 
        /// <para>
        /// The web address of the subdomain, which is the subdomain followed by <c>amazonlightsail.com</c>
        /// (for example, <c>blog.mysite.amazonlightsail.com</c>).
        /// </para>
        /// </summary>
        public string Fqdn { get; set; }

        /// <summary>
        /// Checks to see if the Fqdn property is set.
        /// </summary>
        internal bool IsSetFqdn() => this.Fqdn != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the subdomain, such as the AWS Region.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property ParentFqdn. 
        /// <para>
        /// The web address of the parent subdomain (for example, <c>mysite.amazonlightsail.com</c>
        /// for <c>blog.mysite</c>).
        /// </para>
        ///  
        /// <para>
        /// This parameter isn't returned for a subdomain with a depth of 1.
        /// </para>
        /// </summary>
        public string ParentFqdn { get; set; }

        /// <summary>
        /// Checks to see if the ParentFqdn property is set.
        /// </summary>
        internal bool IsSetParentFqdn() => this.ParentFqdn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the subdomain.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> – The subdomain is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> – The subdomain couldn't be created. Delete the subdomain, and
        /// then create it again if the name is still available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNATTACHED</c> – The subdomain is ready, and isn't associated with a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ATTACHING</c> – The subdomain is being associated with a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ATTACHED</c> – The subdomain is associated with a resource, and routes traffic
        /// to it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETACHING</c> – The subdomain is being disassociated from a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSFERRING</c> – The subdomain is being moved from one resource to another resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPLICIT</c> – The subdomain is the parent of one or more nested subdomains that
        /// you created, but you didn't create the parent subdomain itself. You can't associate
        /// or delete a subdomain in this state. To use it, create it with the <c>CreateSubdomain</c>
        /// action.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubdomainState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain (for example, <c>mysite</c> or <c>blog.mysite</c>). To get the web address,
        /// use the <c>fqdn</c> parameter.
        /// </para>
        /// </summary>
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the subdomain. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Lightsail
        /// Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only by the <c>GetSubdomains</c> action when you specify
        /// a subdomain.
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
    }
}
