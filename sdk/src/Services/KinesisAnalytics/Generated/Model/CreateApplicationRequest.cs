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
    /// Container for the parameters to the CreateApplication operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Creates an Amazon Kinesis Analytics application. You can configure each application
    /// with one streaming source as input, application code to process the input, and up
    /// to three destinations where you want Amazon Kinesis Analytics to write the output
    /// data from your application. For an overview, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works.html">How
    /// it Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// In the input configuration, you map the streaming source to an in-application stream,
    /// which you can think of as a constantly updating table. In the mapping, you must provide
    /// a schema for the in-application stream and map each data column in the in-application
    /// stream to a data element in the streaming source.
    /// </para>
    ///  
    /// <para>
    /// Your application code is one or more SQL statements that read input data, transform
    /// it, and generate output. Your application code can create one or more SQL artifacts
    /// like SQL streams or pumps.
    /// </para>
    ///  
    /// <para>
    /// In the output configuration, you can configure the application to write data from
    /// in-application streams created in your applications to up to three destinations.
    /// </para>
    ///  
    /// <para>
    ///  To read data from your source stream or write data to destination streams, Amazon
    /// Kinesis Analytics needs your permissions. You grant these permissions by creating
    /// IAM roles. This operation requires permissions to perform the <c>kinesisanalytics:CreateApplication</c>
    /// action. 
    /// </para>
    ///  
    /// <para>
    ///  For introductory exercises to create an Amazon Kinesis Analytics application, see
    /// <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/getting-started.html">Getting
    /// Started</a>. 
    /// </para>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationCode;
        private string _applicationDescription;
        private string _applicationName;
        private List<CloudWatchLoggingOption> _cloudWatchLoggingOptions = AWSConfigs.InitializeCollections ? new List<CloudWatchLoggingOption>() : null;
        private List<Input> _inputs = AWSConfigs.InitializeCollections ? new List<Input>() : null;
        private List<Output> _outputs = AWSConfigs.InitializeCollections ? new List<Output>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationCode. 
        /// <para>
        /// One or more SQL statements that read input data, transform it, and generate output.
        /// For example, you can write a SQL statement that reads data from one in-application
        /// stream, generates a running average of the number of advertisement clicks by vendor,
        /// and insert resulting rows in another in-application stream using pumps. For more information
        /// about the typical pattern, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-app-code.html">Application
        /// Code</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can provide such series of SQL statements, where output of one statement can be
        /// used as the input for the next statement. You store intermediate results by creating
        /// in-application streams and pumps.
        /// </para>
        ///  
        /// <para>
        /// Note that the application code must create the streams with names specified in the
        /// <c>Outputs</c>. For example, if your <c>Outputs</c> defines output streams named <c>ExampleOutputStream1</c>
        /// and <c>ExampleOutputStream2</c>, then your application code must create these streams.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=102400)]
        public string ApplicationCode
        {
            get { return this._applicationCode; }
            set { this._applicationCode = value; }
        }

        // Check to see if ApplicationCode property is set
        internal bool IsSetApplicationCode()
        {
            return this._applicationCode != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// Summary description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of your Amazon Kinesis Analytics application (for example, <c>sample-app</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// Use this parameter to configure a CloudWatch log stream to monitor application configuration
        /// errors. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchLoggingOption> CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null && (this._cloudWatchLoggingOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Use this parameter to configure the application input.
        /// </para>
        ///  
        /// <para>
        /// You can configure your application to receive input from a single streaming source.
        /// In this configuration, you map this streaming source to an in-application stream that
        /// is created. Your application code can then query the in-application stream like a
        /// table (you can think of it as a constantly updating table).
        /// </para>
        ///  
        /// <para>
        /// For the streaming source, you provide its Amazon Resource Name (ARN) and format of
        /// data on the stream (for example, JSON, CSV, etc.). You also must provide an IAM role
        /// that Amazon Kinesis Analytics can assume to read this stream on your behalf.
        /// </para>
        ///  
        /// <para>
        /// To create the in-application stream, you need to specify a schema to transform your
        /// data into a schematized version used in SQL. In the schema, you provide the necessary
        /// mapping of the data elements in the streaming source to record columns in the in-app
        /// stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Input> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// You can configure application output to write data from any of the in-application
        /// streams to up to three destinations.
        /// </para>
        ///  
        /// <para>
        /// These destinations can be Amazon Kinesis streams, Amazon Kinesis Firehose delivery
        /// streams, AWS Lambda destinations, or any combination of the three.
        /// </para>
        ///  
        /// <para>
        /// In the configuration, you specify the in-application stream name, the destination
        /// stream or Lambda function Amazon Resource Name (ARN), and the format to use when writing
        /// data. You must also provide an IAM role that Amazon Kinesis Analytics can assume to
        /// write to the destination stream or Lambda function on your behalf.
        /// </para>
        ///  
        /// <para>
        /// In the output configuration, you also provide the output stream or Lambda function
        /// ARN. For stream destinations, you provide the format of data in the stream (for example,
        /// JSON, CSV). You also must provide an IAM role that Amazon Kinesis Analytics can assume
        /// to write to the stream or Lambda function on your behalf.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of one or more tags to assign to the application. A tag is a key-value pair
        /// that identifies an application. Note that the maximum number of application tags includes
        /// system tags. The maximum number of user-defined application tags is 50. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-tagging.html">Using
        /// Tagging</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}