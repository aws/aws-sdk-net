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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details about a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BlueGreenDeployment
    {
        private string _blueGreenDeploymentIdentifier;
        private string _blueGreenDeploymentName;
        private DateTime? _createTime;
        private DateTime? _deleteTime;
        private string _source;
        private string _status;
        private string _statusDetails;
        private List<SwitchoverDetail> _switchoverDetails = new List<SwitchoverDetail>();
        private List<Tag> _tagList = new List<Tag>();
        private string _target;
        private List<BlueGreenDeploymentTask> _tasks = new List<BlueGreenDeploymentTask>();

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentIdentifier. 
        /// <para>
        /// The system-generated identifier of the blue/green deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BlueGreenDeploymentIdentifier
        {
            get { return this._blueGreenDeploymentIdentifier; }
            set { this._blueGreenDeploymentIdentifier = value; }
        }

        // Check to see if BlueGreenDeploymentIdentifier property is set
        internal bool IsSetBlueGreenDeploymentIdentifier()
        {
            return this._blueGreenDeploymentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentName. 
        /// <para>
        /// The user-supplied name of the blue/green deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public string BlueGreenDeploymentName
        {
            get { return this._blueGreenDeploymentName; }
            set { this._blueGreenDeploymentName = value; }
        }

        // Check to see if BlueGreenDeploymentName property is set
        internal bool IsSetBlueGreenDeploymentName()
        {
            return this._blueGreenDeploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Specifies the time when the blue/green deployment was created, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Specifies the time when the blue/green deployment was deleted, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        /// </summary>
        public DateTime DeleteTime
        {
            get { return this._deleteTime.GetValueOrDefault(); }
            set { this._deleteTime = value; }
        }

        // Check to see if DeleteTime property is set
        internal bool IsSetDeleteTime()
        {
            return this._deleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source database for the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Before switchover, the source database is the production database in the blue environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONING</code> - Resources are being created in the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - Resources are available in the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SWITCHOVER_IN_PROGRESS</code> - The deployment is being switched from the blue
        /// environment to the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SWITCHOVER_COMPLETED</code> - Switchover from the blue environment to the green
        /// environment is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INVALID_CONFIGURATION</code> - Resources in the green environment are invalid,
        /// so switchover isn't possible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SWITCHOVER_FAILED</code> - Switchover was attempted but failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - The blue/green deployment is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Additional information about the status of the blue/green deployment.
        /// </para>
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SwitchoverDetails. 
        /// <para>
        /// The details about each source and target resource in the blue/green deployment.
        /// </para>
        /// </summary>
        public List<SwitchoverDetail> SwitchoverDetails
        {
            get { return this._switchoverDetails; }
            set { this._switchoverDetails = value; }
        }

        // Check to see if SwitchoverDetails property is set
        internal bool IsSetSwitchoverDetails()
        {
            return this._switchoverDetails != null && this._switchoverDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagList.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target database for the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Before switchover, the target database is the clone database in the green environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Target
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
        /// Gets and sets the property Tasks. 
        /// <para>
        /// Either tasks to be performed or tasks that have been completed on the target database
        /// before switchover.
        /// </para>
        /// </summary>
        public List<BlueGreenDeploymentTask> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && this._tasks.Count > 0; 
        }

    }
}