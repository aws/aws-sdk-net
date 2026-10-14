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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The details of a blueprint run.
    /// </summary>
    public partial class BlueprintRun
    {
        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BlueprintName { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintName property is set.
        /// </summary>
        internal bool IsSetBlueprintName() => this.BlueprintName != null;

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time that the blueprint run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Indicates any errors that are seen while running the blueprint.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The blueprint parameters as a string. You will have to provide a value for each key
        /// that is required from the parameter spec that is defined in the <c>Blueprint$ParameterSpec</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN. This role will be assumed by the Glue service and will be used to create
        /// the workflow and other entities of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RollbackErrorMessage. 
        /// <para>
        /// If there are any errors while creating the entities of a workflow, we try to roll
        /// back the created entities until that point and delete them. This attribute indicates
        /// the errors seen while trying to delete the entities that are created.
        /// </para>
        /// </summary>
        public string RollbackErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the RollbackErrorMessage property is set.
        /// </summary>
        internal bool IsSetRollbackErrorMessage() => this.RollbackErrorMessage != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The run ID for this blueprint run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time that the blueprint run started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the blueprint run. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running — The blueprint run is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded — The blueprint run completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed — The blueprint run failed and rollback is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rolling Back — The blueprint run failed and rollback is in progress.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlueprintRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of a workflow that is created as a result of a successful blueprint run.
        /// If a blueprint run has an error, there will not be a workflow created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowName property is set.
        /// </summary>
        internal bool IsSetWorkflowName() => this.WorkflowName != null;
    }
}
