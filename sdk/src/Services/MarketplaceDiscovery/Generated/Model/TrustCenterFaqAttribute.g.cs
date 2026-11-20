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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A frequently asked question that a trust center publishes.
    /// </summary>
    public partial class TrustCenterFaqAttribute
    {
        /// <summary>
        /// Gets and sets the property Answer. 
        /// <para>
        /// The answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string Answer { get; set; }

        /// <summary>
        /// Checks to see if the Answer property is set.
        /// </summary>
        internal bool IsSetAnswer() => this.Answer != null;

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The question.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;

        /// <summary>
        /// Gets and sets the property SubjectArea. 
        /// <para>
        /// The subject area of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SubjectArea { get; set; }

        /// <summary>
        /// Checks to see if the SubjectArea property is set.
        /// </summary>
        internal bool IsSetSubjectArea() => this.SubjectArea != null;
    }
}
