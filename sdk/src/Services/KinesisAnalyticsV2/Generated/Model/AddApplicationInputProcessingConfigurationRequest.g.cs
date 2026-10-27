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
    /// Container for the parameters to the AddApplicationInputProcessingConfiguration operation.
    /// Adds an <a>InputProcessingConfiguration</a> to a SQL-based Kinesis Data Analytics
    /// application. An input processor pre-processes records on the input stream before the
    /// application's SQL code executes. Currently, the only input processor available is
    /// <a href="https://docs.aws.amazon.com/lambda/">Amazon Lambda</a>.
    /// </summary>
    public partial class AddApplicationInputProcessingConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to which you want to add the input processing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version of the application to which you want to add the input processing configuration.
        /// You can use the <a>DescribeApplication</a> operation to get the current application
        /// version. If the version specified is not the current version, the <c>ConcurrentModificationException</c>
        /// is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? CurrentApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersionId() => this.CurrentApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// The ID of the input configuration to add the input processing configuration to. You
        /// can get a list of the input IDs for an application using the <a>DescribeApplication</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string InputId { get; set; }

        /// <summary>
        /// Checks to see if the InputId property is set.
        /// </summary>
        internal bool IsSetInputId() => this.InputId != null;

        /// <summary>
        /// Gets and sets the property InputProcessingConfiguration. 
        /// <para>
        /// The <a>InputProcessingConfiguration</a> to add to the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputProcessingConfiguration InputProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetInputProcessingConfiguration() => this.InputProcessingConfiguration != null;
    }
}
