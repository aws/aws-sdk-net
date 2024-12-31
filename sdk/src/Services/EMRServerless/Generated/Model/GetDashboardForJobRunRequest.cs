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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetDashboardForJobRun operation.
    /// Creates and returns a URL that you can use to access the application UIs for a job
    /// run.
    /// 
    ///  
    /// <para>
    /// For jobs in a running state, the application UI is a live user interface such as the
    /// Spark or Tez web UI. For completed jobs, the application UI is a persistent application
    /// user interface such as the Spark History Server or persistent Tez UI.
    /// </para>
    ///  <note> 
    /// <para>
    /// The URL is valid for one hour after you generate it. To access the application UI
    /// after that hour elapses, you must invoke the API again to generate a new URL.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDashboardForJobRunRequest : AmazonEMRServerlessRequest
    {
        private bool? _accessSystemProfileLogs;
        private string _applicationId;
        private int? _attempt;
        private string _jobRunId;

        /// <summary>
        /// Gets and sets the property AccessSystemProfileLogs. 
        /// <para>
        /// Allows access to system profile logs for Lake Formation-enabled jobs. Default is false.
        /// </para>
        /// </summary>
        public bool? AccessSystemProfileLogs
        {
            get { return this._accessSystemProfileLogs; }
            set { this._accessSystemProfileLogs = value; }
        }

        // Check to see if AccessSystemProfileLogs property is set
        internal bool IsSetAccessSystemProfileLogs()
        {
            return this._accessSystemProfileLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// An optimal parameter that indicates the amount of attempts for the job. If not specified,
        /// this value defaults to the attempt of the latest job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Attempt
        {
            get { return this._attempt; }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobRunId
        {
            get { return this._jobRunId; }
            set { this._jobRunId = value; }
        }

        // Check to see if JobRunId property is set
        internal bool IsSetJobRunId()
        {
            return this._jobRunId != null;
        }

    }
}