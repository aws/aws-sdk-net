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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The specification of the remediation target guidance. This outlines required resource
    /// parameters and permissions, remediation steps, and the end state.
    /// </summary>
    public partial class RemediationGuidanceSpecification
    {
        /// <summary>
        /// Gets and sets the property ExpectedEndState. 
        /// <para>
        /// The expected end state of the associated resources after completion of the steps.
        /// </para>
        /// </summary>
        public string ExpectedEndState { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedEndState property is set.
        /// </summary>
        internal bool IsSetExpectedEndState() => this.ExpectedEndState != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An array of the parameters used in running the steps provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<RemediationParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<RemediationParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequiredPermissions. 
        /// <para>
        /// An array of required permissions to run the steps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RequiredPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredPermissions property is set.
        /// </summary>
        internal bool IsSetRequiredPermissions() => this.RequiredPermissions != null && (this.RequiredPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// An array of ordered steps for resolving the remediation targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<RemediationStep> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<RemediationStep>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
