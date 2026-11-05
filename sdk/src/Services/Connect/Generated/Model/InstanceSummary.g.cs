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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the instance.
    /// </summary>
    public partial class InstanceSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IdentityManagementType. 
        /// <para>
        /// The identity management type of the instance.
        /// </para>
        /// </summary>
        public DirectoryType IdentityManagementType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityManagementType property is set.
        /// </summary>
        internal bool IsSetIdentityManagementType() => this.IdentityManagementType != null;

        /// <summary>
        /// Gets and sets the property InboundCallsEnabled. 
        /// <para>
        /// Whether inbound calls are enabled.
        /// </para>
        /// </summary>
        public bool? InboundCallsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InboundCallsEnabled property is set.
        /// </summary>
        internal bool IsSetInboundCallsEnabled() => this.InboundCallsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceAccessUrl. 
        /// <para>
        /// This URL allows contact center users to access the Connect Customer admin website.
        /// </para>
        /// </summary>
        public string InstanceAccessUrl { get; set; }

        /// <summary>
        /// Checks to see if the InstanceAccessUrl property is set.
        /// </summary>
        internal bool IsSetInstanceAccessUrl() => this.InstanceAccessUrl != null;

        /// <summary>
        /// Gets and sets the property InstanceAlias. 
        /// <para>
        /// The alias of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 45)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// Checks to see if the InstanceAlias property is set.
        /// </summary>
        internal bool IsSetInstanceAlias() => this.InstanceAlias != null;

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The state of the instance.
        /// </para>
        /// </summary>
        public InstanceStatus InstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStatus property is set.
        /// </summary>
        internal bool IsSetInstanceStatus() => this.InstanceStatus != null;

        /// <summary>
        /// Gets and sets the property OutboundCallsEnabled. 
        /// <para>
        /// Whether outbound calls are enabled.
        /// </para>
        /// </summary>
        public bool? OutboundCallsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallsEnabled property is set.
        /// </summary>
        internal bool IsSetOutboundCallsEnabled() => this.OutboundCallsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role of the instance.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;
    }
}
