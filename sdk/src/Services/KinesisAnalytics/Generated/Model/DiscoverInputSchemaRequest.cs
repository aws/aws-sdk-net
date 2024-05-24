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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the DiscoverInputSchema operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Infers a schema by evaluating sample records on the specified streaming source (Amazon
    /// Kinesis stream or Amazon Kinesis Firehose delivery stream) or S3 object. In the response,
    /// the operation returns the inferred schema and also the sample records that the operation
    /// used to infer the schema.
    /// </para>
    ///  
    /// <para>
    ///  You can use the inferred schema when configuring a streaming source for your application.
    /// For conceptual information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
    /// Application Input</a>. Note that when you create an application using the Amazon Kinesis
    /// Analytics console, the console uses this operation to infer a schema and show it in
    /// the console user interface. 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permissions to perform the <c>kinesisanalytics:DiscoverInputSchema</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DiscoverInputSchemaRequest : AmazonKinesisAnalyticsRequest
    {
        private InputProcessingConfiguration _inputProcessingConfiguration;
        private InputStartingPositionConfiguration _inputStartingPositionConfiguration;
        private string _resourceARN;
        private string _roleARN;
        private S3Configuration _s3Configuration;

        /// <summary>
        /// Gets and sets the property InputProcessingConfiguration. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputProcessingConfiguration.html">InputProcessingConfiguration</a>
        /// to use to preprocess the records before discovering the schema of the records.
        /// </para>
        /// </summary>
        public InputProcessingConfiguration InputProcessingConfiguration
        {
            get { return this._inputProcessingConfiguration; }
            set { this._inputProcessingConfiguration = value; }
        }

        // Check to see if InputProcessingConfiguration property is set
        internal bool IsSetInputProcessingConfiguration()
        {
            return this._inputProcessingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InputStartingPositionConfiguration. 
        /// <para>
        /// Point at which you want Amazon Kinesis Analytics to start reading records from the
        /// specified streaming source discovery purposes.
        /// </para>
        /// </summary>
        public InputStartingPositionConfiguration InputStartingPositionConfiguration
        {
            get { return this._inputStartingPositionConfiguration; }
            set { this._inputStartingPositionConfiguration = value; }
        }

        // Check to see if InputStartingPositionConfiguration property is set
        internal bool IsSetInputStartingPositionConfiguration()
        {
            return this._inputStartingPositionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Amazon Resource Name (ARN) of the streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to access the stream
        /// on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// Specify this parameter to discover a schema from data in an Amazon S3 object.
        /// </para>
        /// </summary>
        public S3Configuration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

    }
}