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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// A queue resource.
    /// </summary>
    public partial class Queue
    {
        private string _arn;
        private string _clusterId;
        private List<ComputeNodeGroupConfiguration> _computeNodeGroupConfigurations = AWSConfigs.InitializeCollections ? new List<ComputeNodeGroupConfiguration>() : null;
        private DateTime? _createdAt;
        private List<ErrorInfo> _errorInfo = AWSConfigs.InitializeCollections ? new List<ErrorInfo>() : null;
        private string _id;
        private DateTime? _modifiedAt;
        private string _name;
        private QueueStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeNodeGroupConfigurations. 
        /// <para>
        /// The list of compute node group configurations associated with the queue. Queues assign
        /// jobs to associated compute node groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComputeNodeGroupConfiguration> ComputeNodeGroupConfigurations
        {
            get { return this._computeNodeGroupConfigurations; }
            set { this._computeNodeGroupConfigurations = value; }
        }

        // Check to see if ComputeNodeGroupConfigurations property is set
        internal bool IsSetComputeNodeGroupConfigurations()
        {
            return this._computeNodeGroupConfigurations != null && (this._computeNodeGroupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The list of errors that occurred during queue provisioning.
        /// </para>
        /// </summary>
        public List<ErrorInfo> ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null && (this._errorInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The generated unique ID of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the resource was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that identifies the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The provisioning status of the queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// The provisioning status doesn't indicate the overall health of the queue.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueueStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}