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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains metadata for a verification script that can be used to reproduce a security
    /// finding.
    /// </summary>
    public partial class VerificationScript
    {
        /// <summary>
        /// Gets and sets the property EnvVars. 
        /// <para>
        /// The list of environment variables required to run the verification script.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VerificationScriptEnvVar> EnvVars { get; set; } = AWSConfigs.InitializeCollections ? new List<VerificationScriptEnvVar>() : null;

        /// <summary>
        /// Checks to see if the EnvVars property is set.
        /// </summary>
        internal bool IsSetEnvVars() => this.EnvVars != null && (this.EnvVars.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// Instructions for running the verification script, including prerequisites and how
        /// to interpret results.
        /// </para>
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Checks to see if the Instructions property is set.
        /// </summary>
        internal bool IsSetInstructions() => this.Instructions != null;

        /// <summary>
        /// Gets and sets the property ScriptType. 
        /// <para>
        /// The type of script. Valid values are python and bash.
        /// </para>
        /// </summary>
        public string ScriptType { get; set; }

        /// <summary>
        /// Checks to see if the ScriptType property is set.
        /// </summary>
        internal bool IsSetScriptType() => this.ScriptType != null;

        /// <summary>
        /// Gets and sets the property ScriptUrl. 
        /// <para>
        /// URL to download the verification script.
        /// </para>
        /// </summary>
        public string ScriptUrl { get; set; }

        /// <summary>
        /// Checks to see if the ScriptUrl property is set.
        /// </summary>
        internal bool IsSetScriptUrl() => this.ScriptUrl != null;
    }
}
