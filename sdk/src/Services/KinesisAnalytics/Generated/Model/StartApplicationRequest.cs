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
    /// Container for the parameters to the StartApplication operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Starts the specified Amazon Kinesis Analytics application. After creating an application,
    /// you must exclusively call this operation to start your application.
    /// </para>
    ///  
    /// <para>
    /// After the application starts, it begins consuming the input data, processes it, and
    /// writes the output to the configured destination.
    /// </para>
    ///  
    /// <para>
    ///  The application status must be <c>READY</c> for you to start an application. You
    /// can get the application status in the console or using the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// After you start the application, you can stop the application from processing the
    /// input by calling the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_StopApplication.html">StopApplication</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>kinesisanalytics:StartApplication</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private List<InputConfiguration> _inputConfigurations = AWSConfigs.InitializeCollections ? new List<InputConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application.
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
        /// Gets and sets the property InputConfigurations. 
        /// <para>
        /// Identifies the specific input, by ID, that the application starts consuming. Amazon
        /// Kinesis Analytics starts reading the streaming source associated with the input. You
        /// can also specify where in the streaming source you want Amazon Kinesis Analytics to
        /// start reading.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InputConfiguration> InputConfigurations
        {
            get { return this._inputConfigurations; }
            set { this._inputConfigurations = value; }
        }

        // Check to see if InputConfigurations property is set
        internal bool IsSetInputConfigurations()
        {
            return this._inputConfigurations != null && (this._inputConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}