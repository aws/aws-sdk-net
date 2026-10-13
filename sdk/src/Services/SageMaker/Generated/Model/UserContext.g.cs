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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the user who created or modified a SageMaker resource.
    /// </summary>
    public partial class UserContext
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain associated with the user.
        /// </para>
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property IamIdentity. 
        /// <para>
        /// The IAM Identity details associated with the user. These details are associated with
        /// model package groups, model packages, and project entities only.
        /// </para>
        /// </summary>
        public IamIdentity IamIdentity { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentity property is set.
        /// </summary>
        internal bool IsSetIamIdentity() => this.IamIdentity != null;

        /// <summary>
        /// Gets and sets the property UserProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user's profile.
        /// </para>
        /// </summary>
        public string UserProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileArn property is set.
        /// </summary>
        internal bool IsSetUserProfileArn() => this.UserProfileArn != null;

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The name of the user's profile.
        /// </para>
        /// </summary>
        public string UserProfileName { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileName property is set.
        /// </summary>
        internal bool IsSetUserProfileName() => this.UserProfileName != null;
    }
}
