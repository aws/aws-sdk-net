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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Values EventBridge manages for a subscriber that depend on its target type. Only the
    /// member for the subscriber's target type is set. Returned in responses only; the customer
    /// never supplies these values.
    /// </summary>
    public partial class SubscriberDetails
    {
        /// <summary>
        /// Gets and sets the property MskDetails. 
        /// <para>
        /// Values EventBridge manages for a subscriber that targets an Amazon MSK cluster.
        /// </para>
        /// </summary>
        public MskDetails MskDetails { get; set; }

        /// <summary>
        /// Checks to see if the MskDetails property is set.
        /// </summary>
        internal bool IsSetMskDetails() => this.MskDetails != null;
    }
}
