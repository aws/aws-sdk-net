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
    /// This is the response object from the CreateDeploymentJob operation.
    /// </summary>
    [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
    public partial class CreateDeploymentJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<DeploymentApplicationConfig> _deploymentApplicationConfigs = AWSConfigs.InitializeCollections ? new List<DeploymentApplicationConfig>() : null;
        private DeploymentConfig _deploymentConfig;
        private DeploymentJobErrorCode _failureCode;
        private string _failureReason;
        private string _fleet;
        private DeploymentStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment job.
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
        /// The deployment application configuration.
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
        /// The deployment configuration.
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
        /// The failure code of the simulation job if it failed:
        /// </para>
        ///  <dl> <dt>BadPermissionError</dt> <dd> 
        /// <para>
        /// AWS Greengrass requires a service-level role permission to access other services.
        /// The role must include the <a href="https://console.aws.amazon.com/iam/home?#/policies/arn:aws:iam::aws:policy/service-role/AWSGreengrassResourceAccessRolePolicy$jsonEditor">
        /// <c>AWSGreengrassResourceAccessRolePolicy</c> managed policy</a>. 
        /// </para>
        ///  </dd> <dt>ExtractingBundleFailure</dt> <dd> 
        /// <para>
        /// The robot application could not be extracted from the bundle.
        /// </para>
        ///  </dd> <dt>FailureThresholdBreached</dt> <dd> 
        /// <para>
        /// The percentage of robots that could not be updated exceeded the percentage set for
        /// the deployment.
        /// </para>
        ///  </dd> <dt>GreengrassDeploymentFailed</dt> <dd> 
        /// <para>
        /// The robot application could not be deployed to the robot.
        /// </para>
        ///  </dd> <dt>GreengrassGroupVersionDoesNotExist</dt> <dd> 
        /// <para>
        /// The AWS Greengrass group or version associated with a robot is missing.
        /// </para>
        ///  </dd> <dt>InternalServerError</dt> <dd> 
        /// <para>
        /// An internal error has occurred. Retry your request, but if the problem persists, contact
        /// us with details.
        /// </para>
        ///  </dd> <dt>MissingRobotApplicationArchitecture</dt> <dd> 
        /// <para>
        /// The robot application does not have a source that matches the architecture of the
        /// robot.
        /// </para>
        ///  </dd> <dt>MissingRobotDeploymentResource</dt> <dd> 
        /// <para>
        /// One or more of the resources specified for the robot application are missing. For
        /// example, does the robot application have the correct launch package and launch file?
        /// </para>
        ///  </dd> <dt>PostLaunchFileFailure</dt> <dd> 
        /// <para>
        /// The post-launch script failed.
        /// </para>
        ///  </dd> <dt>PreLaunchFileFailure</dt> <dd> 
        /// <para>
        /// The pre-launch script failed.
        /// </para>
        ///  </dd> <dt>ResourceNotFound</dt> <dd> 
        /// <para>
        /// One or more deployment resources are missing. For example, do robot application source
        /// bundles still exist? 
        /// </para>
        ///  </dd> <dt>RobotDeploymentNoResponse</dt> <dd> 
        /// <para>
        /// There is no response from the robot. It might not be powered on or connected to the
        /// internet.
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
        /// The failure reason of the deployment job if it failed.
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
        /// The target fleet for the deployment job.
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
        /// The status of the deployment job.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags added to the deployment job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}