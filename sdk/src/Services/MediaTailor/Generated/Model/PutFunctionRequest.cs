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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the PutFunction operation.
    /// Creates or updates a function. A function defines reusable logic that MediaTailor
    /// executes at lifecycle hooks during ad insertion. For more information about functions,
    /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
    /// with functions</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class PutFunctionRequest : AmazonMediaTailorRequest
    {
        private CustomOutputConfiguration _customOutputConfiguration;
        private string _description;
        private string _functionId;
        private FunctionType _functionType;
        private HttpRequestConfiguration _httpRequestConfiguration;
        private SequentialExecutorConfiguration _sequentialExecutorConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CustomOutputConfiguration. 
        /// <para>
        /// The configuration for a <c>CUSTOM_OUTPUT</c> function. Specifies the runtime and output
        /// expressions. Required when <c>FunctionType</c> is <c>CUSTOM_OUTPUT</c>.
        /// </para>
        /// </summary>
        public CustomOutputConfiguration CustomOutputConfiguration
        {
            get { return this._customOutputConfiguration; }
            set { this._customOutputConfiguration = value; }
        }

        // Check to see if CustomOutputConfiguration property is set
        internal bool IsSetCustomOutputConfiguration()
        {
            return this._customOutputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the function.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the function. The identifier must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionId
        {
            get { return this._functionId; }
            set { this._functionId = value; }
        }

        // Check to see if FunctionId property is set
        internal bool IsSetFunctionId()
        {
            return this._functionId != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionType. 
        /// <para>
        /// The type of the function. The function type determines what the function can do at
        /// runtime. Valid values: <c>CUSTOM_OUTPUT</c> evaluates expressions and produces output
        /// bindings with no external calls. <c>HTTP_REQUEST</c> makes an HTTP call to an external
        /// service and evaluates output expressions that can reference the response. <c>SEQUENTIAL_EXECUTOR</c>
        /// runs a sequence of child functions in order, passing data between steps through temporary
        /// data. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-types.html">Function
        /// types and composition</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionType FunctionType
        {
            get { return this._functionType; }
            set { this._functionType = value; }
        }

        // Check to see if FunctionType property is set
        internal bool IsSetFunctionType()
        {
            return this._functionType != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRequestConfiguration. 
        /// <para>
        /// The configuration for an <c>HTTP_REQUEST</c> function. Specifies the HTTP method,
        /// URL, headers, body, timeout, and output expressions. Required when <c>FunctionType</c>
        /// is <c>HTTP_REQUEST</c>.
        /// </para>
        /// </summary>
        public HttpRequestConfiguration HttpRequestConfiguration
        {
            get { return this._httpRequestConfiguration; }
            set { this._httpRequestConfiguration = value; }
        }

        // Check to see if HttpRequestConfiguration property is set
        internal bool IsSetHttpRequestConfiguration()
        {
            return this._httpRequestConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SequentialExecutorConfiguration. 
        /// <para>
        /// The configuration for a <c>SEQUENTIAL_EXECUTOR</c> function. Specifies the ordered
        /// list of child functions to execute, an optional output block, and a timeout. Required
        /// when <c>FunctionType</c> is <c>SEQUENTIAL_EXECUTOR</c>.
        /// </para>
        /// </summary>
        public SequentialExecutorConfiguration SequentialExecutorConfiguration
        {
            get { return this._sequentialExecutorConfiguration; }
            set { this._sequentialExecutorConfiguration = value; }
        }

        // Check to see if SequentialExecutorConfiguration property is set
        internal bool IsSetSequentialExecutorConfiguration()
        {
            return this._sequentialExecutorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the function. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}