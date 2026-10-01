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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The default S3 Object Lock retention mode and period that you want to apply to new
    /// objects placed in the specified Amazon S3 bucket.
    /// </summary>
    public partial class AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails
    {
        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        ///  The number of days that you want to specify for the default retention period. 
        /// </para>
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// Checks to see if the Days property is set.
        /// </summary>
        internal bool IsSetDays() => this.Days.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        ///  The default Object Lock retention mode you want to apply to new objects placed in
        /// the specified bucket. 
        /// </para>
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Years. 
        /// <para>
        ///  The number of years that you want to specify for the default retention period. 
        /// </para>
        /// </summary>
        public int? Years { get; set; }

        /// <summary>
        /// Checks to see if the Years property is set.
        /// </summary>
        internal bool IsSetYears() => this.Years.HasValue;
    }
}
