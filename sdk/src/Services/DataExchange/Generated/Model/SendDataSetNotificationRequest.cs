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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the SendDataSetNotification operation.
    /// The type of event associated with the data set.
    /// </summary>
    public partial class SendDataSetNotificationRequest : AmazonDataExchangeRequest
    {
        private string _clientToken;
        private string _comment;
        private string _dataSetId;
        private NotificationDetails _details;
        private ScopeDetails _scope;
        private NotificationType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency key for the notification, this key allows us to deduplicate notifications
        /// that are sent in quick succession erroneously.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Free-form text field for providers to add information about their notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// Affected data set of the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Extra details specific to this notification type.
        /// </para>
        /// </summary>
        public NotificationDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Affected scope of this notification such as the underlying resources affected by the
        /// notification event.
        /// </para>
        /// </summary>
        public ScopeDetails Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the notification. Describing the kind of event the notification is alerting
        /// you to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}