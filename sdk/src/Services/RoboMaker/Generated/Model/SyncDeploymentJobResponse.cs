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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the SyncDeploymentJob operation.
    /// </summary>
    [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
    public partial class SyncDeploymentJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<DeploymentApplicationConfig> _deploymentApplicationConfigs = AWSConfigs.InitializeCollections ? new List<DeploymentApplicationConfig>() : null;
        private DeploymentConfig _deploymentConfig;
        private DeploymentJobErrorCode _failureCode;
        private string _failureReason;
        private string _fleet;
        private DeploymentStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the synchronization request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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
        /// The time, in milliseconds since the epoch, when the fleet was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeploymentApplicationConfigs. 
        /// <para>
        /// Information about the deployment application configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<DeploymentApplicationConfig> DeploymentApplicationConfigs
        {
            get { return this._deploymentApplicationConfigs; }
            set { this._deploymentApplicationConfigs = value; }
        }

        // Check to see if DeploymentApplicationConfigs property is set
        internal bool IsSetDeploymentApplicationConfigs()
        {
            return this._deploymentApplicationConfigs != null && (this._deploymentApplicationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// Information about the deployment configuration.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code if the job fails:
        /// </para>
        ///  <dl> <dt>InternalServiceError</dt> <dd> 
        /// <para>
        /// Internal service error.
        /// </para>
        ///  </dd> <dt>RobotApplicationCrash</dt> <dd> 
        /// <para>
        /// Robot application exited abnormally.
        /// </para>
        ///  </dd> <dt>SimulationApplicationCrash</dt> <dd> 
        /// <para>
        ///  Simulation application exited abnormally.
        /// </para>
        ///  </dd> <dt>BadPermissionsRobotApplication</dt> <dd> 
        /// <para>
        /// Robot application bundle could not be downloaded.
        /// </para>
        ///  </dd> <dt>BadPermissionsSimulationApplication</dt> <dd> 
        /// <para>
        /// Simulation application bundle could not be downloaded.
        /// </para>
        ///  </dd> <dt>BadPermissionsS3Output</dt> <dd> 
        /// <para>
        /// Unable to publish outputs to customer-provided S3 bucket.
        /// </para>
        ///  </dd> <dt>BadPermissionsCloudwatchLogs</dt> <dd> 
        /// <para>
        /// Unable to publish logs to customer-provided CloudWatch Logs resource.
        /// </para>
        ///  </dd> <dt>SubnetIpLimitExceeded</dt> <dd> 
        /// <para>
        /// Subnet IP limit exceeded.
        /// </para>
        ///  </dd> <dt>ENILimitExceeded</dt> <dd> 
        /// <para>
        /// ENI limit exceeded.
        /// </para>
        ///  </dd> <dt>BadPermissionsUserCredentials</dt> <dd> 
        /// <para>
        /// Unable to use the Role provided.
        /// </para>
        ///  </dd> <dt>InvalidBundleRobotApplication</dt> <dd> 
        /// <para>
        /// Robot bundle cannot be extracted (invalid format, bundling error, or other issue).
        /// </para>
        ///  </dd> <dt>InvalidBundleSimulationApplication</dt> <dd> 
        /// <para>
        /// Simulation bundle cannot be extracted (invalid format, bundling error, or other issue).
        /// </para>
        ///  </dd> <dt>RobotApplicationVersionMismatchedEtag</dt> <dd> 
        /// <para>
        /// Etag for RobotApplication does not match value during version creation.
        /// </para>
        ///  </dd> <dt>SimulationApplicationVersionMismatchedEtag</dt> <dd> 
        /// <para>
        /// Etag for SimulationApplication does not match value during version creation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public DeploymentJobErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if the job fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Fleet. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the synchronization job.
        /// </para>
        /// </summary>
        public DeploymentStatus Status
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