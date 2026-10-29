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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartRemediationExecution operation. Runs an on-demand
    /// remediation for the specified Config rules against the last known remediation configuration.
    /// It runs an execution against the current state of your resources. Remediation execution
    /// is asynchronous. <para> You can specify up to 100 resource keys per request. An existing
    /// StartRemediationExecution call for the specified resource keys must complete before
    /// you can call the API again. </para>
    /// </summary>
    public partial class StartRemediationExecutionRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The list of names of Config rules that you want to run remediation execution for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property ResourceKeys. 
        /// <para>
        /// A list of resource keys to be processed with the current request. Each element in
        /// the list consists of the resource type and resource ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<ResourceKey> ResourceKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceKey>() : null;

        /// <summary>
        /// Checks to see if the ResourceKeys property is set.
        /// </summary>
        internal bool IsSetResourceKeys() => this.ResourceKeys != null && (this.ResourceKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
