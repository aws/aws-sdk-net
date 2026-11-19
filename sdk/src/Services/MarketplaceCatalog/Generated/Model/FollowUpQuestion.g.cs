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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A question that you can answer to get a better recommendation, and the reason that
    /// it's asked.
    /// </summary>
    public partial class FollowUpQuestion
    {
        /// <summary>
        /// Gets and sets the property Justification. 
        /// <para>
        /// Why the question is asked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5000)]
        public string Justification { get; set; }

        /// <summary>
        /// Checks to see if the Justification property is set.
        /// </summary>
        internal bool IsSetJustification() => this.Justification != null;

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The question to answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;
    }
}
