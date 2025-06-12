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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the condition.
    /// </summary>
    public partial class Condition
    {
        private List<string> _eq = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _equals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _greaterThan;
        private long? _greaterThanOrEqual;
        private int? _gt;
        private int? _gte;
        private long? _lessThan;
        private long? _lessThanOrEqual;
        private int? _lt;
        private int? _lte;
        private List<string> _neq = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notEquals = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// Represents the <i>equal</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and the Equals property should be used instead.")]
        public List<string> Eq
        {
            get { return this._eq; }
            set { this._eq = value; }
        }

        // Check to see if Eq property is set
        internal bool IsSetEq()
        {
            return this._eq != null && (this._eq.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Represents an <i>equal</i> <b/> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public new List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && (this._equals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        public long? GreaterThan
        {
            get { return this._greaterThan; }
            set { this._greaterThan = value; }
        }

        // Check to see if GreaterThan property is set
        internal bool IsSetGreaterThan()
        {
            return this._greaterThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreaterThanOrEqual. 
        /// <para>
        /// Represents a <i>greater than or equal</i> condition to be applied to a single field
        /// when querying for findings.
        /// </para>
        /// </summary>
        public long? GreaterThanOrEqual
        {
            get { return this._greaterThanOrEqual; }
            set { this._greaterThanOrEqual = value; }
        }

        // Check to see if GreaterThanOrEqual property is set
        internal bool IsSetGreaterThanOrEqual()
        {
            return this._greaterThanOrEqual.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the GreaterThan property should be used instead.")]
        public int? Gt
        {
            get { return this._gt; }
            set { this._gt = value; }
        }

        // Check to see if Gt property is set
        internal bool IsSetGt()
        {
            return this._gt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gte. 
        /// <para>
        /// Represents a <i>greater than or equal</i> condition to be applied to a single field
        /// when querying for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the GreaterThanOrEqual property should be used instead.")]
        public int? Gte
        {
            get { return this._gte; }
            set { this._gte = value; }
        }

        // Check to see if Gte property is set
        internal bool IsSetGte()
        {
            return this._gte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        public long? LessThan
        {
            get { return this._lessThan; }
            set { this._lessThan = value; }
        }

        // Check to see if LessThan property is set
        internal bool IsSetLessThan()
        {
            return this._lessThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LessThanOrEqual. 
        /// <para>
        /// Represents a <i>less than or equal</i> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        /// </summary>
        public long? LessThanOrEqual
        {
            get { return this._lessThanOrEqual; }
            set { this._lessThanOrEqual = value; }
        }

        // Check to see if LessThanOrEqual property is set
        internal bool IsSetLessThanOrEqual()
        {
            return this._lessThanOrEqual.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the LessThan property should be used instead.")]
        public int? Lt
        {
            get { return this._lt; }
            set { this._lt = value; }
        }

        // Check to see if Lt property is set
        internal bool IsSetLt()
        {
            return this._lt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// Represents a <i>less than or equal</i> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the LessThanOrEqual property should be used instead.")]
        public int? Lte
        {
            get { return this._lte; }
            set { this._lte = value; }
        }

        // Check to see if Lte property is set
        internal bool IsSetLte()
        {
            return this._lte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neq. 
        /// <para>
        /// Represents the <i>not equal</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and the NotEquals property should be used instead.")]
        public List<string> Neq
        {
            get { return this._neq; }
            set { this._neq = value; }
        }

        // Check to see if Neq property is set
        internal bool IsSetNeq()
        {
            return this._neq != null && (this._neq.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Represents a <i>not equal</i> <b/> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && (this._notEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}