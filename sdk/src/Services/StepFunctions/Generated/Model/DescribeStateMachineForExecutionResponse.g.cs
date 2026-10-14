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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeStateMachineForExecution operation.
    /// </summary>
    public partial class DescribeStateMachineForExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine. See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1048576)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Settings to configure server-side encryption. 
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A user-defined or an auto-generated string that identifies a <c>Map</c> state. This
        /// field is returned only if the <c>executionArn</c> is a child workflow execution that
        /// was started by a Distributed Map state.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration.
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Map Run that started the child workflow execution.
        /// This field is returned only if the <c>executionArn</c> is a child workflow execution
        /// that was started by a Distributed Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string MapRunArn { get; set; }

        /// <summary>
        /// Checks to see if the MapRunArn property is set.
        /// </summary>
        internal bool IsSetMapRunArn() => this.MapRunArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state machine associated with the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision identifier for the state machine. The first revision ID when you create
        /// the state machine is null.
        /// </para>
        ///  
        /// <para>
        /// Use the state machine <c>revisionId</c> parameter to compare the revision of a state
        /// machine with the configuration of the state machine used for executions without performing
        /// a diff of the properties, such as <c>definition</c> and <c>roleArn</c>.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role of the State Machine for the execution.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine associated with the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StateMachineArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineArn property is set.
        /// </summary>
        internal bool IsSetStateMachineArn() => this.StateMachineArn != null;

        /// <summary>
        /// Gets and sets the property TracingConfiguration. 
        /// <para>
        /// Selects whether X-Ray tracing is enabled.
        /// </para>
        /// </summary>
        public TracingConfiguration TracingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TracingConfiguration property is set.
        /// </summary>
        internal bool IsSetTracingConfiguration() => this.TracingConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The date and time the state machine associated with an execution was updated. For
        /// a newly created state machine, this is the creation date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property VariableReferences. 
        /// <para>
        /// A map of <b>state name</b> to a list of variables referenced by that state. States
        /// that do not use variable references will not be shown in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, List<string>> VariableReferences { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the VariableReferences property is set.
        /// </summary>
        internal bool IsSetVariableReferences() => this.VariableReferences != null && (this.VariableReferences.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
