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
    /// Container for the parameters to the UpdateSubdomainAssociation operation. Associates
    /// a Lightsail subdomain with a resource, disassociates it from a resource, or moves
    /// it from one resource to another resource. <para> Currently, you can associate a subdomain
    /// only with a Lightsail content delivery network (CDN) distribution. A resource can
    /// be associated with only one subdomain at a time. </para> <para> When you associate
    /// a subdomain with a distribution, Lightsail attaches the subdomain's certificate to
    /// the distribution. You can't associate a subdomain with a distribution that uses a
    /// custom domain, which is a distribution that has a Lightsail certificate attached.
    /// </para> <para> You can transfer each subdomain to another resource only once in a
    /// 24-hour period. </para> <para> The update is asynchronous. The response returns the
    /// subdomain in the <c>ATTACHING</c>, <c>DETACHING</c>, or <c>TRANSFERRING</c> state,
    /// and an operation. To check when the update is complete, use the <c>GetSubdomains</c>
    /// action. </para>
    /// </summary>
    public partial class UpdateSubdomainAssociationRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The association change to make.
        /// </para>
        ///  
        /// <para>
        /// The following actions are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASSOCIATE</c> – Associates the subdomain with the resource that you specify in
        /// the <c>targetResourceArn</c> parameter. The subdomain must be in the <c>UNATTACHED</c>
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISASSOCIATE</c> – Disassociates the subdomain from its current resource. The
        /// subdomain must be in the <c>ATTACHED</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSFER</c> – Moves the subdomain from its current resource to the resource that
        /// you specify in the <c>targetResourceArn</c> parameter. The subdomain must be in the
        /// <c>ATTACHED</c> state. You can transfer each subdomain only once in a 24-hour period.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubdomainAssociationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain to update (for example, <c>mysite</c> or <c>blog.mysite</c>), not its
        /// web address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;

        /// <summary>
        /// Gets and sets the property TargetResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to associate the subdomain with. The
        /// resource must be in your account.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when the <c>action</c> is <c>ASSOCIATE</c> or <c>TRANSFER</c>.
        /// It's ignored when the <c>action</c> is <c>DISASSOCIATE</c>.
        /// </para>
        /// </summary>
        public string TargetResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceArn property is set.
        /// </summary>
        internal bool IsSetTargetResourceArn() => this.TargetResourceArn != null;
    }
}
