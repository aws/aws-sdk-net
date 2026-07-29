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
    /// Response structure for CreateTask operation.
    /// </summary>
    public partial class CreateTaskResponse : AmazonWebServiceResponse
    {
        private ResourceStatus _status;
        private string _taskArn;
        private string _taskName;
        private string _version;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle status of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the created task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the created task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the newly created task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}