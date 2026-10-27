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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A subscription for an Add On representing the acceptance of its terms of use and additional
    /// pricing.
    /// </summary>
    public partial class AddonSubscription
    {
        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the Add On.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property AddonSubscriptionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Add On subscription.
        /// </para>
        /// </summary>
        public string AddonSubscriptionArn { get; set; }

        /// <summary>
        /// Checks to see if the AddonSubscriptionArn property is set.
        /// </summary>
        internal bool IsSetAddonSubscriptionArn() => this.AddonSubscriptionArn != null;

        /// <summary>
        /// Gets and sets the property AddonSubscriptionId. 
        /// <para>
        /// The unique ID of the Add On subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 67)]
        public string AddonSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the AddonSubscriptionId property is set.
        /// </summary>
        internal bool IsSetAddonSubscriptionId() => this.AddonSubscriptionId != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the Add On subscription was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;
    }
}
