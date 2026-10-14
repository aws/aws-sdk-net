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
    /// This is the response object from the DescribeStateMachine operation.
    /// </summary>
    public partial class DescribeStateMachineResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the state machine is created.
        /// </para>
        ///  
        /// <para>
        /// For a state machine version, <c>creationDate</c> is the date the version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine. See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a>.
        /// </para>
        ///  
        /// <para>
        /// If called with <c>includedData = METADATA_ONLY</c>, the returned definition will be
        /// <c>{}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1048576)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the state machine version.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// parameter is present only if the <c>stateMachineArn</c> specified in input is a qualified
        /// state machine ARN.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state machine.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <c>&lt; > { } [ ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <c>? *</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <c>" # % \ ^ | ~ ` $ &amp; , ; : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<c>U+0000-001F</c>, <c>U+007F-009F</c>, <c>U+FFFE-FFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// surrogates (<c>U+D800-DFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// invalid characters (<c> U+10FFFF</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging with CloudWatch Logs, the name should only contain 0-9, A-Z, a-z,
        /// - and _.
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
        /// The revision identifier for the state machine.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>revisionId</c> parameter to compare between versions of a state machine
        /// configuration used for executions without performing a diff of the properties, such
        /// as <c>definition</c> and <c>roleArn</c>.
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
        /// The Amazon Resource Name (ARN) of the IAM role used when creating this state machine.
        /// (The IAM role maintains security by granting Step Functions access to Amazon Web Services
        /// resources.)
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
        /// The Amazon Resource Name (ARN) that identifies the state machine.
        /// </para>
        ///  
        /// <para>
        /// If you specified a state machine version ARN in your request, the API returns the
        /// version ARN. The version ARN is a combination of state machine ARN and the version
        /// number separated by a colon (:). For example, <c>stateMachineARN:1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StateMachineArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineArn property is set.
        /// </summary>
        internal bool IsSetStateMachineArn() => this.StateMachineArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the state machine.
        /// </para>
        /// </summary>
        public StateMachineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Gets and sets the property Type. 
        /// <para>
        /// The <c>type</c> of the state machine (<c>STANDARD</c> or <c>EXPRESS</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StateMachineType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

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
