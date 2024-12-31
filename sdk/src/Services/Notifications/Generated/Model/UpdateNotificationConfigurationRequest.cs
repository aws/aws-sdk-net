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
    /// Container for the parameters to the UpdateNotificationConfiguration operation.
    /// Updates a NotificationConfiguration.
    /// </summary>
    public partial class UpdateNotificationConfigurationRequest : AmazonNotificationsRequest
    {
        private AggregationDuration _aggregationDuration;
        private string _arn;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property AggregationDuration. 
        /// <para>
        /// The status of this NotificationConfiguration.
        /// </para>
        ///  
        /// <para>
        /// The status should always be <c>INACTIVE</c> when part of the CreateNotificationConfiguration
        /// response.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All EventRules are <c>ACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_ACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some EventRules are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can be run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All EventRules are <c>INACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This NotificationConfiguration is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only <c>GET</c> and <c>LIST</c> calls can be run.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public AggregationDuration AggregationDuration
        {
            get { return this._aggregationDuration; }
            set { this._aggregationDuration = value; }
        }

        // Check to see if AggregationDuration property is set
        internal bool IsSetAggregationDuration()
        {
            return this._aggregationDuration != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used to update the NotificationConfiguration.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the NotificationConfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the NotificationConfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}