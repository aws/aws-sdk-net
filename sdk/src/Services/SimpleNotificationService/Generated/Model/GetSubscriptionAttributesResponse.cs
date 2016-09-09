/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Response for GetSubscriptionAttributes action.
    /// </summary>
    public partial class GetSubscriptionAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the subscription's attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SubscriptionArn</code> -- the subscription's ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TopicArn</code> -- the topic ARN that the subscription is associated with
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Owner</code> -- the AWS account ID of the subscription's owner
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConfirmationWasAuthenticated</code> -- true if the subscription confirmation
        /// request was authenticated
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeliveryPolicy</code> -- the JSON serialization of the subscription's delivery
        /// policy
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EffectiveDeliveryPolicy</code> -- the JSON serialization of the effective delivery
        /// policy that takes into account the topic delivery policy and account system defaults
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}