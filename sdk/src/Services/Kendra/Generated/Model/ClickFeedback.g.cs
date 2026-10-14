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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Gathers information about when a particular result was clicked by a user. Your application
    /// uses the <c>SubmitFeedback</c> API to provide click information.
    /// </summary>
    public partial class ClickFeedback
    {
        /// <summary>
        /// Gets and sets the property ClickTime. 
        /// <para>
        /// The Unix timestamp when the result was clicked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ClickTime { get; set; }

        /// <summary>
        /// Checks to see if the ClickTime property is set.
        /// </summary>
        internal bool IsSetClickTime() => this.ClickTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The identifier of the search result that was clicked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 73)]
        public string ResultId { get; set; }

        /// <summary>
        /// Checks to see if the ResultId property is set.
        /// </summary>
        internal bool IsSetResultId() => this.ResultId != null;
    }
}
