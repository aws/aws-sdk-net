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

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Information about an entity that is affected by a Health event.
    /// </summary>
    public partial class AffectedEntity
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account number that contains the affected entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The unique identifier for the entity. Format: <c>arn:aws:health:<i>entity-region</i>:<i>aws-account</i>:entity/<i>entity-id</i>
        /// </c>. Example: <c>arn:aws:health:us-east-1:111222333444:entity/AVh5GGT7ul1arKr1sE1K</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1600)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityMetadata. 
        /// <para>
        /// Additional metadata about the affected entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EntityMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EntityMetadata property is set.
        /// </summary>
        internal bool IsSetEntityMetadata() => this.EntityMetadata != null && (this.EntityMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityUrl. 
        /// <para>
        /// The URL of the affected entity.
        /// </para>
        /// </summary>
        public string EntityUrl { get; set; }

        /// <summary>
        /// Checks to see if the EntityUrl property is set.
        /// </summary>
        internal bool IsSetEntityUrl() => this.EntityUrl != null;

        /// <summary>
        /// Gets and sets the property EntityValue. 
        /// <para>
        /// The ID of the affected entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1224)]
        public string EntityValue { get; set; }

        /// <summary>
        /// Checks to see if the EntityValue property is set.
        /// </summary>
        internal bool IsSetEntityValue() => this.EntityValue != null;

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The unique identifier for the event. The event ARN has the <c>arn:aws:health:<i>event-region</i>::event/<i>SERVICE</i>/<i>EVENT_TYPE_CODE</i>/<i>EVENT_TYPE_PLUS_ID</i>
        /// </c> format.
        /// </para>
        ///  
        /// <para>
        /// For example, an event ARN might look like the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-DEF456</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1600)]
        public string EventArn { get; set; }

        /// <summary>
        /// Checks to see if the EventArn property is set.
        /// </summary>
        internal bool IsSetEventArn() => this.EventArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The most recent time that the entity was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The most recent status of the entity affected by the event. The possible values are
        /// <c>IMPAIRED</c>, <c>UNIMPAIRED</c>, <c>UNKNOWN</c>, <c>PENDING</c>, and <c>RESOLVED</c>.
        /// </para>
        /// </summary>
        public EntityStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of entity tags attached to the affected entity.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, the <c>tags</c> property isn't supported.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
