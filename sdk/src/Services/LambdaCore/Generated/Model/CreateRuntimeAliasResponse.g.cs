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
    /// This is the response object from the CreateRuntimeAlias operation.
    /// </summary>
    public partial class CreateRuntimeAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) of the runtime alias.
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Created. The date and time when the runtime alias was created.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created != null;

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
        /// Gets and sets the property LastModified. The date and time when the runtime alias
        /// was last modified.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the runtime alias.
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
        /// Gets and sets the property RuntimeVersion. The name of the runtime version the alias
        /// points to.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersionArn. The Amazon Resource Name (ARN) of the
        /// runtime version the alias points to.
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 2048)]
        public string RuntimeVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersionArn property is set.
        /// </summary>
        internal bool IsSetRuntimeVersionArn() => this.RuntimeVersionArn != null;

        /// <summary>
        /// Gets and sets the property State. The current state of the runtime alias.
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeAliasState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
