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

namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSpace operation. Modifies an existing AWS
    /// re:Post Private private re:Post.
    /// </summary>
    public partial class UpdateSpaceRequest : AmazonRepostspaceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the private re:Post. This is used only to help you identify this
        /// private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the private re:Post to convert unanswered
        /// questions into AWS support tickets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of this private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property SupportedEmailDomains.
        /// </summary>
        public SupportedEmailDomainsParameters SupportedEmailDomains { get; set; }

        /// <summary>
        /// Checks to see if the SupportedEmailDomains property is set.
        /// </summary>
        internal bool IsSetSupportedEmailDomains() => this.SupportedEmailDomains != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The pricing tier of this private re:Post.
        /// </para>
        /// </summary>
        public TierLevel Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
