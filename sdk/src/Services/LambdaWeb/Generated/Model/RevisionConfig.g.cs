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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The configuration for a web function revision, including code build settings and service
    /// configuration.
    /// </summary>
    public partial class RevisionConfig
    {
        /// <summary>
        /// Gets and sets the property BuildConfig. 
        /// <para>
        /// The build configuration for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BuildConfig BuildConfig { get; set; }

        /// <summary>
        /// Checks to see if the BuildConfig property is set.
        /// </summary>
        internal bool IsSetBuildConfig() => this.BuildConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Key Management Service (AWS KMS) key used
        /// to encrypt the revision's code and environment variables.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ServiceConfig. 
        /// <para>
        /// The service configuration for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceConfig ServiceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServiceConfig property is set.
        /// </summary>
        internal bool IsSetServiceConfig() => this.ServiceConfig != null;
    }
}
