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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of the specified workflow
    /// </summary>
    public partial class DescribedWorkflow
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies the text description for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OnExceptionSteps. 
        /// <para>
        /// Specifies the steps (actions) to take if errors are encountered during execution of
        /// the workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public List<WorkflowStep> OnExceptionSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowStep>() : null;

        /// <summary>
        /// Checks to see if the OnExceptionSteps property is set.
        /// </summary>
        internal bool IsSetOnExceptionSteps() => this.OnExceptionSteps != null && (this.OnExceptionSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// Specifies the details for the steps that are in the specified workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public List<WorkflowStep> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowStep>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StructuredLogDestinations. 
        /// <para>
        /// Specifies the log groups to which your workflow logs are sent.
        /// </para>
        ///  
        /// <para>
        /// To specify a log group, you must provide the ARN for an existing log group. In this
        /// case, the format of the log group is as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:logs:region-name:amazon-account-id:log-group:log-group-name:*</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>arn:aws:logs:us-east-1:111122223333:log-group:mytestgroup:*</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> StructuredLogDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StructuredLogDestinations property is set.
        /// </summary>
        internal bool IsSetStructuredLogDestinations() => this.StructuredLogDestinations != null && (this.StructuredLogDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for workflows. Tags are metadata
        /// attached to workflows for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// A unique identifier for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
