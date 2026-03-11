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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Represents a warning about a resource in a Region switch plan.
    /// </summary>
    public partial class ResourceWarning
    {
        private string _resourceArn;
        private string _stepName;
        private string _version;
        private string _warningMessage;
        private ResourceWarningStatus _warningStatus;
        private DateTime? _warningUpdatedTime;
        private MinimalWorkflow _workflow;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step for the resource warning.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the resource warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// The warning message about what needs to be corrected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

        /// <summary>
        /// Gets and sets the property WarningStatus. 
        /// <para>
        /// The status of the resource warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceWarningStatus WarningStatus
        {
            get { return this._warningStatus; }
            set { this._warningStatus = value; }
        }

        // Check to see if WarningStatus property is set
        internal bool IsSetWarningStatus()
        {
            return this._warningStatus != null;
        }

        /// <summary>
        /// Gets and sets the property WarningUpdatedTime. 
        /// <para>
        /// The timestamp when the warning was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? WarningUpdatedTime
        {
            get { return this._warningUpdatedTime; }
            set { this._warningUpdatedTime = value; }
        }

        // Check to see if WarningUpdatedTime property is set
        internal bool IsSetWarningUpdatedTime()
        {
            return this._warningUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Workflow. 
        /// <para>
        /// The workflow for the resource warning.
        /// </para>
        /// </summary>
        public MinimalWorkflow Workflow
        {
            get { return this._workflow; }
            set { this._workflow = value; }
        }

        // Check to see if Workflow property is set
        internal bool IsSetWorkflow()
        {
            return this._workflow != null;
        }

    }
}