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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>Annotation</c> data type.
    /// 
    ///  
    /// <para>
    /// A <c>GetHookResult</c> call returns detailed information and remediation guidance
    /// from Control Tower, Guard, Lambda, or custom Hooks for a Hook invocation result.
    /// </para>
    /// </summary>
    public partial class Annotation
    {
        private string _annotationName;
        private string _remediationLink;
        private string _remediationMessage;
        private AnnotationSeverityLevel _severityLevel;
        private AnnotationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AnnotationName. 
        /// <para>
        /// An identifier for the evaluation logic that was used when invoking the Hook. For Control
        /// Tower, this is the control ID. For Guard, this is the rule ID. For Lambda and custom
        /// Hooks, this is a user-defined identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AnnotationName
        {
            get { return this._annotationName; }
            set { this._annotationName = value; }
        }

        // Check to see if AnnotationName property is set
        internal bool IsSetAnnotationName()
        {
            return this._annotationName != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationLink. 
        /// <para>
        /// A URL that you can access for additional remediation guidance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string RemediationLink
        {
            get { return this._remediationLink; }
            set { this._remediationLink = value; }
        }

        // Check to see if RemediationLink property is set
        internal bool IsSetRemediationLink()
        {
            return this._remediationLink != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationMessage. 
        /// <para>
        /// Suggests what to change if your Hook returns a <c>FAILED</c> status. For example,
        /// "Block public access to the bucket".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string RemediationMessage
        {
            get { return this._remediationMessage; }
            set { this._remediationMessage = value; }
        }

        // Check to see if RemediationMessage property is set
        internal bool IsSetRemediationMessage()
        {
            return this._remediationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityLevel. 
        /// <para>
        /// The relative risk associated with any violations of this type.
        /// </para>
        /// </summary>
        public AnnotationSeverityLevel SeverityLevel
        {
            get { return this._severityLevel; }
            set { this._severityLevel = value; }
        }

        // Check to see if SeverityLevel property is set
        internal bool IsSetSeverityLevel()
        {
            return this._severityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Hook invocation from the downstream service.
        /// </para>
        /// </summary>
        public AnnotationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The explanation for the specific status assigned to this Hook invocation. For example,
        /// "Bucket does not block public access".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}