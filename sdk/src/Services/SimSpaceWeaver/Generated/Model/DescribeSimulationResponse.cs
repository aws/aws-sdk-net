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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// This is the response object from the DescribeSimulation operation.
    /// </summary>
    public partial class DescribeSimulationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private string _executionId;
        private LiveSimulationState _liveSimulationState;
        private LoggingConfiguration _loggingConfiguration;
        private string _maximumDuration;
        private string _name;
        private string _roleArn;
        private string _schemaError;
        private S3Location _schemaS3Location;
        private SimulationStatus _status;
        private SimulationTargetStatus _targetStatus;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation. For more information about ARNs,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1600)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the simulation was created, expressed as the number of seconds and milliseconds
        /// in UTC since the Unix epoch (0:0:0.000, January 1, 1970).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// A universally unique identifier (UUID) for this simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property LiveSimulationState. 
        /// <para>
        /// A collection of additional state information, such as domain and clock configuration.
        /// </para>
        /// </summary>
        public LiveSimulationState LiveSimulationState
        {
            get { return this._liveSimulationState; }
            set { this._liveSimulationState = value; }
        }

        // Check to see if LiveSimulationState property is set
        internal bool IsSetLiveSimulationState()
        {
            return this._liveSimulationState != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Settings that control how SimSpace Weaver handles your simulation log data.
        /// </para>
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
        /// Gets and sets the property MaximumDuration. 
        /// <para>
        /// The maximum running time of the simulation, specified as a number of months (m or
        /// M), hours (h or H), or days (d or D). The simulation stops when it reaches this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=6)]
        public string MaximumDuration
        {
            get { return this._maximumDuration; }
            set { this._maximumDuration = value; }
        }

        // Check to see if MaximumDuration property is set
        internal bool IsSetMaximumDuration()
        {
            return this._maximumDuration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the simulation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// the simulation assumes to perform actions. For more information about ARNs, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>. For
        /// more information about IAM roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>Identity and Access Management User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1600)]
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
        /// Gets and sets the property SchemaError. 
        /// <para>
        /// An error message that SimSpace Weaver returns only if there is a problem with the
        /// simulation schema.
        /// </para>
        /// </summary>
        public string SchemaError
        {
            get { return this._schemaError; }
            set { this._schemaError = value; }
        }

        // Check to see if SchemaError property is set
        internal bool IsSetSchemaError()
        {
            return this._schemaError != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaS3Location. 
        /// <para>
        /// The location of the simulation schema in Amazon Simple Storage Service (Amazon S3).
        /// For more information about Amazon S3, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Welcome.html">
        /// <i>Amazon Simple Storage Service User Guide</i> </a>.
        /// </para>
        /// </summary>
        public S3Location SchemaS3Location
        {
            get { return this._schemaS3Location; }
            set { this._schemaS3Location = value; }
        }

        // Check to see if SchemaS3Location property is set
        internal bool IsSetSchemaS3Location()
        {
            return this._schemaS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle state of the simulation.
        /// </para>
        /// </summary>
        public SimulationStatus Status
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
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The desired lifecycle state of the simulation.
        /// </para>
        /// </summary>
        public SimulationTargetStatus TargetStatus
        {
            get { return this._targetStatus; }
            set { this._targetStatus = value; }
        }

        // Check to see if TargetStatus property is set
        internal bool IsSetTargetStatus()
        {
            return this._targetStatus != null;
        }

    }
}