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
    /// Contains the metadata about a type of event that is reported by Health. The <c>EventType</c>
    /// shows the category, service, and the event type code of the event. For example, an
    /// <c>issue</c> might be the category, <c>EC2</c> the service, and <c>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</c>
    /// the event type code.
    /// 
    ///  
    /// <para>
    /// You can use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventTypes.html">DescribeEventTypes</a>
    /// API operation to return this information about an event.
    /// </para>
    ///  
    /// <para>
    /// You can also use the Amazon CloudWatch Events console to create a rule so that you
    /// can get notified or take action when Health delivers a specific event to your Amazon
    /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/cloudwatch-events-health.html">Monitor
    /// for Health events with Amazon CloudWatch Events</a> in the <i>Health User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EventType
    {
        private EventTypeActionability _actionability;
        private EventTypeCategory _category;
        private string _code;
        private List<string> _personas = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _service;

        /// <summary>
        /// Gets and sets the property Actionability. 
        /// <para>
        /// The actionability classification of the event. Possible values are <c>ACTION_REQUIRED</c>,
        /// <c>ACTION_MAY_BE_REQUIRED</c> and <c>INFORMATIONAL</c>. Events with <c>ACTION_REQUIRED</c>
        /// actionability require customer action to resolve or mitigate the event. Events with
        /// <c>ACTION_MAY_BE_REQUIRED</c> actionability indicates that the current status is unknown
        /// or conditional and inspection is needed to determine if action is required. Events
        /// with <c>INFORMATIONAL</c> actionability are provided for awareness and do not require
        /// immediate action.
        /// </para>
        /// </summary>
        public EventTypeActionability Actionability
        {
            get { return this._actionability; }
            set { this._actionability = value; }
        }

        // Check to see if Actionability property is set
        internal bool IsSetActionability()
        {
            return this._actionability != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A list of event type category codes. Possible values are <c>issue</c>, <c>accountNotification</c>,
        /// or <c>scheduledChange</c>. Currently, the <c>investigation</c> value isn't supported
        /// at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public EventTypeCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The unique identifier for the event type. The format is <c>AWS_<i>SERVICE</i>_<i>DESCRIPTION</i>
        /// </c>; for example, <c>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Personas. 
        /// <para>
        /// A list of persona classifications that indicate the target audience for the event.
        /// Possible values are <c>OPERATIONS</c>, <c>SECURITY</c>, and <c>BILLING</c>. Events
        /// can be associated with multiple personas to indicate relevance to different teams
        /// or roles within an organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> Personas
        {
            get { return this._personas; }
            set { this._personas = value; }
        }

        // Check to see if Personas property is set
        internal bool IsSetPersonas()
        {
            return this._personas != null && (this._personas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service that is affected by the event. For example, <c>EC2</c>,
        /// <c>RDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}