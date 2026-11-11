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
    /// Reserved for future use.
    /// </summary>
    public partial class SessionManagerOutputUrl
    {
        /// <summary>
        /// Gets and sets the property CloudWatchOutputUrl. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2083)]
        public string CloudWatchOutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchOutputUrl property is set.
        /// </summary>
        internal bool IsSetCloudWatchOutputUrl() => this.CloudWatchOutputUrl != null;

        /// <summary>
        /// Gets and sets the property S3OutputUrl. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2083)]
        public string S3OutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputUrl property is set.
        /// </summary>
        internal bool IsSetS3OutputUrl() => this.S3OutputUrl != null;
    }
}
