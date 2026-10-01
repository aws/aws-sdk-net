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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A reference to an existing custom prompt profile.
    /// </summary>
    public partial class CustomPromptProfile
    {
        /// <summary>
        /// Gets and sets the property ModelProfileId. 
        /// <para>
        /// The identifier of the model profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ModelProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ModelProfileId property is set.
        /// </summary>
        internal bool IsSetModelProfileId() => this.ModelProfileId != null;

        /// <summary>
        /// Gets and sets the property QbsAwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 15)]
        public string QbsAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the QbsAwsAccountId property is set.
        /// </summary>
        internal bool IsSetQbsAwsAccountId() => this.QbsAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
