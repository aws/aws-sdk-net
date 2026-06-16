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
    /// -- Define Mixin --
    /// </summary>
    public partial class PutFunctionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private CustomOutputConfiguration _customOutputConfiguration;
        private string _description;
        private string _functionId;
        private FunctionType _functionType;
        private HttpRequestConfiguration _httpRequestConfiguration;
        private SequentialExecutorConfiguration _sequentialExecutorConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomOutputConfiguration. 
        /// <para>
        /// The configuration for a <c>CUSTOM_OUTPUT</c> function.
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
        /// The identifier of the function.
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
        /// The type of the function.
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
        /// The configuration for an <c>HTTP_REQUEST</c> function.
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
        /// The configuration for a <c>SEQUENTIAL_EXECUTOR</c> function.
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
        /// The tags assigned to the function. Tags are key-value pairs that you can associate
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