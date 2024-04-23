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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotifications operation.
    /// Lists all Amazon DataZone notifications.
    /// </summary>
    public partial class ListNotificationsRequest : AmazonDataZoneRequest
    {
        private DateTime? _afterTimestamp;
        private DateTime? _beforeTimestamp;
        private string _domainIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _subjects = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TaskStatus _taskStatus;
        private NotificationType _type;

        /// <summary>
        /// Gets and sets the property AfterTimestamp. 
        /// <para>
        /// The time after which you want to list notifications.
        /// </para>
        /// </summary>
        public DateTime AfterTimestamp
        {
            get { return this._afterTimestamp.GetValueOrDefault(); }
            set { this._afterTimestamp = value; }
        }

        // Check to see if AfterTimestamp property is set
        internal bool IsSetAfterTimestamp()
        {
            return this._afterTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeTimestamp. 
        /// <para>
        /// The time before which you want to list notifications.
        /// </para>
        /// </summary>
        public DateTime BeforeTimestamp
        {
            get { return this._beforeTimestamp.GetValueOrDefault(); }
            set { this._beforeTimestamp = value; }
        }

        // Check to see if BeforeTimestamp property is set
        internal bool IsSetBeforeTimestamp()
        {
            return this._beforeTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of notifications to return in a single call to <c>ListNotifications</c>.
        /// When the number of notifications to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListNotifications</c> to list the next set of notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of notifications is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of notifications, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListNotifications</c>
        /// to list the next set of notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Subjects. 
        /// <para>
        /// The subjects of notifications.
        /// </para>
        /// </summary>
        public List<string> Subjects
        {
            get { return this._subjects; }
            set { this._subjects = value; }
        }

        // Check to see if Subjects property is set
        internal bool IsSetSubjects()
        {
            return this._subjects != null && (this._subjects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The task status of notifications.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of notifications.
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