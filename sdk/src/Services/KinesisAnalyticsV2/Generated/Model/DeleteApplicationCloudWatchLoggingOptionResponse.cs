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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteApplicationCloudWatchLoggingOption operation.
    /// </summary>
    public partial class DeleteApplicationCloudWatchLoggingOptionResponse : AmazonWebServiceResponse
    {
        private string _applicationARN;
        private long? _applicationVersionId;
        private List<CloudWatchLoggingOptionDescription> _cloudWatchLoggingOptionDescriptions = new List<CloudWatchLoggingOptionDescription>();

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The application's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ApplicationARN
        {
            get { return this._applicationARN; }
            set { this._applicationARN = value; }
        }

        // Check to see if ApplicationARN property is set
        internal bool IsSetApplicationARN()
        {
            return this._applicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The version ID of the application. Kinesis Data Analytics updates the <code>ApplicationVersionId</code>
        /// each time you change the CloudWatch logging options.
        /// </para>
        /// </summary>
        public long ApplicationVersionId
        {
            get { return this._applicationVersionId.GetValueOrDefault(); }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionDescriptions. 
        /// <para>
        /// The descriptions of the remaining CloudWatch logging options for the application.
        /// </para>
        /// </summary>
        public List<CloudWatchLoggingOptionDescription> CloudWatchLoggingOptionDescriptions
        {
            get { return this._cloudWatchLoggingOptionDescriptions; }
            set { this._cloudWatchLoggingOptionDescriptions = value; }
        }

        // Check to see if CloudWatchLoggingOptionDescriptions property is set
        internal bool IsSetCloudWatchLoggingOptionDescriptions()
        {
            return this._cloudWatchLoggingOptionDescriptions != null && this._cloudWatchLoggingOptionDescriptions.Count > 0; 
        }

    }
}