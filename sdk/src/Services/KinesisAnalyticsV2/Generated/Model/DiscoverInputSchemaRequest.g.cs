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
    /// Container for the parameters to the DiscoverInputSchema operation. Infers a schema
    /// for a SQL-based Kinesis Data Analytics application by evaluating sample records on
    /// the specified streaming source (Kinesis data stream or Kinesis Data Firehose delivery
    /// stream) or Amazon S3 object. In the response, the operation returns the inferred schema
    /// and also the sample records that the operation used to infer the schema. <para> You
    /// can use the inferred schema when configuring a streaming source for your application.
    /// When you create an application using the Kinesis Data Analytics console, the console
    /// uses this operation to infer a schema and show it in the console user interface. </para>
    /// </summary>
    public partial class DiscoverInputSchemaRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property InputProcessingConfiguration. 
        /// <para>
        /// The <a>InputProcessingConfiguration</a> to use to preprocess the records before discovering
        /// the schema of the records.
        /// </para>
        /// </summary>
        public InputProcessingConfiguration InputProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetInputProcessingConfiguration() => this.InputProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property InputStartingPositionConfiguration. 
        /// <para>
        /// The point at which you want Kinesis Data Analytics to start reading records from the
        /// specified streaming source for discovery purposes.
        /// </para>
        /// </summary>
        public InputStartingPositionConfiguration InputStartingPositionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputStartingPositionConfiguration property is set.
        /// </summary>
        internal bool IsSetInputStartingPositionConfiguration() => this.InputStartingPositionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// Specify this parameter to discover a schema from data in an Amazon S3 object.
        /// </para>
        /// </summary>
        public S3Configuration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRole. 
        /// <para>
        /// The ARN of the role that is used to access the streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ServiceExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRole property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRole() => this.ServiceExecutionRole != null;
    }
}
