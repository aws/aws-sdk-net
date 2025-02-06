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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
        private string _aggregateManagedNotificationEventArn;
        private string _arn;
        private ManagedNotificationChildEventSummary _childEvent;
        private DateTime? _creationTime;
        private string _managedNotificationConfigurationArn;
        private string _organizationalUnitId;
        private string _relatedAccount;

        /// <summary>
        /// Gets and sets the property AggregateManagedNotificationEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ManagedNotificationEvent that is associated
        /// with this <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AggregateManagedNotificationEventArn
        {
            get { return this._aggregateManagedNotificationEventArn; }
            set { this._aggregateManagedNotificationEventArn = value; }
        }

        // Check to see if AggregateManagedNotificationEventArn property is set
        internal bool IsSetAggregateManagedNotificationEventArn()
        {
            return this._aggregateManagedNotificationEventArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ChildEvent. 
        /// <para>
        /// The content of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedNotificationChildEventSummary ChildEvent
        {
            get { return this._childEvent; }
            set { this._childEvent = value; }
        }

        // Check to see if ChildEvent property is set
        internal bool IsSetChildEvent()
        {
            return this._childEvent != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedNotificationConfigurationArn
        {
            get { return this._managedNotificationConfigurationArn; }
            set { this._managedNotificationConfigurationArn = value; }
        }

        // Check to see if ManagedNotificationConfigurationArn property is set
        internal bool IsSetManagedNotificationConfigurationArn()
        {
            return this._managedNotificationConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The Organizational Unit Id that an AWS account belongs to.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account that related to the <c>ManagedNotificationChildEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedAccount
        {
            get { return this._relatedAccount; }
            set { this._relatedAccount = value; }
        }

        // Check to see if RelatedAccount property is set
        internal bool IsSetRelatedAccount()
        {
            return this._relatedAccount != null;
        }

    }
}