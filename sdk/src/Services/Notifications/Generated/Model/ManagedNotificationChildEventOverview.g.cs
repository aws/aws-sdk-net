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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes an overview and metadata for a <c>ManagedNotificationChildEvent</c>.
    /// </summary>
    public partial class ManagedNotificationChildEventOverview
    {
        /// <summary>
        /// Gets and sets the property AggregateManagedNotificationEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ManagedNotificationEvent that is associated
        /// with this <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AggregateManagedNotificationEventArn { get; set; }

        /// <summary>
        /// Checks to see if the AggregateManagedNotificationEventArn property is set.
        /// </summary>
        internal bool IsSetAggregateManagedNotificationEventArn() => this.AggregateManagedNotificationEventArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChildEvent. 
        /// <para>
        /// The content of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagedNotificationChildEventSummary ChildEvent { get; set; }

        /// <summary>
        /// Checks to see if the ChildEvent property is set.
        /// </summary>
        internal bool IsSetChildEvent() => this.ChildEvent != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManagedNotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedNotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetManagedNotificationConfigurationArn() => this.ManagedNotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The Organizational Unit Id that an AWS account belongs to.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account that related to the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelatedAccount { get; set; }

        /// <summary>
        /// Checks to see if the RelatedAccount property is set.
        /// </summary>
        internal bool IsSetRelatedAccount() => this.RelatedAccount != null;
    }
}
