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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Used for filtering by a specific topic preference.
    /// </summary>
    public partial class TopicFilter
    {
        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of a topic on which you wish to apply the filter.
        /// </para>
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;

        /// <summary>
        /// Gets and sets the property UseDefaultIfPreferenceUnavailable. 
        /// <para>
        /// Notes that the default subscription status should be applied to a contact because
        /// the contact has not noted their preference for subscribing to a topic.
        /// </para>
        /// </summary>
        public bool? UseDefaultIfPreferenceUnavailable { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaultIfPreferenceUnavailable property is set.
        /// </summary>
        internal bool IsSetUseDefaultIfPreferenceUnavailable() => this.UseDefaultIfPreferenceUnavailable.HasValue;
    }
}
