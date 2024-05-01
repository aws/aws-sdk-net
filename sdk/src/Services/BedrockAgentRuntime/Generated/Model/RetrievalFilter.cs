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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Specifies the filters to use on the metadata attributes in the knowledge base data
    /// sources before returning results. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html">Query
    /// configurations</a>.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_RequestSyntax">Retrieve
    /// request</a> – in the <c>filter</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> – in the <c>filter</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetrievalFilter
    {
        private List<RetrievalFilter> _andAll = AWSConfigs.InitializeCollections ? new List<RetrievalFilter>() : null;
        private FilterAttribute _equals;
        private FilterAttribute _greaterThan;
        private FilterAttribute _greaterThanOrEquals;
        private FilterAttribute _in;
        private FilterAttribute _lessThan;
        private FilterAttribute _lessThanOrEquals;
        private FilterAttribute _notEquals;
        private FilterAttribute _notIn;
        private List<RetrievalFilter> _orAll = AWSConfigs.InitializeCollections ? new List<RetrievalFilter>() : null;
        private FilterAttribute _startsWith;

        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Knowledge base data sources whose metadata attributes fulfill all the filter conditions
        /// inside this list are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public List<RetrievalFilter> AndAll
        {
            get { return this._andAll; }
            set { this._andAll = value; }
        }

        // Check to see if AndAll property is set
        internal bool IsSetAndAll()
        {
            return this._andAll != null && (this._andAll.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value matches the <c>value</c> in this object are returned.
        /// </para>
        /// </summary>
        public new FilterAttribute Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value is greater than the <c>value</c> in this object are returned.
        /// </para>
        /// </summary>
        public FilterAttribute GreaterThan
        {
            get { return this._greaterThan; }
            set { this._greaterThan = value; }
        }

        // Check to see if GreaterThan property is set
        internal bool IsSetGreaterThan()
        {
            return this._greaterThan != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThanOrEquals. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value is greater than or equal to the <c>value</c> in this object
        /// are returned.
        /// </para>
        /// </summary>
        public FilterAttribute GreaterThanOrEquals
        {
            get { return this._greaterThanOrEquals; }
            set { this._greaterThanOrEquals = value; }
        }

        // Check to see if GreaterThanOrEquals property is set
        internal bool IsSetGreaterThanOrEquals()
        {
            return this._greaterThanOrEquals != null;
        }

        /// <summary>
        /// Gets and sets the property In. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value is in the list specified in the <c>value</c> in this object
        /// are returned.
        /// </para>
        /// </summary>
        public FilterAttribute In
        {
            get { return this._in; }
            set { this._in = value; }
        }

        // Check to see if In property is set
        internal bool IsSetIn()
        {
            return this._in != null;
        }

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value is less than the <c>value</c> in this object are returned.
        /// </para>
        /// </summary>
        public FilterAttribute LessThan
        {
            get { return this._lessThan; }
            set { this._lessThan = value; }
        }

        // Check to see if LessThan property is set
        internal bool IsSetLessThan()
        {
            return this._lessThan != null;
        }

        /// <summary>
        /// Gets and sets the property LessThanOrEquals. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value is less than or equal to the <c>value</c> in this object
        /// are returned.
        /// </para>
        /// </summary>
        public FilterAttribute LessThanOrEquals
        {
            get { return this._lessThanOrEquals; }
            set { this._lessThanOrEquals = value; }
        }

        // Check to see if LessThanOrEquals property is set
        internal bool IsSetLessThanOrEquals()
        {
            return this._lessThanOrEquals != null;
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value doesn't match the <c>value</c> in this object are returned.
        /// </para>
        /// </summary>
        public FilterAttribute NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null;
        }

        /// <summary>
        /// Gets and sets the property NotIn. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value isn't in the list specified in the <c>value</c> in this
        /// object are returned.
        /// </para>
        /// </summary>
        public FilterAttribute NotIn
        {
            get { return this._notIn; }
            set { this._notIn = value; }
        }

        // Check to see if NotIn property is set
        internal bool IsSetNotIn()
        {
            return this._notIn != null;
        }

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Knowledge base data sources whose metadata attributes fulfill at least one of the
        /// filter conditions inside this list are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public List<RetrievalFilter> OrAll
        {
            get { return this._orAll; }
            set { this._orAll = value; }
        }

        // Check to see if OrAll property is set
        internal bool IsSetOrAll()
        {
            return this._orAll != null && (this._orAll.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// <c>key</c> and whose value starts with the <c>value</c> in this object are returned.
        /// This filter is currently only supported for Amazon OpenSearch Serverless vector stores.
        /// </para>
        /// </summary>
        public FilterAttribute StartsWith
        {
            get { return this._startsWith; }
            set { this._startsWith = value; }
        }

        // Check to see if StartsWith property is set
        internal bool IsSetStartsWith()
        {
            return this._startsWith != null;
        }

    }
}