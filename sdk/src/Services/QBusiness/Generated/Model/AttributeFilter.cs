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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Enables filtering of responses based on document attributes or metadata fields.
    /// </summary>
    public partial class AttributeFilter
    {
        private List<AttributeFilter> _andAllFilters = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;
        private DocumentAttribute _containsAll;
        private DocumentAttribute _containsAny;
        private DocumentAttribute _equalsTo;
        private DocumentAttribute _greaterThan;
        private DocumentAttribute _greaterThanOrEquals;
        private DocumentAttribute _lessThan;
        private DocumentAttribute _lessThanOrEquals;
        private AttributeFilter _notFilter;
        private List<AttributeFilter> _orAllFilters = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;

        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// Performs a logical <c>AND</c> operation on all supplied filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeFilter> AndAllFilters
        {
            get { return this._andAllFilters; }
            set { this._andAllFilters = value; }
        }

        // Check to see if AndAllFilters property is set
        internal bool IsSetAndAllFilters()
        {
            return this._andAllFilters != null && (this._andAllFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainsAll. 
        /// <para>
        /// Returns <c>true</c> when a document contains all the specified document attributes
        /// or metadata fields. Supported for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>stringListValue</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute ContainsAll
        {
            get { return this._containsAll; }
            set { this._containsAll = value; }
        }

        // Check to see if ContainsAll property is set
        internal bool IsSetContainsAll()
        {
            return this._containsAll != null;
        }

        /// <summary>
        /// Gets and sets the property ContainsAny. 
        /// <para>
        /// Returns <c>true</c> when a document contains any of the specified document attributes
        /// or metadata fields. Supported for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>stringListValue</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute ContainsAny
        {
            get { return this._containsAny; }
            set { this._containsAny = value; }
        }

        // Check to see if ContainsAny property is set
        internal bool IsSetContainsAny()
        {
            return this._containsAny != null;
        }

        /// <summary>
        /// Gets and sets the property EqualsTo. 
        /// <para>
        /// Performs an equals operation on two document attributes or metadata fields. Supported
        /// for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>dateValue</c>, <c>longValue</c>, <c>stringListValue</c>
        /// and <c>stringValue</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute EqualsTo
        {
            get { return this._equalsTo; }
            set { this._equalsTo = value; }
        }

        // Check to see if EqualsTo property is set
        internal bool IsSetEqualsTo()
        {
            return this._equalsTo != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Performs a greater than operation on two document attributes or metadata fields. Supported
        /// for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>dateValue</c> and <c>longValue</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute GreaterThan
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
        /// Performs a greater or equals than operation on two document attributes or metadata
        /// fields. Supported for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>dateValue</c> and <c>longValue</c>. 
        /// </para>
        /// </summary>
        public DocumentAttribute GreaterThanOrEquals
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
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Performs a less than operation on two document attributes or metadata fields. Supported
        /// for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value types</a>: <c>dateValue</c> and <c>longValue</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute LessThan
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
        /// Performs a less than or equals operation on two document attributes or metadata fields.Supported
        /// for the following <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeValue.html">document
        /// attribute value type</a>: <c>dateValue</c> and <c>longValue</c>. 
        /// </para>
        /// </summary>
        public DocumentAttribute LessThanOrEquals
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
        /// Gets and sets the property NotFilter. 
        /// <para>
        /// Performs a logical <c>NOT</c> operation on all supplied filters. 
        /// </para>
        /// </summary>
        public AttributeFilter NotFilter
        {
            get { return this._notFilter; }
            set { this._notFilter = value; }
        }

        // Check to see if NotFilter property is set
        internal bool IsSetNotFilter()
        {
            return this._notFilter != null;
        }

        /// <summary>
        /// Gets and sets the property OrAllFilters. 
        /// <para>
        ///  Performs a logical <c>OR</c> operation on all supplied filters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeFilter> OrAllFilters
        {
            get { return this._orAllFilters; }
            set { this._orAllFilters = value; }
        }

        // Check to see if OrAllFilters property is set
        internal bool IsSetOrAllFilters()
        {
            return this._orAllFilters != null && (this._orAllFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}