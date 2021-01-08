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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about an Automation runbook (Automation document) used in a runbook workflow
    /// in Change Manager.
    /// 
    ///  <note> 
    /// <para>
    /// The Automation runbooks specified for the runbook workflow can't run until all required
    /// approvals for the change request have been received.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Runbook
    {
        private string _documentName;
        private string _documentVersion;
        private string _maxConcurrency;
        private string _maxErrors;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private List<TargetLocation> _targetLocations = new List<TargetLocation>();
        private string _targetParameterName;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation runbook (Automation document) used in a runbook workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the Automation runbook (Automation document) used in a runbook workflow.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The <code>MaxConcurrency</code> value specified by the user when the operation started,
        /// indicating the maximum number of resources that the runbook operation can run on at
        /// the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The <code>MaxErrors</code> value specified by the user when the execution started,
        /// indicating the maximum number of errors that can occur during the operation before
        /// the updates are stopped or rolled back.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value map of execution parameters, which were supplied when calling <code>StartChangeRequestExecution</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetLocations. 
        /// <para>
        /// Information about the AWS Regions and accounts targeted by the current Runbook operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<TargetLocation> TargetLocations
        {
            get { return this._targetLocations; }
            set { this._targetLocations = value; }
        }

        // Check to see if TargetLocations property is set
        internal bool IsSetTargetLocations()
        {
            return this._targetLocations != null && this._targetLocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetParameterName. 
        /// <para>
        /// The name of the parameter used as the target resource for the rate-controlled runbook
        /// workflow. Required if you specify <code>Targets</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string TargetParameterName
        {
            get { return this._targetParameterName; }
            set { this._targetParameterName = value; }
        }

        // Check to see if TargetParameterName property is set
        internal bool IsSetTargetParameterName()
        {
            return this._targetParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A key-value mapping to target resources that the Runbook operation performs tasks
        /// on. Required if you specify <code>TargetParameterName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}