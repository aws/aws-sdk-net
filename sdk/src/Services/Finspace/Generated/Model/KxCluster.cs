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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The details of a kdb cluster.
    /// </summary>
    public partial class KxCluster
    {
        private string _availabilityZoneId;
        private KxAzMode _azMode;
        private string _clusterDescription;
        private string _clusterName;
        private KxClusterType _clusterType;
        private DateTime? _createdTimestamp;
        private string _executionRole;
        private string _initializationScript;
        private DateTime? _lastModifiedTimestamp;
        private string _releaseLabel;
        private KxClusterStatus _status;
        private string _statusReason;
        private List<Volume> _volumes = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The availability zone identifiers for the requested regions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=12)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AzMode. 
        /// <para>
        /// The number of availability zones assigned per cluster. This can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE</c> – Assigns one availability zone per cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTI</c> – Assigns all the availability zones per cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxAzMode AzMode
        {
            get { return this._azMode; }
            set { this._azMode = value; }
        }

        // Check to see if AzMode property is set
        internal bool IsSetAzMode()
        {
            return this._azMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterDescription. 
        /// <para>
        /// A description of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ClusterDescription
        {
            get { return this._clusterDescription; }
            set { this._clusterDescription = value; }
        }

        // Check to see if ClusterDescription property is set
        internal bool IsSetClusterDescription()
        {
            return this._clusterDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A unique name for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// Specifies the type of KDB database that is being created. The following types are
        /// available: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HDB – A Historical Database. The data is only accessible with read-only permissions
        /// from one of the FinSpace managed kdb databases mounted to the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDB – A Realtime Database. This type of database captures all the data from a ticker
        /// plant and stores it in memory until the end of day, after which it writes all of its
        /// data to a disk and reloads the HDB. This cluster type requires local storage for temporary
        /// storage of data during the savedown process. If you specify this field in your request,
        /// you must provide the <c>savedownStorageConfiguration</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GATEWAY – A gateway cluster allows you to access data across processes in kdb systems.
        /// It allows you to create your own routing logic using the initialization scripts and
        /// custom code. This type of cluster does not require a writable local storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GP – A general purpose cluster allows you to quickly iterate on code during development
        /// by granting greater access to system commands and enabling a fast reload of custom
        /// code. This cluster type can optionally mount databases including cache and savedown
        /// storage. For this cluster type, the node count is fixed at 1. It does not support
        /// autoscaling and supports only <c>SINGLE</c> AZ mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tickerplant – A tickerplant cluster allows you to subscribe to feed handlers based
        /// on IAM permissions. It can publish to RDBs, other Tickerplants, and real-time subscribers
        /// (RTS). Tickerplants can persist messages to log, which is readable by any RDB environment.
        /// It supports only single-node that is only one kdb process.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp at which the cluster was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        ///  An IAM role that defines a set of permissions associated with a cluster. These permissions
        /// are assumed when a cluster attempts to access another cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationScript. 
        /// <para>
        /// Specifies a Q program that will be run at launch of a cluster. It is a relative path
        /// within <i>.zip</i> file that contains the custom code, which will be loaded on the
        /// cluster. It must include the file name itself. For example, <c>somedir/init.q</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InitializationScript
        {
            get { return this._initializationScript; }
            set { this._initializationScript = value; }
        }

        // Check to see if InitializationScript property is set
        internal bool IsSetInitializationScript()
        {
            return this._initializationScript != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The last time that the cluster was modified. The value is determined as epoch time
        /// in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// A version of the FinSpace managed kdb to run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a cluster.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING – The cluster is pending creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATING –The cluster creation process is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED– The cluster creation process has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING – The cluster creation process is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The cluster is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  DELETING – The cluster is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED – The cluster has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED – The cluster failed to delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxClusterStatus Status
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
        /// The error message when a failed state occurs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        ///  A list of volumes attached to the cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}