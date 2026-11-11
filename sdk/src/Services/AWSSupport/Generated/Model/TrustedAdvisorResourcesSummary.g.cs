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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Details about Amazon Web Services resources that were analyzed in a call to Trusted
    /// Advisor <a>DescribeTrustedAdvisorCheckSummaries</a>.
    /// </summary>
    public partial class TrustedAdvisorResourcesSummary
    {
        /// <summary>
        /// Gets and sets the property ResourcesFlagged. 
        /// <para>
        /// The number of Amazon Web Services resources that were flagged (listed) by the Trusted
        /// Advisor check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ResourcesFlagged { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesFlagged property is set.
        /// </summary>
        internal bool IsSetResourcesFlagged() => this.ResourcesFlagged.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesIgnored. 
        /// <para>
        /// The number of Amazon Web Services resources ignored by Trusted Advisor because information
        /// was unavailable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ResourcesIgnored { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesIgnored property is set.
        /// </summary>
        internal bool IsSetResourcesIgnored() => this.ResourcesIgnored.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesProcessed. 
        /// <para>
        /// The number of Amazon Web Services resources that were analyzed by the Trusted Advisor
        /// check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ResourcesProcessed { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesProcessed property is set.
        /// </summary>
        internal bool IsSetResourcesProcessed() => this.ResourcesProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesSuppressed. 
        /// <para>
        /// The number of Amazon Web Services resources ignored by Trusted Advisor because they
        /// were marked as suppressed by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ResourcesSuppressed { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesSuppressed property is set.
        /// </summary>
        internal bool IsSetResourcesSuppressed() => this.ResourcesSuppressed.HasValue;
    }
}
