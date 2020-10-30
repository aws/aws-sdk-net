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
    /// of a query for findings.
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
        /// An equal to condition to apply to a specified property value for findings.
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
        /// A condition that requires an array field on a finding to exactly match the specified
        /// property values. You can use this operator with the following properties:
        /// </para>
        /// <ul><li>
        /// <para>
        /// customDataIdentifiers.detections.arn
        /// </para>
        /// </li><li>
        /// <para>
        /// customDataIdentifiers.detections.name
        /// </para>
        /// </li><li>
        /// <para>
        /// resourcesAffected.s3Bucket.tags.key
        /// </para>
        /// </li><li>
        /// <para>
        /// resourcesAffected.s3Bucket.tags.value
        /// </para>
        /// </li><li>
        /// <para>
        /// resourcesAffected.s3Object.tags.key
        /// </para>
        /// </li><li>
        /// <para>
        /// resourcesAffected.s3Object.tags.value
        /// </para>
        /// </li><li>
        /// <para>
        /// sensitiveData.category
        /// </para>
        /// </li><li>
        /// <para>
        /// sensitiveData.detections.type
        /// </para>
        /// </li></ul>
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
        /// A greater than condition to apply to a specified property value for findings.
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
        /// A greater than or equal to condition to apply to a specified property value for findings.
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
        /// A less than condition to apply to a specified property value for findings.
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
        /// A less than or equal to condition to apply to a specified property value for findings.
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
        /// A not equal to condition to apply to a specified property value for findings.
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