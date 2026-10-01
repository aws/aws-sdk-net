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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains information about the canary's Lambda handler and where its
    /// code is stored by CloudWatch Synthetics.
    /// </summary>
    public partial class CanaryCodeOutput
    {
        /// <summary>
        /// Gets and sets the property BlueprintTypes. 
        /// <para>
        ///  <c>BlueprintTypes</c> is a list of templates that enable simplified canary creation.
        /// You can create canaries for common monitoring scenarios by providing only a JSON configuration
        /// file instead of writing custom scripts. The only supported value is <c>multi-checks</c>.
        /// </para>
        ///  
        /// <para>
        /// Multi-checks monitors HTTP/DNS/SSL/TCP endpoints with built-in authentication schemes
        /// (Basic, API Key, OAuth, SigV4) and assertion capabilities. When you specify <c>BlueprintTypes</c>,
        /// the <c>Handler</c> field cannot be specified since the blueprint provides a pre-defined
        /// entry point.
        /// </para>
        ///  
        /// <para>
        ///  <c>BlueprintTypes</c> is supported only on canaries for syn-nodejs-3.0 runtime or
        /// later.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> BlueprintTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BlueprintTypes property is set.
        /// </summary>
        internal bool IsSetBlueprintTypes() => this.BlueprintTypes != null && (this.BlueprintTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// A list of dependencies that are used for running this canary. The dependencies are
        /// specified as a key-value pair, where the key is the type of dependency and the value
        /// is the dependency reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Dependency> Dependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<Dependency>() : null;

        /// <summary>
        /// Checks to see if the Dependencies property is set.
        /// </summary>
        internal bool IsSetDependencies() => this.Dependencies != null && (this.Dependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The entry point to use for the source code when running the canary.
        /// </para>
        ///  
        /// <para>
        /// This field is required when you don't specify <c>BlueprintTypes</c> and is not allowed
        /// when you specify <c>BlueprintTypes</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Handler { get; set; }

        /// <summary>
        /// Checks to see if the Handler property is set.
        /// </summary>
        internal bool IsSetHandler() => this.Handler != null;

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The ARN of the Lambda layer where Synthetics stores the canary script code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SourceLocationArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationArn property is set.
        /// </summary>
        internal bool IsSetSourceLocationArn() => this.SourceLocationArn != null;
    }
}
