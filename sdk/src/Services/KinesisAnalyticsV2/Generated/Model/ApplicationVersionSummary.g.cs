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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The summary of the application version.
    /// </summary>
    public partial class ApplicationVersionSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationStatus. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationStatus ApplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatus property is set.
        /// </summary>
        internal bool IsSetApplicationStatus() => this.ApplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The ID of the application version. Managed Service for Apache Flink updates the <c>ApplicationVersionId</c>
        /// each time you update the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? ApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetApplicationVersionId() => this.ApplicationVersionId.HasValue;
    }
}
