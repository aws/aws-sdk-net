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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Configuration for where to deliver scheduled query results. Specifies the destination
    /// type and associated settings for result delivery.
    /// </summary>
    public partial class DestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property LookupTableConfiguration. 
        /// <para>
        /// Configuration for delivering query results to a lookup table. The query results automatically
        /// populate or refresh the specified lookup table on each scheduled execution.
        /// </para>
        /// </summary>
        public LookupTableConfiguration LookupTableConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LookupTableConfiguration property is set.
        /// </summary>
        internal bool IsSetLookupTableConfiguration() => this.LookupTableConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// Configuration for delivering query results to Amazon S3.
        /// </para>
        /// </summary>
        public S3Configuration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;
    }
}
