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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides information for updating the user on the progress of fulfilling an intent.
    /// </summary>
    public partial class FulfillmentUpdatesSpecification
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Determines whether fulfillment updates are sent to the user. When this field is true,
        /// updates are sent.
        /// </para>
        ///  
        /// <para>
        /// If the <c>active</c> field is set to true, the <c>startResponse</c>, <c>updateResponse</c>,
        /// and <c>timeoutInSeconds</c> fields are required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property StartResponse. 
        /// <para>
        /// Provides configuration information for the message sent to users when the fulfillment
        /// Lambda functions starts running.
        /// </para>
        /// </summary>
        public FulfillmentStartResponseSpecification StartResponse { get; set; }

        /// <summary>
        /// Checks to see if the StartResponse property is set.
        /// </summary>
        internal bool IsSetStartResponse() => this.StartResponse != null;

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The length of time that the fulfillment Lambda function should run before it times
        /// out.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 900)]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateResponse. 
        /// <para>
        /// Provides configuration information for messages sent periodically to the user while
        /// the fulfillment Lambda function is running.
        /// </para>
        /// </summary>
        public FulfillmentUpdateResponseSpecification UpdateResponse { get; set; }

        /// <summary>
        /// Checks to see if the UpdateResponse property is set.
        /// </summary>
        internal bool IsSetUpdateResponse() => this.UpdateResponse != null;
    }
}
