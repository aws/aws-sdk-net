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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one retry config criteria.
    /// </summary>
    public partial class RetryConfigCriteria
    {
        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// Over-the-air (OTA) retry criteria failure type.
        /// </para>
        /// </summary>
        public RetryCriteriaFailureType FailureType { get; set; }

        /// <summary>
        /// Checks to see if the FailureType property is set.
        /// </summary>
        internal bool IsSetFailureType() => this.FailureType != null;

        /// <summary>
        /// Gets and sets the property MinNumberOfRetries. 
        /// <para>
        /// The number of retries allowed for a failure type for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? MinNumberOfRetries { get; set; }

        /// <summary>
        /// Checks to see if the MinNumberOfRetries property is set.
        /// </summary>
        internal bool IsSetMinNumberOfRetries() => this.MinNumberOfRetries.HasValue;
    }
}
