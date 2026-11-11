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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Detailed information about an activity type.
    /// </summary>
    public partial class ActivityTypeInfo
    {
        /// <summary>
        /// Gets and sets the property ActivityType. 
        /// <para>
        /// The <a>ActivityType</a> type structure representing the activity type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Checks to see if the ActivityType property is set.
        /// </summary>
        internal bool IsSetActivityType() => this.ActivityType != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time this activity type was created through <a>RegisterActivityType</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// If DEPRECATED, the date and time <a>DeprecateActivityType</a> was called.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the activity type provided in <a>RegisterActivityType</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the activity type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
