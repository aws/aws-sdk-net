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

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeFleet operation.
    /// </summary>
    public partial class DescribeFleetResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _lastDeploymentJob;
        private DeploymentStatus _lastDeploymentStatus;
        private DateTime? _lastDeploymentTime;
        private string _name;
        private List<Robot> _robots = new List<Robot>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
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
        /// Gets and sets the property LastDeploymentStatus. 
        /// <para>
        /// The status of the last deployment.
        /// </para>
        /// </summary>
        public DeploymentStatus LastDeploymentStatus
        {
            get { return this._lastDeploymentStatus; }
            set { this._lastDeploymentStatus = value; }
        }

        // Check to see if LastDeploymentStatus property is set
        internal bool IsSetLastDeploymentStatus()
        {
            return this._lastDeploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentTime. 
        /// <para>
        /// The time of the last deployment.
        /// </para>
        /// </summary>
        public DateTime LastDeploymentTime
        {
            get { return this._lastDeploymentTime.GetValueOrDefault(); }
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
        /// The name of the fleet.
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
        /// Gets and sets the property Robots. 
        /// <para>
        /// A list of robots.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<Robot> Robots
        {
            get { return this._robots; }
            set { this._robots = value; }
        }

        // Check to see if Robots property is set
        internal bool IsSetRobots()
        {
            return this._robots != null && this._robots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags added to the specified fleet.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}