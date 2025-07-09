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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the CreateCloudAutonomousVmCluster operation.
    /// </summary>
    public partial class CreateCloudAutonomousVmClusterResponse : AmazonWebServiceResponse
    {
        private string _cloudAutonomousVmClusterId;
        private string _displayName;
        private ResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the created Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CloudAutonomousVmClusterId
        {
            get { return this._cloudAutonomousVmClusterId; }
            set { this._cloudAutonomousVmClusterId = value; }
        }

        // Check to see if CloudAutonomousVmClusterId property is set
        internal bool IsSetCloudAutonomousVmClusterId()
        {
            return this._cloudAutonomousVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the created Autonomous VM cluster.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous VM cluster creation process.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous VM cluster creation
        /// process, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}