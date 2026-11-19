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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Controls how long the cluster that you cut over from is kept after cutover completes.
    /// Specify exactly one of <c>RetentionInHours</c> or <c>RetentionAction</c>.
    /// </summary>
    public partial class RetentionOptions
    {
        /// <summary>
        /// Gets and sets the property RetentionAction. 
        /// <para>
        /// Ends the retention period now. Valid only after cutover completes.
        /// </para>
        /// </summary>
        public RetentionAction RetentionAction { get; set; }

        /// <summary>
        /// Checks to see if the RetentionAction property is set.
        /// </summary>
        internal bool IsSetRetentionAction() => this.RetentionAction != null;

        /// <summary>
        /// Gets and sets the property RetentionInHours. 
        /// <para>
        /// The number of hours to keep the cluster that you cut over from. The retention period
        /// starts when cutover completes. The minimum is 1 hour. In an <c>UpdateClone</c> response
        /// after cutover completes, this value is the number of hours remaining in the retention
        /// period, rounded up.
        /// </para>
        /// </summary>
        public int? RetentionInHours { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInHours property is set.
        /// </summary>
        internal bool IsSetRetentionInHours() => this.RetentionInHours.HasValue;
    }
}
