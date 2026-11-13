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
    /// Container for the parameters to the CreateRuntime operation. Creates a customer-managed
    /// runtime, a resource providing a centrally managed execution environment for your Lambda
    /// functions. The runtime resource is the parent of the runtime version and runtime alias
    /// child resources.
    /// </summary>
    public partial class CreateRuntimeRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Description. A description of the runtime.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LicenseInfo. The license information for the runtime.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LicenseInfo { get; set; }

        /// <summary>
        /// Checks to see if the LicenseInfo property is set.
        /// </summary>
        internal bool IsSetLicenseInfo() => this.LicenseInfo != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the runtime to create.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReleaseLifecycle. The runtime lifecycle for the runtime
        /// (optional). Use this to schedule runtime deprecation.
        /// </summary>
        public RuntimeReleaseLifecycle ReleaseLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLifecycle property is set.
        /// </summary>
        internal bool IsSetReleaseLifecycle() => this.ReleaseLifecycle != null;

        /// <summary>
        /// Gets and sets the property Tags. A map of tag keys and values to associate with the
        /// runtime.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
