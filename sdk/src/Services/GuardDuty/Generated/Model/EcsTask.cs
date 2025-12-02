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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about Amazon ECS task involved in a GuardDuty finding, including
    /// task definition and container identifiers.
    /// </summary>
    public partial class EcsTask
    {
        private List<string> _containerUids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private EcsLaunchType _launchType;
        private string _taskDefinitionArn;

        /// <summary>
        /// Gets and sets the property ContainerUids. 
        /// <para>
        /// A list of unique identifiers for the containers associated with the Amazon ECS task.
        /// </para>
        /// </summary>
        public List<string> ContainerUids
        {
            get { return this._containerUids; }
            set { this._containerUids = value; }
        }

        // Check to see if ContainerUids property is set
        internal bool IsSetContainerUids()
        {
            return this._containerUids != null && (this._containerUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the Amazon ECS task was created, in UTC format.
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The infrastructure type on which the Amazon ECS task runs.
        /// </para>
        /// </summary>
        public EcsLaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of task definition which describes the container and volume definitions of
        /// the Amazon ECS task.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

    }
}