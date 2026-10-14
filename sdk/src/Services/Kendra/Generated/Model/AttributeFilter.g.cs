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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Filters the search results based on document attributes or fields.
    /// 
    ///  
    /// <para>
    /// You can filter results using attributes for your particular documents. The attributes
    /// must exist in your index. For example, if your documents include the custom attribute
    /// "Department", you can filter documents that belong to the "HR" department. You would
    /// use the <c>EqualsTo</c> operation to filter results or documents with "Department"
    /// equals to "HR".
    /// </para>
    ///  
    /// <para>
    /// You can use <c>AndAllFilters</c> and <c>OrAllFilters</c> in combination with each
    /// other or with other operations such as <c>EqualsTo</c>. For example:
    /// </para>
    ///  
    /// <para>
    ///  <c>AndAllFilters</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>EqualsTo</c>: "Department", "HR"
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OrAllFilters</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ContainsAny</c>: "Project Name", ["new hires", "new hiring"]
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// This example filters results or documents that belong to the HR department <c>AND</c>
    /// belong to projects that contain "new hires" <c>OR</c> "new hiring" in the project
    /// name (must use <c>ContainAny</c> with <c>StringListValue</c>). This example is filtering
    /// with a depth of 2.
    /// </para>
    ///  
    /// <para>
    /// You cannot filter more than a depth of 2, otherwise you receive a <c>ValidationException</c>
    /// exception with the message "AttributeFilter cannot have a depth of more than 2." Also,
    /// if you use more than 10 attribute filters in a given list for <c>AndAllFilters</c>
    /// or <c>OrAllFilters</c>, you receive a <c>ValidationException</c> with the message
    /// "AttributeFilter cannot have a length of more than 10".
    /// </para>
    ///  
    /// <para>
    /// For examples of using <c>AttributeFilter</c>, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/filtering.html#search-filtering">Using
    /// document attributes to filter search results</a>.
    /// </para>
    /// </summary>
    public partial class AttributeFilter
    {
        /// <summary>
        /// Gets and sets the property AndAllFilters. 
        /// <para>
        /// Performs a logical <c>AND</c> operation on all filters that you specify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeFilter> AndAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;

        /// <summary>
        /// Checks to see if the AndAllFilters property is set.
        /// </summary>
        internal bool IsSetAndAllFilters() => this.AndAllFilters != null && (this.AndAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainsAll. 
        /// <para>
        /// Returns true when a document contains all of the specified document attributes/fields.
        /// This filter is only applicable to <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">StringListValue</a>.
        /// </para>
        /// </summary>
        public DocumentAttribute ContainsAll { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAll property is set.
        /// </summary>
        internal bool IsSetContainsAll() => this.ContainsAll != null;

        /// <summary>
        /// Gets and sets the property ContainsAny. 
        /// <para>
        /// Returns true when a document contains any of the specified document attributes/fields.
        /// This filter is only applicable to <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">StringListValue</a>.
        /// </para>
        /// </summary>
        public DocumentAttribute ContainsAny { get; set; }

        /// <summary>
        /// Checks to see if the ContainsAny property is set.
        /// </summary>
        internal bool IsSetContainsAny() => this.ContainsAny != null;

        /// <summary>
        /// Gets and sets the property EqualsTo. 
        /// <para>
        /// Performs an equals operation on document attributes/fields and their values.
        /// </para>
        /// </summary>
        public DocumentAttribute EqualsTo { get; set; }

        /// <summary>
        /// Checks to see if the EqualsTo property is set.
        /// </summary>
        internal bool IsSetEqualsTo() => this.EqualsTo != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Performs a greater than operation on document attributes/fields and their values.
        /// Use with the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">document
        /// attribute type</a> <c>Date</c> or <c>Long</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan != null;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEquals. 
        /// <para>
        /// Performs a greater or equals than operation on document attributes/fields and their
        /// values. Use with the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">document
        /// attribute type</a> <c>Date</c> or <c>Long</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute GreaterThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEquals property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEquals() => this.GreaterThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Performs a less than operation on document attributes/fields and their values. Use
        /// with the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">document
        /// attribute type</a> <c>Date</c> or <c>Long</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan != null;

        /// <summary>
        /// Gets and sets the property LessThanOrEquals. 
        /// <para>
        /// Performs a less than or equals operation on document attributes/fields and their values.
        /// Use with the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_DocumentAttributeValue.html">document
        /// attribute type</a> <c>Date</c> or <c>Long</c>.
        /// </para>
        /// </summary>
        public DocumentAttribute LessThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEquals property is set.
        /// </summary>
        internal bool IsSetLessThanOrEquals() => this.LessThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property NotFilter. 
        /// <para>
        /// Performs a logical <c>NOT</c> operation on all filters that you specify.
        /// </para>
        /// </summary>
        public AttributeFilter NotFilter { get; set; }

        /// <summary>
        /// Checks to see if the NotFilter property is set.
        /// </summary>
        internal bool IsSetNotFilter() => this.NotFilter != null;

        /// <summary>
        /// Gets and sets the property OrAllFilters. 
        /// <para>
        /// Performs a logical <c>OR</c> operation on all filters that you specify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeFilter> OrAllFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;

        /// <summary>
        /// Checks to see if the OrAllFilters property is set.
        /// </summary>
        internal bool IsSetOrAllFilters() => this.OrAllFilters != null && (this.OrAllFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
