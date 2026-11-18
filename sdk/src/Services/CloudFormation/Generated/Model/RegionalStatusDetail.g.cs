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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains the progress detail for a single Region of a StackSet operation. This information
    /// is returned only by <a>DescribeStackSetOperation</a>.
    /// </summary>
    public partial class RegionalStatusDetail
    {
        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// The progress information for the individual stages of the operation in this Region.
        /// </para>
        /// </summary>
        public RegionalStages Stages { get; set; }

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null;
    }
}
