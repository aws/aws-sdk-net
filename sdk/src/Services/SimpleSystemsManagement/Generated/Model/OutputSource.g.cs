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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the source where the association execution details are stored.
    /// </summary>
    public partial class OutputSource
    {
        /// <summary>
        /// Gets and sets the property OutputSourceId. 
        /// <para>
        /// The ID of the output source, for example the URL of an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string OutputSourceId { get; set; }

        /// <summary>
        /// Checks to see if the OutputSourceId property is set.
        /// </summary>
        internal bool IsSetOutputSourceId() => this.OutputSourceId != null;

        /// <summary>
        /// Gets and sets the property OutputSourceType. 
        /// <para>
        /// The type of source where the association execution details are stored, for example,
        /// Amazon S3.
        /// </para>
        /// </summary>
        public string OutputSourceType { get; set; }

        /// <summary>
        /// Checks to see if the OutputSourceType property is set.
        /// </summary>
        internal bool IsSetOutputSourceType() => this.OutputSourceType != null;
    }
}
