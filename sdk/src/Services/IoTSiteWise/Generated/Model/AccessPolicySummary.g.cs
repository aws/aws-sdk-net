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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an access policy that defines an identity's access to an IoT SiteWise Monitor
    /// resource.
    /// </summary>
    public partial class AccessPolicySummary
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the access policy was created, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity (an IAM Identity Center user, an IAM Identity Center group, or an IAM
        /// user).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Identity Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the access policy was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The permissions for the access policy. Note that a project <c>ADMINISTRATOR</c> is
        /// also known as a project owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The IoT SiteWise Monitor resource (a portal or project).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
