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
    /// Container for the parameters to the ListNotifications operation. Lists all Amazon
    /// DataZone notifications.
    /// </summary>
    public partial class ListNotificationsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AfterTimestamp. 
        /// <para>
        /// The time after which you want to list notifications.
        /// </para>
        /// </summary>
        public DateTime? AfterTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AfterTimestamp property is set.
        /// </summary>
        internal bool IsSetAfterTimestamp() => this.AfterTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property BeforeTimestamp. 
        /// <para>
        /// The time before which you want to list notifications.
        /// </para>
        /// </summary>
        public DateTime? BeforeTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the BeforeTimestamp property is set.
        /// </summary>
        internal bool IsSetBeforeTimestamp() => this.BeforeTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of notifications to return in a single call to <c>ListNotifications</c>.
        /// When the number of notifications to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListNotifications</c> to list the next set of notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Subjects. 
        /// <para>
        /// The subjects of notifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subjects { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subjects property is set.
        /// </summary>
        internal bool IsSetSubjects() => this.Subjects != null && (this.Subjects.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The task status of notifications.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
