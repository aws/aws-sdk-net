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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the operator to use in a property-based condition that filters the results
    /// of a query for findings. For detailed information and examples of each operator, see
    /// <a href="https://docs.aws.amazon.com/macie/latest/user/findings-filter-basics.html">Fundamentals
    /// of filtering findings</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class CriterionAdditionalProperties
    {
        private List<string> _eq = new List<string>();
        private List<string> _eqExactMatch = new List<string>();
        private long? _gt;
        private long? _gte;
        private long? _lt;
        private long? _lte;
        private List<string> _neq = new List<string>();

        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// The value for the property matches (equals) the specified value. If you specify multiple
        /// values, Macie uses OR logic to join the values.
        /// </para>
        /// </summary>
        public List<string> Eq
        {
            get { return this._eq; }
            set { this._eq = value; }
        }

        // Check to see if Eq property is set
        internal bool IsSetEq()
        {
            return this._eq != null && this._eq.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EqExactMatch. 
        /// <para>
        /// The value for the property exclusively matches (equals an exact match for) all the
        /// specified values. If you specify multiple values, Amazon Macie uses AND logic to join
        /// the values.
        /// </para>
        ///  
        /// <para>
        /// You can use this operator with the following properties: customDataIdentifiers.detections.arn,
        /// customDataIdentifiers.detections.name, resourcesAffected.s3Bucket.tags.key, resourcesAffected.s3Bucket.tags.value,
        /// resourcesAffected.s3Object.tags.key, resourcesAffected.s3Object.tags.value, sensitiveData.category,
        /// and sensitiveData.detections.type.
        /// </para>
        /// </summary>
        public List<string> EqExactMatch
        {
            get { return this._eqExactMatch; }
            set { this._eqExactMatch = value; }
        }

        // Check to see if EqExactMatch property is set
        internal bool IsSetEqExactMatch()
        {
            return this._eqExactMatch != null && this._eqExactMatch.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        /// The value for the property is greater than the specified value.
        /// </para>
        /// </summary>
        public long Gt
        {
            get { return this._gt.GetValueOrDefault(); }
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
        /// The value for the property is greater than or equal to the specified value.
        /// </para>
        /// </summary>
        public long Gte
        {
            get { return this._gte.GetValueOrDefault(); }
            set { this._gte = value; }
        }

        // Check to see if Gte property is set
        internal bool IsSetGte()
        {
            return this._gte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        /// The value for the property is less than the specified value.
        /// </para>
        /// </summary>
        public long Lt
        {
            get { return this._lt.GetValueOrDefault(); }
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
        /// The value for the property is less than or equal to the specified value.
        /// </para>
        /// </summary>
        public long Lte
        {
            get { return this._lte.GetValueOrDefault(); }
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
        /// The value for the property doesn't match (doesn't equal) the specified value. If you
        /// specify multiple values, Macie uses OR logic to join the values.
        /// </para>
        /// </summary>
        public List<string> Neq
        {
            get { return this._neq; }
            set { this._neq = value; }
        }

        // Check to see if Neq property is set
        internal bool IsSetNeq()
        {
            return this._neq != null && this._neq.Count > 0; 
        }

    }
}