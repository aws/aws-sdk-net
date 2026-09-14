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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Contains any warning codes and their count for the job.
    /// </summary>
    public partial class WarningGroup
    {
        /// <summary>
        /// Gets and sets the property Code. Warning code that identifies a specific warning in
        /// the job. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/warning_codes.html
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code.HasValue;

        /// <summary>
        /// Gets and sets the property Count. The number of times this warning occurred in the
        /// job.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;
    }
}
