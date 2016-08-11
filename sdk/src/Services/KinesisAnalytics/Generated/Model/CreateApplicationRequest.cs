/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an Amazon Kinesis Analytics application. You can configure each application
    /// with one streaming source as input, application code to process the input, and up
    /// to five streaming destinations where you want Amazon Kinesis Analytics to write the
    /// output data from your application. For an overview, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works.html">How
    /// it Works</a>. 
    /// 
    ///  
    /// <para>
    /// In the input configuration, you map the streaming source to an in-application stream,
    /// which you can think of as a constantly updating table. In the mapping, you must provide
    /// a schema for the in-application stream and map each data column in the in-application
    /// stream to a data element in the streaming source, with the option of renaming, casting
    /// and dropping columns as desired.
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
    /// in-application streams created in your applications to up to five streaming destinations.
    /// </para>
    ///  
    /// <para>
    ///  To read data from your source stream or write data to destination streams, Amazon
    /// Kinesis Analytics needs your permissions. You grant these permissions by creating
    /// IAM roles. This operation requires permissions to perform the <code>kinesisanalytics:CreateApplication</code>
    /// action. 
    /// </para>
    ///  
    /// <para>
    ///  For introductory exercises to create an Amazon Kinesis Analytics application, see
    /// <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/getting-started.html">Getting
    /// Started</a>. 
    /// </para>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationCode;
        private string _applicationDescription;
        private string _applicationName;
        private List<Input> _inputs = new List<Input>();
        private List<Output> _outputs = new List<Output>();

        /// <summary>
        /// Gets and sets the property ApplicationCode. 
        /// <para>
        /// One or more SQL statements that read input data, transform it, and generate output.
        /// For example, you can write a SQL statement that reads input data and generates a running
        /// average of the number of advertisement clicks by vendor.
        /// </para>
        ///  
        /// <para>
        /// You can also provide a series of SQL statements, where output of one statement can
        /// be used as the input for the next statement.
        /// </para>
        ///  
        /// <para>
        /// Note that the application code must create the streams with names specified in the
        /// <code>Outputs</code>. For example, if your <code>Outputs</code> defines output streams
        /// named <code>ExampleOutputStream1</code> and <code>ExampleOutputStream2</code>, then
        /// your application code must create these streams. 
        /// </para>
        /// </summary>
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
        /// Name of your Amazon Kinesis Analytics application (for example, <code>sample-app</code>).
        /// </para>
        /// </summary>
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
        /// data on the stream (for example, JSON, CSV, etc). You also must provide an IAM role
        /// that Amazon Kinesis Analytics can assume to read this stream on your behalf.
        /// </para>
        ///  
        /// <para>
        /// To create the in-application stream, you need to specify a schema to transform your
        /// data into a schematized version used in SQL. In the schema, you provide the necessary
        /// mapping of the data elements in the streaming source to record columns in the in-app
        /// stream.
        /// </para>
        /// </summary>
        public List<Input> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// You can configure application output to write data from any of the in-application
        /// streams to up to five destinations.
        /// </para>
        ///  
        /// <para>
        /// These destinations can be Amazon Kinesis streams, Amazon Kinesis Firehose delivery
        /// streams, or both.
        /// </para>
        ///  
        /// <para>
        /// In the configuration, you specify the in-application stream name, the destination
        /// stream Amazon Resource Name (ARN), and the format to use when writing data. You must
        /// also provide an IAM role that Amazon Kinesis Analytics can assume to write to the
        /// destination stream on your behalf.
        /// </para>
        ///  
        /// <para>
        /// In the output configuration, you also provide the output stream Amazon Resource Name
        /// (ARN) and the format of data in the stream (for example, JSON, CSV). You also must
        /// provide an IAM role that Amazon Kinesis Analytics can assume to write to this stream
        /// on your behalf.
        /// </para>
        /// </summary>
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

    }
}