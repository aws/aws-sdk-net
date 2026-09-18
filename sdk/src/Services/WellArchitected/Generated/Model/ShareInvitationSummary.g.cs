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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A share invitation summary return object.
    /// </summary>
    public partial class ShareInvitationSummary
    {
        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN for the lens.
        /// </para>
        /// </summary>
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensName { get; set; }

        /// <summary>
        /// Checks to see if the LensName property is set.
        /// </summary>
        internal bool IsSetLensName() => this.LensName != null;

        /// <summary>
        /// Gets and sets the property PermissionType.
        /// </summary>
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The profile ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2084)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property ShareInvitationId. 
        /// <para>
        /// The ID assigned to the share invitation.
        /// </para>
        /// </summary>
        public string ShareInvitationId { get; set; }

        /// <summary>
        /// Checks to see if the ShareInvitationId property is set.
        /// </summary>
        internal bool IsSetShareInvitationId() => this.ShareInvitationId != null;

        /// <summary>
        /// Gets and sets the property ShareResourceType. 
        /// <para>
        /// The resource type of the share invitation.
        /// </para>
        /// </summary>
        public ShareResourceType ShareResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ShareResourceType property is set.
        /// </summary>
        internal bool IsSetShareResourceType() => this.ShareResourceType != null;

        /// <summary>
        /// Gets and sets the property SharedBy.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SharedBy { get; set; }

        /// <summary>
        /// Checks to see if the SharedBy property is set.
        /// </summary>
        internal bool IsSetSharedBy() => this.SharedBy != null;

        /// <summary>
        /// Gets and sets the property SharedWith.
        /// </summary>
        [AWSProperty(Min = 12, Max = 2048)]
        public string SharedWith { get; set; }

        /// <summary>
        /// Checks to see if the SharedWith property is set.
        /// </summary>
        internal bool IsSetSharedWith() => this.SharedWith != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 250)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the review template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
