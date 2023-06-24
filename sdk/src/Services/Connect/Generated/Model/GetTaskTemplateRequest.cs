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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetTaskTemplate operation.
    /// Gets details about a specific task template in the specified Amazon Connect instance.
    /// </summary>
    public partial class GetTaskTemplateRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _snapshotVersion;
        private string _taskTemplateId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotVersion. 
        /// <para>
        /// The system generated version of a task template that is associated with a task, when
        /// the task is created.
        /// </para>
        /// </summary>
        public string SnapshotVersion
        {
            get { return this._snapshotVersion; }
            set { this._snapshotVersion = value; }
        }

        // Check to see if SnapshotVersion property is set
        internal bool IsSetSnapshotVersion()
        {
            return this._snapshotVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TaskTemplateId. 
        /// <para>
        /// A unique identifier for the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string TaskTemplateId
        {
            get { return this._taskTemplateId; }
            set { this._taskTemplateId = value; }
        }

        // Check to see if TaskTemplateId property is set
        internal bool IsSetTaskTemplateId()
        {
            return this._taskTemplateId != null;
        }

    }
}