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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<OcsfBooleanFilter> _booleanFilters = AWSConfigs.InitializeCollections ? new List<OcsfBooleanFilter>() : null;
        private List<OcsfDateFilter> _dateFilters = AWSConfigs.InitializeCollections ? new List<OcsfDateFilter>() : null;
        private List<OcsfMapFilter> _mapFilters = AWSConfigs.InitializeCollections ? new List<OcsfMapFilter>() : null;
        private List<OcsfNumberFilter> _numberFilters = AWSConfigs.InitializeCollections ? new List<OcsfNumberFilter>() : null;
        private AllowedOperators _operator;
        private List<OcsfStringFilter> _stringFilters = AWSConfigs.InitializeCollections ? new List<OcsfStringFilter>() : null;

        /// <summary>
        /// Gets and sets the property BooleanFilters. 
        /// <para>
        /// Enables filtering based on boolean field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfBooleanFilter> BooleanFilters
        {
            get { return this._booleanFilters; }
            set { this._booleanFilters = value; }
        }

        // Check to see if BooleanFilters property is set
        internal bool IsSetBooleanFilters()
        {
            return this._booleanFilters != null && (this._booleanFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DateFilters. 
        /// <para>
        /// Enables filtering based on date and timestamp fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfDateFilter> DateFilters
        {
            get { return this._dateFilters; }
            set { this._dateFilters = value; }
        }

        // Check to see if DateFilters property is set
        internal bool IsSetDateFilters()
        {
            return this._dateFilters != null && (this._dateFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapFilters. 
        /// <para>
        /// Enables filtering based on map field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfMapFilter> MapFilters
        {
            get { return this._mapFilters; }
            set { this._mapFilters = value; }
        }

        // Check to see if MapFilters property is set
        internal bool IsSetMapFilters()
        {
            return this._mapFilters != null && (this._mapFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberFilters. 
        /// <para>
        /// Enables filtering based on numerical field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfNumberFilter> NumberFilters
        {
            get { return this._numberFilters; }
            set { this._numberFilters = value; }
        }

        // Check to see if NumberFilters property is set
        internal bool IsSetNumberFilters()
        {
            return this._numberFilters != null && (this._numberFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The logical operator used to combine multiple filter conditions.
        /// </para>
        /// </summary>
        public AllowedOperators Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property StringFilters. 
        /// <para>
        /// Enables filtering based on string field values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OcsfStringFilter> StringFilters
        {
            get { return this._stringFilters; }
            set { this._stringFilters = value; }
        }

        // Check to see if StringFilters property is set
        internal bool IsSetStringFilters()
        {
            return this._stringFilters != null && (this._stringFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}