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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Specifies the filters to use on the metadata attributes/fields in the knowledge base
    /// data sources before returning results.
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
        private FilterAttribute _listContains;
        private FilterAttribute _notEquals;
        private FilterAttribute _notIn;
        private List<RetrievalFilter> _orAll = AWSConfigs.InitializeCollections ? new List<RetrievalFilter>() : null;
        private FilterAttribute _startsWith;
        private FilterAttribute _stringContains;

        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Knowledge base data sources are returned if their metadata attributes fulfill all
        /// the filter conditions inside this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value matches the value in this object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an animal attribute whose value
        /// is 'cat': <c>"equals": { "key": "animal", "value": "cat" }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is greater than the value in this object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an year attribute whose value
        /// is greater than '1989': <c>"greaterThan": { "key": "year", "value": 1989 }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is greater than or equal to the value in this
        /// object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an year attribute whose value
        /// is greater than or equal to '1989': <c>"greaterThanOrEquals": { "key": "year", "value":
        /// 1989 }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is in the list specified in the value in this
        /// object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an animal attribute that is either
        /// 'cat' or 'dog': <c>"in": { "key": "animal", "value": ["cat", "dog"] }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is less than the value in this object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an year attribute whose value
        /// is less than to '1989': <c>"lessThan": { "key": "year", "value": 1989 }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is less than or equal to the value in this object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an year attribute whose value
        /// is less than or equal to '1989': <c>"lessThanOrEquals": { "key": "year", "value":
        /// 1989 }</c> 
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
        /// Gets and sets the property ListContains. 
        /// <para>
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is a list that contains the value as one of its
        /// members.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an animals attribute that is
        /// a list containing a cat member (for example, <c>["dog", "cat"]</c>): <c>"listContains":
        /// { "key": "animals", "value": "cat" }</c> 
        /// </para>
        /// </summary>
        public FilterAttribute ListContains
        {
            get { return this._listContains; }
            set { this._listContains = value; }
        }

        // Check to see if ListContains property is set
        internal bool IsSetListContains()
        {
            return this._listContains != null;
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Knowledge base data sources that contain a metadata attribute whose name matches the
        /// key and whose value doesn't match the value in this object are returned.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources that don't contain an animal attribute
        /// whose value is 'cat': <c>"notEquals": { "key": "animal", "value": "cat" }</c> 
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value isn't in the list specified in the value in this
        /// object.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources whose animal attribute is neither
        /// 'cat' nor 'dog': <c>"notIn": { "key": "animal", "value": ["cat", "dog"] }</c> 
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
        /// Knowledge base data sources are returned if their metadata attributes fulfill at least
        /// one of the filter conditions inside this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
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
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value starts with the value in this object. This filter
        /// is currently only supported for Amazon OpenSearch Serverless vector stores.
        /// </para>
        ///  
        /// <para>
        /// The following example would return data sources with an animal attribute starts with
        /// 'ca' (for example, 'cat' or 'camel'). <c>"startsWith": { "key": "animal", "value":
        /// "ca" }</c> 
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

        /// <summary>
        /// Gets and sets the property StringContains. 
        /// <para>
        /// Knowledge base data sources are returned if they contain a metadata attribute whose
        /// name matches the key and whose value is one of the following:
        /// </para>
        ///  
        /// <para>
        /// A string that contains the value as a substring. The following example would return
        /// data sources with an animal attribute that contains the substring at (for example,
        /// 'cat'): <c>"stringContains": { "key": "animal", "value": "at" }</c> 
        /// </para>
        ///  
        /// <para>
        /// A list with a member that contains the value as a substring. The following example
        /// would return data sources with an animals attribute that is a list containing a member
        /// that contains the substring at (for example, <c>["dog", "cat"]</c>): <c>"stringContains":
        /// { "key": "animals", "value": "at" }</c> 
        /// </para>
        /// </summary>
        public FilterAttribute StringContains
        {
            get { return this._stringContains; }
            set { this._stringContains = value; }
        }

        // Check to see if StringContains property is set
        internal bool IsSetStringContains()
        {
            return this._stringContains != null;
        }

    }
}