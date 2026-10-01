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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The principal that is to be given a subscriptiong grant.
    /// </summary>
    public partial class SubscribedPrincipalInput
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The subscribed group.
        /// </para>
        /// </summary>
        public SubscribedGroupInput Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property Iam. 
        /// <para>
        /// The subscribed IAM principal.
        /// </para>
        /// </summary>
        public SubscribedIamPrincipalInput Iam { get; set; }

        /// <summary>
        /// Checks to see if the Iam property is set.
        /// </summary>
        internal bool IsSetIam() => this.Iam != null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The project that is to be given a subscription grant.
        /// </para>
        /// </summary>
        public SubscribedProjectInput Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The subscribed user.
        /// </para>
        /// </summary>
        public SubscribedUserInput User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
