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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about an Automation failure.
    /// </summary>
    public partial class FailureDetails
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Detailed information about the Automation step failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, List<string>> Details { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureStage. 
        /// <para>
        /// The stage of the Automation execution when the failure occurred. The stages include
        /// the following: InputValidation, PreVerification, Invocation, PostVerification.
        /// </para>
        /// </summary>
        public string FailureStage { get; set; }

        /// <summary>
        /// Checks to see if the FailureStage property is set.
        /// </summary>
        internal bool IsSetFailureStage() => this.FailureStage != null;

        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// The type of Automation failure. Failure types include the following: Action, Permission,
        /// Throttling, Verification, Internal.
        /// </para>
        /// </summary>
        public string FailureType { get; set; }

        /// <summary>
        /// Checks to see if the FailureType property is set.
        /// </summary>
        internal bool IsSetFailureType() => this.FailureType != null;
    }
}
