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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatasetExportJob operation.
    /// Starts an asynchronous job that exports dataset and time-series data from a workspace
    /// to Amazon S3. The operation returns a jobId immediately; poll DescribeDatasetExportJob
    /// to track progress and ListDatasetExportJobs to enumerate a workspace's jobs.
    /// </summary>
    public partial class CreateDatasetExportJobRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private string _destinations3Uri;
        private ExportErrorReportLocation _errorReportLocation;
        private ProcessingInput _input;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. The AWS SDKs and CLI populate this automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The S3 URI where output clips will be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DestinationS3Uri
        {
            get { return this._destinations3Uri; }
            set { this._destinations3Uri = value; }
        }

        // Check to see if DestinationS3Uri property is set
        internal bool IsSetDestinationS3Uri()
        {
            return this._destinations3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// The location where the error report will be written on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportErrorReportLocation ErrorReportLocation
        {
            get { return this._errorReportLocation; }
            set { this._errorReportLocation = value; }
        }

        // Check to see if ErrorReportLocation property is set
        internal bool IsSetErrorReportLocation()
        {
            return this._errorReportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The processing input source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace in which to create the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}