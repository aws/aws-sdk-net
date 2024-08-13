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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that contains summary information about a system instance.
    /// </summary>
    public partial class SystemInstanceSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _greengrassGroupId;
        private string _greengrassGroupName;
        private string _greengrassGroupVersionId;
        private string _id;
        private SystemInstanceDeploymentStatus _status;
        private DeploymentTarget _target;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the system instance.
        /// </para>
        /// </summary>
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
        /// The date when the system instance was created.
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
        /// Gets and sets the property GreengrassGroupId. 
        /// <para>
        /// The ID of the Greengrass group where the system instance is deployed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GreengrassGroupName. 
        /// <para>
        /// The ID of the Greengrass group where the system instance is deployed.
        /// </para>
        /// </summary>
        public string GreengrassGroupName
        {
            get { return this._greengrassGroupName; }
            set { this._greengrassGroupName = value; }
        }

        // Check to see if GreengrassGroupName property is set
        internal bool IsSetGreengrassGroupName()
        {
            return this._greengrassGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property GreengrassGroupVersionId. 
        /// <para>
        /// The version of the Greengrass group where the system instance is deployed.
        /// </para>
        /// </summary>
        public string GreengrassGroupVersionId
        {
            get { return this._greengrassGroupVersionId; }
            set { this._greengrassGroupVersionId = value; }
        }

        // Check to see if GreengrassGroupVersionId property is set
        internal bool IsSetGreengrassGroupVersionId()
        {
            return this._greengrassGroupVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the system instance.
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the system instance.
        /// </para>
        /// </summary>
        public SystemInstanceDeploymentStatus Status
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The target of the system instance.
        /// </para>
        /// </summary>
        public DeploymentTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The date and time when the system instance was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}