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
    /// The cluster resource and configuration.
    /// </summary>
    public partial class Cluster
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<Endpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<Endpoint>() : null;
        private List<ErrorInfo> _errorInfo = AWSConfigs.InitializeCollections ? new List<ErrorInfo>() : null;
        private string _id;
        private DateTime? _modifiedAt;
        private string _name;
        private Networking _networking;
        private Scheduler _scheduler;
        private Size _size;
        private ClusterSlurmConfiguration _slurmConfiguration;
        private ClusterStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the cluster.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The list of endpoints available for interaction with the scheduler.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Endpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// The list of errors that occurred during cluster provisioning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The generated unique ID of the cluster.
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
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
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
        /// The name that identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Networking.
        /// </summary>
        [AWSProperty(Required=true)]
        public Networking Networking
        {
            get { return this._networking; }
            set { this._networking = value; }
        }

        // Check to see if Networking property is set
        internal bool IsSetNetworking()
        {
            return this._networking != null;
        }

        /// <summary>
        /// Gets and sets the property Scheduler.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scheduler Scheduler
        {
            get { return this._scheduler; }
            set { this._scheduler = value; }
        }

        // Check to see if Scheduler property is set
        internal bool IsSetScheduler()
        {
            return this._scheduler != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the cluster.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SMALL</c>: 32 compute nodes and 256 jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c>: 512 compute nodes and 8192 jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE</c>: 2048 compute nodes and 16,384 jobs
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Size Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null;
        }

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public ClusterSlurmConfiguration SlurmConfiguration
        {
            get { return this._slurmConfiguration; }
            set { this._slurmConfiguration = value; }
        }

        // Check to see if SlurmConfiguration property is set
        internal bool IsSetSlurmConfiguration()
        {
            return this._slurmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The provisioning status of the cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// The provisioning status doesn't indicate the overall health of the cluster.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// The resource enters the <c>SUSPENDING</c> and <c>SUSPENDED</c> states when the scheduler
        /// is beyond end of life and we have suspended the cluster. When in these states, you
        /// can't use the cluster. The cluster controller is down and all compute instances are
        /// terminated. The resources still count toward your service quotas. You can delete a
        /// resource if its status is <c>SUSPENDED</c>. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/slurm-versions_faq.html">Frequently
        /// asked questions about Slurm versions in PCS</a> in the <i>PCS User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterStatus Status
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