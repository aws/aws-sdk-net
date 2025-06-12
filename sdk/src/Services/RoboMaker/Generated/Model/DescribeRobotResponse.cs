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
    /// This is the response object from the DescribeRobot operation.
    /// </summary>
    [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
    public partial class DescribeRobotResponse : AmazonWebServiceResponse
    {
        private Architecture _architecture;
        private string _arn;
        private DateTime? _createdAt;
        private string _fleetArn;
        private string _greengrassGroupId;
        private string _lastDeploymentJob;
        private DateTime? _lastDeploymentTime;
        private string _name;
        private RobotStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The target architecture of the robot application.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the robot.
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
        /// The time, in milliseconds since the epoch, when the robot was created.
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
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property GreengrassGroupId. 
        /// <para>
        /// The Greengrass group id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string GreengrassGroupId
        {
            get { return this._greengrassGroupId; }
            set { this._greengrassGroupId = value; }
        }

        // Check to see if GreengrassGroupId property is set
        internal bool IsSetGreengrassGroupId()
        {
            return this._greengrassGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentJob. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the last deployment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string LastDeploymentJob
        {
            get { return this._lastDeploymentJob; }
            set { this._lastDeploymentJob = value; }
        }

        // Check to see if LastDeploymentJob property is set
        internal bool IsSetLastDeploymentJob()
        {
            return this._lastDeploymentJob != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentTime. 
        /// <para>
        /// The time of the last deployment job.
        /// </para>
        /// </summary>
        public DateTime? LastDeploymentTime
        {
            get { return this._lastDeploymentTime; }
            set { this._lastDeploymentTime = value; }
        }

        // Check to see if LastDeploymentTime property is set
        internal bool IsSetLastDeploymentTime()
        {
            return this._lastDeploymentTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the robot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The status of the fleet.
        /// </para>
        /// </summary>
        public RobotStatus Status
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
        /// The list of all tags added to the specified robot.
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