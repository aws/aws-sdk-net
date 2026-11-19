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
    /// Container for the parameters to the UpdateRuntime operation. Updates the properties
    /// of an existing customer-managed runtime, such as its description, license information,
    /// or lifecycle information.
    /// </summary>
    public partial class UpdateRuntimeRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Description. The updated description of the runtime.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LicenseInfo. The updated license information for the runtime.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LicenseInfo { get; set; }

        /// <summary>
        /// Checks to see if the LicenseInfo property is set.
        /// </summary>
        internal bool IsSetLicenseInfo() => this.LicenseInfo != null;

        /// <summary>
        /// Gets and sets the property ReleaseLifecycle. The runtime lifecycle for the runtime.
        /// Optional. Used to schedule runtime deprecation. Omitting or providing an empty object
        /// removes the existing lifecycle.
        /// </summary>
        public RuntimeReleaseLifecycle ReleaseLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLifecycle property is set.
        /// </summary>
        internal bool IsSetReleaseLifecycle() => this.ReleaseLifecycle != null;

        /// <summary>
        /// Gets and sets the property RuntimeName. The name or ARN of the runtime to update.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string RuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeName property is set.
        /// </summary>
        internal bool IsSetRuntimeName() => this.RuntimeName != null;
    }
}
