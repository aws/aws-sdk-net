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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
        private List<string> _blueprintTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Dependency> _dependencies = AWSConfigs.InitializeCollections ? new List<Dependency>() : null;
        private string _handler;
        private string _sourceLocationArn;

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
        /// the Handler field cannot be specified since the blueprint provides a pre-defined entry
        /// point.
        /// </para>
        ///  
        /// <para>
        ///  <c>BlueprintTypes</c> is supported only on canaries for syn-nodejs-3.0 runtime or
        /// later.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> BlueprintTypes
        {
            get { return this._blueprintTypes; }
            set { this._blueprintTypes = value; }
        }

        // Check to see if BlueprintTypes property is set
        internal bool IsSetBlueprintTypes()
        {
            return this._blueprintTypes != null && (this._blueprintTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// A list of dependencies that are used for running this canary. The dependencies are
        /// specified as a key-value pair, where the key is the type of dependency and the value
        /// is the dependency reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Dependency> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=1024)]
        public string Handler
        {
            get { return this._handler; }
            set { this._handler = value; }
        }

        // Check to see if Handler property is set
        internal bool IsSetHandler()
        {
            return this._handler != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationArn. 
        /// <para>
        /// The ARN of the Lambda layer where Synthetics stores the canary script code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SourceLocationArn
        {
            get { return this._sourceLocationArn; }
            set { this._sourceLocationArn = value; }
        }

        // Check to see if SourceLocationArn property is set
        internal bool IsSetSourceLocationArn()
        {
            return this._sourceLocationArn != null;
        }

    }
}