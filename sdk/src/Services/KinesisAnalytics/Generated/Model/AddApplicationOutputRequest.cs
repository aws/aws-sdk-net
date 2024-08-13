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
    /// Container for the parameters to the AddApplicationOutput operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Adds an external destination to your Amazon Kinesis Analytics application.
    /// </para>
    ///  
    /// <para>
    /// If you want Amazon Kinesis Analytics to deliver data from an in-application stream
    /// within your application to an external destination (such as an Amazon Kinesis stream,
    /// an Amazon Kinesis Firehose delivery stream, or an AWS Lambda function), you add the
    /// relevant configuration to your application using this operation. You can configure
    /// one or more outputs for your application. Each output configuration maps an in-application
    /// stream and an external destination.
    /// </para>
    ///  
    /// <para>
    ///  You can use one of the output configurations to deliver data from your in-application
    /// error stream to an external destination so that you can analyze the errors. For more
    /// information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Understanding
    /// Application Output (Destination)</a>. 
    /// </para>
    ///  
    /// <para>
    ///  Any configuration update, including adding a streaming source using this operation,
    /// results in a new version of the application. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
    /// operation to find the current application version.
    /// </para>
    ///  
    /// <para>
    /// For the limits on the number of application inputs and outputs you can configure,
    /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>kinesisanalytics:AddApplicationOutput</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class AddApplicationOutputRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private Output _output;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application to which you want to add the output configuration.
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
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// Version of the application to which you want to add the output configuration. You
        /// can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to get the current application version. If the version specified is not
        /// the current version, the <c>ConcurrentModificationException</c> is returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId; }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// An array of objects, each describing one output configuration. In the output configuration,
        /// you specify the name of an in-application stream, a destination (that is, an Amazon
        /// Kinesis stream, an Amazon Kinesis Firehose delivery stream, or an AWS Lambda function),
        /// and record the formation to use when writing to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Output Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

    }
}