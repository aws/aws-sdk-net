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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
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
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The custom script to run tests on source or target environments.
    /// </summary>
    public partial class WorkflowStepAutomationConfiguration
    {
        private PlatformCommand _command;
        private RunEnvironment _runEnvironment;
        private string _scriptLocationS3Bucket;
        private PlatformScriptKey _scriptLocationS3Key;
        private TargetType _targetType;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command required to run the script.
        /// </para>
        /// </summary>
        public PlatformCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property RunEnvironment. 
        /// <para>
        /// The source or target environment.
        /// </para>
        /// </summary>
        public RunEnvironment RunEnvironment
        {
            get { return this._runEnvironment; }
            set { this._runEnvironment = value; }
        }

        // Check to see if RunEnvironment property is set
        internal bool IsSetRunEnvironment()
        {
            return this._runEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptLocationS3Bucket. 
        /// <para>
        /// The Amazon S3 bucket where the script is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string ScriptLocationS3Bucket
        {
            get { return this._scriptLocationS3Bucket; }
            set { this._scriptLocationS3Bucket = value; }
        }

        // Check to see if ScriptLocationS3Bucket property is set
        internal bool IsSetScriptLocationS3Bucket()
        {
            return this._scriptLocationS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptLocationS3Key. 
        /// <para>
        /// The Amazon S3 key for the script location.
        /// </para>
        /// </summary>
        public PlatformScriptKey ScriptLocationS3Key
        {
            get { return this._scriptLocationS3Key; }
            set { this._scriptLocationS3Key = value; }
        }

        // Check to see if ScriptLocationS3Key property is set
        internal bool IsSetScriptLocationS3Key()
        {
            return this._scriptLocationS3Key != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The servers on which to run the script.
        /// </para>
        /// </summary>
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}