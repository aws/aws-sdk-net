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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration for filtering content during retrieval operations.
    /// </summary>
    public partial class RetrievalFilterConfiguration
    {
        private List<RetrievalFilterConfiguration> _andAll = AWSConfigs.InitializeCollections ? new List<RetrievalFilterConfiguration>() : null;
        private FilterAttribute _equals;
        private FilterAttribute _greaterThan;
        private FilterAttribute _greaterThanOrEquals;
        private FilterAttribute _in;
        private FilterAttribute _lessThan;
        private FilterAttribute _lessThanOrEquals;
        private FilterAttribute _listContains;
        private FilterAttribute _notEquals;
        private FilterAttribute _notIn;
        private List<RetrievalFilterConfiguration> _orAll = AWSConfigs.InitializeCollections ? new List<RetrievalFilterConfiguration>() : null;
        private FilterAttribute _startsWith;
        private FilterAttribute _stringContains;

        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Filter configuration that requires all conditions to be met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<RetrievalFilterConfiguration> AndAll
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
        /// Filter configuration for exact equality matching.
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
        /// Filter configuration for greater than comparison.
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
        /// Filter configuration for greater than or equal comparison.
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
        /// Filter configuration for membership in a set of values.
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
        /// Filter configuration for less than comparison.
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
        /// Filter configuration for less than or equal comparison.
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
        /// Filter configuration for checking if a list contains a value.
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
        /// Filter configuration for inequality matching.
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
        /// Filter configuration for exclusion from a set of values.
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
        /// Filter configuration where any condition can be met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<RetrievalFilterConfiguration> OrAll
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
        /// Filter configuration for prefix matching.
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
        /// Filter configuration for substring matching.
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