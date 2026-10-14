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
    /// Provides application summary information, including the application Amazon Resource
    /// Name (ARN), name, and status.
    /// </summary>
    public partial class ApplicationSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ApplicationARN { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationARN property is set.
        /// </summary>
        internal bool IsSetApplicationARN() => this.ApplicationARN != null;

        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// For a Managed Service for Apache Flink application, the mode is <c>STREAMING</c>.
        /// For a Managed Service for Apache Flink Studio notebook, it is <c>INTERACTIVE</c>.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMode property is set.
        /// </summary>
        internal bool IsSetApplicationMode() => this.ApplicationMode != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

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
        /// Provides the current application version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? ApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetApplicationVersionId() => this.ApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The runtime environment for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeEnvironment RuntimeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeEnvironment property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironment() => this.RuntimeEnvironment != null;
    }
}
