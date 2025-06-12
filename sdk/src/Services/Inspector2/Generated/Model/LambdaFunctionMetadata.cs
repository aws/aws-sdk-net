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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The Amazon Web Services Lambda function metadata.
    /// </summary>
    public partial class LambdaFunctionMetadata
    {
        private string _functionName;
        private Dictionary<string, string> _functionTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _layers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Runtime _runtime;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of a function.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionTags. 
        /// <para>
        /// The resource tags on an Amazon Web Services Lambda function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FunctionTags
        {
            get { return this._functionTags; }
            set { this._functionTags = value; }
        }

        // Check to see if FunctionTags property is set
        internal bool IsSetFunctionTags()
        {
            return this._functionTags != null && (this._functionTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// The layers for an Amazon Web Services Lambda function. A Lambda function can have
        /// up to five layers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> Layers
        {
            get { return this._layers; }
            set { this._layers = value; }
        }

        // Check to see if Layers property is set
        internal bool IsSetLayers()
        {
            return this._layers != null && (this._layers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// An Amazon Web Services Lambda function's runtime.
        /// </para>
        /// </summary>
        public Runtime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

    }
}