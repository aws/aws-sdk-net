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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
        private string _awsAccountId;
        private string _entityArn;
        private Dictionary<string, string> _entityMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _entityUrl;
        private string _entityValue;
        private string _eventArn;
        private DateTime? _lastUpdatedTime;
        private EntityStatusCode _statusCode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account number that contains the affected entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The unique identifier for the entity. Format: <c>arn:aws:health:<i>entity-region</i>:<i>aws-account</i>:entity/<i>entity-id</i>
        /// </c>. Example: <c>arn:aws:health:us-east-1:111222333444:entity/AVh5GGT7ul1arKr1sE1K</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1600)]
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property EntityMetadata. 
        /// <para>
        /// Additional metadata about the affected entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EntityMetadata
        {
            get { return this._entityMetadata; }
            set { this._entityMetadata = value; }
        }

        // Check to see if EntityMetadata property is set
        internal bool IsSetEntityMetadata()
        {
            return this._entityMetadata != null && (this._entityMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityUrl. 
        /// <para>
        /// The URL of the affected entity.
        /// </para>
        /// </summary>
        public string EntityUrl
        {
            get { return this._entityUrl; }
            set { this._entityUrl = value; }
        }

        // Check to see if EntityUrl property is set
        internal bool IsSetEntityUrl()
        {
            return this._entityUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EntityValue. 
        /// <para>
        /// The ID of the affected entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1224)]
        public string EntityValue
        {
            get { return this._entityValue; }
            set { this._entityValue = value; }
        }

        // Check to see if EntityValue property is set
        internal bool IsSetEntityValue()
        {
            return this._entityValue != null;
        }

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
        [AWSProperty(Max=1600)]
        public string EventArn
        {
            get { return this._eventArn; }
            set { this._eventArn = value; }
        }

        // Check to see if EventArn property is set
        internal bool IsSetEventArn()
        {
            return this._eventArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The most recent time that the entity was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The most recent status of the entity affected by the event. The possible values are
        /// <c>IMPAIRED</c>, <c>UNIMPAIRED</c>, and <c>UNKNOWN</c>.
        /// </para>
        /// </summary>
        public EntityStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}