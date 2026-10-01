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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Enables the creation of filtering criteria for security findings.
    /// </summary>
    public partial class CompositeFilter
    {
        /// <summary>
        /// Gets and sets the property BooleanFilters. 
        /// <para>
        /// Enables filtering based on boolean field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfBooleanFilter> BooleanFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfBooleanFilter>() : null;

        /// <summary>
        /// Checks to see if the BooleanFilters property is set.
        /// </summary>
        internal bool IsSetBooleanFilters() => this.BooleanFilters != null && (this.BooleanFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DateFilters. 
        /// <para>
        /// Enables filtering based on date and timestamp fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfDateFilter> DateFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfDateFilter>() : null;

        /// <summary>
        /// Checks to see if the DateFilters property is set.
        /// </summary>
        internal bool IsSetDateFilters() => this.DateFilters != null && (this.DateFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpFilters. 
        /// <para>
        /// A list of IP address filters that allowing you to filter findings based on IP address
        /// properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfIpFilter> IpFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfIpFilter>() : null;

        /// <summary>
        /// Checks to see if the IpFilters property is set.
        /// </summary>
        internal bool IsSetIpFilters() => this.IpFilters != null && (this.IpFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapFilters. 
        /// <para>
        /// Enables filtering based on map field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfMapFilter> MapFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfMapFilter>() : null;

        /// <summary>
        /// Checks to see if the MapFilters property is set.
        /// </summary>
        internal bool IsSetMapFilters() => this.MapFilters != null && (this.MapFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NestedCompositeFilters. 
        /// <para>
        ///  Provides an additional level of filtering, creating a three-layer nested structure.
        /// The first layer is a <c>CompositeFilters</c> array with a <c>CompositeOperator</c>
        /// (<c>AND</c>/<c>OR</c>). The second layer is a <c>CompositeFilter</c> object that contains
        /// direct filters and <c>NestedCompositeFilters</c>. The third layer is <c>NestedCompositeFilters</c>,
        /// which contains additional filter conditions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CompositeFilter> NestedCompositeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<CompositeFilter>() : null;

        /// <summary>
        /// Checks to see if the NestedCompositeFilters property is set.
        /// </summary>
        internal bool IsSetNestedCompositeFilters() => this.NestedCompositeFilters != null && (this.NestedCompositeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberFilters. 
        /// <para>
        /// Enables filtering based on numerical field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfNumberFilter> NumberFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfNumberFilter>() : null;

        /// <summary>
        /// Checks to see if the NumberFilters property is set.
        /// </summary>
        internal bool IsSetNumberFilters() => this.NumberFilters != null && (this.NumberFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The logical operator used to combine multiple filter conditions.
        /// </para>
        /// </summary>
        public AllowedOperators Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property StringFilters. 
        /// <para>
        /// Enables filtering based on string field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfStringFilter> StringFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OcsfStringFilter>() : null;

        /// <summary>
        /// Checks to see if the StringFilters property is set.
        /// </summary>
        internal bool IsSetStringFilters() => this.StringFilters != null && (this.StringFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
