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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Details about a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BlueGreenDeployment
    {
        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentIdentifier. 
        /// <para>
        /// The unique identifier of the blue/green deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BlueGreenDeploymentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BlueGreenDeploymentIdentifier property is set.
        /// </summary>
        internal bool IsSetBlueGreenDeploymentIdentifier() => this.BlueGreenDeploymentIdentifier != null;

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentName. 
        /// <para>
        /// The user-supplied name of the blue/green deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string BlueGreenDeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the BlueGreenDeploymentName property is set.
        /// </summary>
        internal bool IsSetBlueGreenDeploymentName() => this.BlueGreenDeploymentName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the blue/green deployment was created, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// The time when the blue/green deployment was deleted, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTime property is set.
        /// </summary>
        internal bool IsSetDeleteTime() => this.DeleteTime.HasValue;

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
        [AWSProperty(Min = 1, Max = 2048)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONING</c> - Resources are being created in the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - Resources are available in the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SWITCHOVER_IN_PROGRESS</c> - The deployment is being switched from the blue environment
        /// to the green environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SWITCHOVER_COMPLETED</c> - Switchover from the blue environment to the green environment
        /// is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_CONFIGURATION</c> - Resources in the green environment are invalid, so
        /// switchover isn't possible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SWITCHOVER_FAILED</c> - Switchover was attempted but failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The blue/green deployment is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Additional information about the status of the blue/green deployment.
        /// </para>
        /// </summary>
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property SwitchoverDetails. 
        /// <para>
        /// The details about each source and target resource in the blue/green deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SwitchoverDetail> SwitchoverDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<SwitchoverDetail>() : null;

        /// <summary>
        /// Checks to see if the SwitchoverDetails property is set.
        /// </summary>
        internal bool IsSetSwitchoverDetails() => this.SwitchoverDetails != null && (this.SwitchoverDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 2048)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// Either tasks to be performed or tasks that have been completed on the target database
        /// before switchover.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlueGreenDeploymentTask> Tasks { get; set; } = AWSConfigs.InitializeCollections ? new List<BlueGreenDeploymentTask>() : null;

        /// <summary>
        /// Checks to see if the Tasks property is set.
        /// </summary>
        internal bool IsSetTasks() => this.Tasks != null && (this.Tasks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
