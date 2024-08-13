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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Determines if a Lambda function should be invoked for a specific intent.
    /// </summary>
    public partial class FulfillmentCodeHookSettings
    {
        private bool? _active;
        private bool? _enabled;
        private FulfillmentUpdatesSpecification _fulfillmentUpdatesSpecification;
        private PostFulfillmentStatusSpecification _postFulfillmentStatusSpecification;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Determines whether the fulfillment code hook is used. When <c>active</c> is false,
        /// the code hook doesn't run.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether a Lambda function should be invoked to fulfill a specific intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FulfillmentUpdatesSpecification. 
        /// <para>
        /// Provides settings for update messages sent to the user for long-running Lambda fulfillment
        /// functions. Fulfillment updates can be used only with streaming conversations.
        /// </para>
        /// </summary>
        public FulfillmentUpdatesSpecification FulfillmentUpdatesSpecification
        {
            get { return this._fulfillmentUpdatesSpecification; }
            set { this._fulfillmentUpdatesSpecification = value; }
        }

        // Check to see if FulfillmentUpdatesSpecification property is set
        internal bool IsSetFulfillmentUpdatesSpecification()
        {
            return this._fulfillmentUpdatesSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PostFulfillmentStatusSpecification. 
        /// <para>
        /// Provides settings for messages sent to the user for after the Lambda fulfillment function
        /// completes. Post-fulfillment messages can be sent for both streaming and non-streaming
        /// conversations.
        /// </para>
        /// </summary>
        public PostFulfillmentStatusSpecification PostFulfillmentStatusSpecification
        {
            get { return this._postFulfillmentStatusSpecification; }
            set { this._postFulfillmentStatusSpecification = value; }
        }

        // Check to see if PostFulfillmentStatusSpecification property is set
        internal bool IsSetPostFulfillmentStatusSpecification()
        {
            return this._postFulfillmentStatusSpecification != null;
        }

    }
}