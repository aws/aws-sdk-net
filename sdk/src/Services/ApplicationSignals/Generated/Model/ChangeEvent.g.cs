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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about a change event that occurred for a service,
    /// such as a deployment or configuration change.
    /// </summary>
    public partial class ChangeEvent
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID where this change event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ChangeEventType. 
        /// <para>
        /// The type of change event that occurred, such as <c>DEPLOYMENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeEventType ChangeEventType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeEventType property is set.
        /// </summary>
        internal bool IsSetChangeEventType() => this.ChangeEventType != null;

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity (service or resource) that was affected by this change event, including
        /// its key attributes.
        /// </para>
        ///  
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AwsAccountId</c> specifies the account where this object is in.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Below is an example of a service.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "Type": "Service", "Name": "visits-service", "Environment": "petclinic-test"
        /// }</c> 
        /// </para>
        ///  
        /// <para>
        /// Below is an example of a resource.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "Type": "AWS::Resource", "ResourceType": "AWS::DynamoDB::Table", "Identifier":
        /// "Customers" }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public Dictionary<string, string> Entity { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null && (this.Entity.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier for this change event. For CloudTrail-based events, this is the
        /// CloudTrail event id. For other events, this will be <c>Unknown</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name or description of this change event.
        /// </para>
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Checks to see if the EventName property is set.
        /// </summary>
        internal bool IsSetEventName() => this.EventName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services region where this change event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when this change event occurred. When used in a raw HTTP Query API,
        /// it is formatted as epoch time in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user who initiated this change event, if available.
        /// </para>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
