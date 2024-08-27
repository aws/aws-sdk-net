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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Subscription configuration information for an Amazon Q Business application using
    /// IAM identity federation for user management.
    /// </summary>
    public partial class AutoSubscriptionConfiguration
    {
        private AutoSubscriptionStatus _autoSubscribe;
        private SubscriptionType _defaultSubscriptionType;

        /// <summary>
        /// Gets and sets the property AutoSubscribe. 
        /// <para>
        /// Describes whether automatic subscriptions are enabled for an Amazon Q Business application
        /// using IAM identity federation for user management.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoSubscriptionStatus AutoSubscribe
        {
            get { return this._autoSubscribe; }
            set { this._autoSubscribe = value; }
        }

        // Check to see if AutoSubscribe property is set
        internal bool IsSetAutoSubscribe()
        {
            return this._autoSubscribe != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSubscriptionType. 
        /// <para>
        /// Describes the default subscription type assigned to an Amazon Q Business application
        /// using IAM identity federation for user management. If the value for <c>autoSubscribe</c>
        /// is set to <c>ENABLED</c> you must select a value for this field.
        /// </para>
        /// </summary>
        public SubscriptionType DefaultSubscriptionType
        {
            get { return this._defaultSubscriptionType; }
            set { this._defaultSubscriptionType = value; }
        }

        // Check to see if DefaultSubscriptionType property is set
        internal bool IsSetDefaultSubscriptionType()
        {
            return this._defaultSubscriptionType != null;
        }

    }
}