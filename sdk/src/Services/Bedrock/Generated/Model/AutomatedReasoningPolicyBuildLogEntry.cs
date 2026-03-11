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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a single entry in the policy build log, containing information about a
    /// specific step or event in the build process.
    /// </summary>
    public partial class AutomatedReasoningPolicyBuildLogEntry
    {
        private AutomatedReasoningPolicyAnnotation _annotation;
        private List<AutomatedReasoningPolicyBuildStep> _buildSteps = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyBuildStep>() : null;
        private AutomatedReasoningPolicyAnnotationStatus _status;

        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// The annotation or operation that was being processed when this log entry was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyAnnotation Annotation
        {
            get { return this._annotation; }
            set { this._annotation = value; }
        }

        // Check to see if Annotation property is set
        internal bool IsSetAnnotation()
        {
            return this._annotation != null;
        }

        /// <summary>
        /// Gets and sets the property BuildSteps. 
        /// <para>
        /// Detailed information about the specific build steps that were executed, including
        /// any sub-operations or transformations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyBuildStep> BuildSteps
        {
            get { return this._buildSteps; }
            set { this._buildSteps = value; }
        }

        // Check to see if BuildSteps property is set
        internal bool IsSetBuildSteps()
        {
            return this._buildSteps != null && (this._buildSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the build step (e.g., SUCCESS, FAILED, IN_PROGRESS).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyAnnotationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}