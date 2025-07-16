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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
    /// Container for the parameters to the CreateStateMachine operation.
    /// Creates a state machine. A state machine consists of a collection of states that can
    /// do work (<c>Task</c> states), determine to which states to transition next (<c>Choice</c>
    /// states), stop an execution with an error (<c>Fail</c> states), and so on. State machines
    /// are specified using a JSON-based, structured language. For more information, see <a
    /// href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
    /// States Language</a> in the Step Functions User Guide.
    /// 
    ///  
    /// <para>
    /// If you set the <c>publish</c> parameter of this API action to <c>true</c>, it publishes
    /// version <c>1</c> as the first revision of the state machine.
    /// </para>
    ///  
    /// <para>
    ///  For additional control over security, you can encrypt your data using a <b>customer-managed
    /// key</b> for Step Functions state machines. You can configure a symmetric KMS key and
    /// data key reuse period when creating or updating a <b>State Machine</b>. The execution
    /// history and state machine definition will be encrypted with the key applied to the
    /// State Machine. 
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not reflect
    /// very recent updates and changes.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <c>CreateStateMachine</c> is an idempotent API. Subsequent requests won’t create
    /// a duplicate resource if it was already created. <c>CreateStateMachine</c>'s idempotency
    /// check is based on the state machine <c>name</c>, <c>definition</c>, <c>type</c>, <c>LoggingConfiguration</c>,
    /// <c>TracingConfiguration</c>, and <c>EncryptionConfiguration</c> The check is also
    /// based on the <c>publish</c> and <c>versionDescription</c> parameters. If a following
    /// request has a different <c>roleArn</c> or <c>tags</c>, Step Functions will ignore
    /// these differences and treat it as an idempotent request of the previous. In this case,
    /// <c>roleArn</c> and <c>tags</c> will not be updated, even if they are different.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateStateMachineRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private EncryptionConfiguration _encryptionConfiguration;
        private LoggingConfiguration _loggingConfiguration;
        private string _name;
        private bool? _publish;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TracingConfiguration _tracingConfiguration;
        private StateMachineType _type;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine. See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1048576)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Settings to configure server-side encryption.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Defines what execution history events are logged and where they are logged.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, the <c>level</c> is set to <c>OFF</c>. For more information see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/cloudwatch-log-level.html">Log
        /// Levels</a> in the Step Functions User Guide.
        /// </para>
        ///  </note>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

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
        /// brackets <c>&lt; &gt; { } [ ]</c> 
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
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property Publish. 
        /// <para>
        /// Set to <c>true</c> to publish the first version of the state machine during creation.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Publish
        {
            get { return this._publish; }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to use for this state machine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be added when creating a state machine.
        /// </para>
        ///  
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>, and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html">Controlling
        /// Access Using IAM Tags</a>.
        /// </para>
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <c>_
        /// . : / = + - @</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TracingConfiguration. 
        /// <para>
        /// Selects whether X-Ray tracing is enabled.
        /// </para>
        /// </summary>
        public TracingConfiguration TracingConfiguration
        {
            get { return this._tracingConfiguration; }
            set { this._tracingConfiguration = value; }
        }

        // Check to see if TracingConfiguration property is set
        internal bool IsSetTracingConfiguration()
        {
            return this._tracingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Determines whether a Standard or Express state machine is created. The default is
        /// <c>STANDARD</c>. You cannot update the <c>type</c> of a state machine once it has
        /// been created.
        /// </para>
        /// </summary>
        public StateMachineType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// Sets description about the state machine version. You can only set the description
        /// if the <c>publish</c> parameter is set to <c>true</c>. Otherwise, if you set <c>versionDescription</c>,
        /// but <c>publish</c> to <c>false</c>, this API action throws <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}