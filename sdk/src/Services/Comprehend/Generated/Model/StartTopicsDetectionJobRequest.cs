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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StartTopicsDetectionJob operation.
    /// Starts an asynchronous topic detection job. Use the <code>DescribeTopicDetectionJob</code>
    /// operation to track the status of a job.
    /// </summary>
    public partial class StartTopicsDetectionJobRequest : AmazonComprehendRequest
    {
        private string _clientRequestToken;
        private string _dataAccessRoleArn;
        private InputDataConfig _inputDataConfig;
        private string _jobName;
        private int? _numberOfTopics;
        private OutputDataConfig _outputDataConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you do not set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend read access to your input data. 
        /// </para>
        /// </summary>
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input data for the job.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The identifier of the job.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfTopics. 
        /// <para>
        /// The number of topics to detect.
        /// </para>
        /// </summary>
        public int NumberOfTopics
        {
            get { return this._numberOfTopics.GetValueOrDefault(); }
            set { this._numberOfTopics = value; }
        }

        // Check to see if NumberOfTopics property is set
        internal bool IsSetNumberOfTopics()
        {
            return this._numberOfTopics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies where to send the output files. The output is a compressed archive with
        /// two files, <code>topic-terms.csv</code> that lists the terms associated with each
        /// topic, and <code>doc-topics.csv</code> that lists the documents associated with each
        /// topic
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

    }
}