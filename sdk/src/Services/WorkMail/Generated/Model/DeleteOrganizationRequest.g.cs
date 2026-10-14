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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOrganization operation. Deletes an WorkMail
    /// organization and all underlying AWS resources managed by WorkMail as part of the organization.
    /// You can choose whether to delete the associated directory. For more information, see
    /// <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
    /// an organization</a> in the <i>WorkMail Administrator Guide</i>.
    /// </summary>
    public partial class DeleteOrganizationRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeleteDirectory. 
        /// <para>
        /// If true, deletes the AWS Directory Service directory associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeleteDirectory { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDirectory property is set.
        /// </summary>
        internal bool IsSetDeleteDirectory() => this.DeleteDirectory.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteIdentityCenterApplication. 
        /// <para>
        /// Deletes IAM Identity Center application for WorkMail. This action does not affect
        /// authentication settings for any organization.
        /// </para>
        /// </summary>
        public bool? DeleteIdentityCenterApplication { get; set; }

        /// <summary>
        /// Checks to see if the DeleteIdentityCenterApplication property is set.
        /// </summary>
        internal bool IsSetDeleteIdentityCenterApplication() => this.DeleteIdentityCenterApplication.HasValue;

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Deletes a WorkMail organization even if the organization has enabled users.
        /// </para>
        /// </summary>
        public bool? ForceDelete { get; set; }

        /// <summary>
        /// Checks to see if the ForceDelete property is set.
        /// </summary>
        internal bool IsSetForceDelete() => this.ForceDelete.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;
    }
}
