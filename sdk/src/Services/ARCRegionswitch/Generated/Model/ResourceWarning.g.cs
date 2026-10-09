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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Represents a warning about a resource in a Region switch plan.
    /// </summary>
    public partial class ResourceWarning
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step for the resource warning.
        /// </para>
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the resource warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// The warning message about what needs to be corrected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;

        /// <summary>
        /// Gets and sets the property WarningStatus. 
        /// <para>
        /// The status of the resource warning.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceWarningStatus WarningStatus { get; set; }

        /// <summary>
        /// Checks to see if the WarningStatus property is set.
        /// </summary>
        internal bool IsSetWarningStatus() => this.WarningStatus != null;

        /// <summary>
        /// Gets and sets the property WarningUpdatedTime. 
        /// <para>
        /// The timestamp when the warning was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? WarningUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the WarningUpdatedTime property is set.
        /// </summary>
        internal bool IsSetWarningUpdatedTime() => this.WarningUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Workflow. 
        /// <para>
        /// The workflow for the resource warning.
        /// </para>
        /// </summary>
        public MinimalWorkflow Workflow { get; set; }

        /// <summary>
        /// Checks to see if the Workflow property is set.
        /// </summary>
        internal bool IsSetWorkflow() => this.Workflow != null;
    }
}
