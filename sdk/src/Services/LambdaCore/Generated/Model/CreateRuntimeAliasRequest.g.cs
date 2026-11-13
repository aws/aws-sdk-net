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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRuntimeAlias operation. Creates a new customer-managed
    /// runtime alias. The alias is a named pointer to a runtime version. Functions consume
    /// the customer-managed runtime through the runtime alias.
    /// </summary>
    public partial class CreateRuntimeAliasRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Description. A description of the runtime alias.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. The name to assign to the new runtime alias.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReleaseLifecycle. The runtime lifecycle for the alias.
        /// By default, this is inherited from the runtime lifecycle. Optionally, you can override
        /// the lifecycle information at the alias level, if required.
        /// </summary>
        public RuntimeReleaseLifecycle ReleaseLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLifecycle property is set.
        /// </summary>
        internal bool IsSetReleaseLifecycle() => this.ReleaseLifecycle != null;

        /// <summary>
        /// Gets and sets the property RuntimeName. The name or ARN of the runtime to create an
        /// alias for.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string RuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeName property is set.
        /// </summary>
        internal bool IsSetRuntimeName() => this.RuntimeName != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersion. The name of the runtime version the alias
        /// points to.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;
    }
}
