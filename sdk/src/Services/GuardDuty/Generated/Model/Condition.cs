/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Finding attribute (for example, accountId) for which conditions and values must be
    /// specified when querying findings.
    /// </summary>
    public partial class Condition
    {
        private List<string> _eq = new List<string>();
        private int? _gt;
        private int? _gte;
        private int? _lt;
        private int? _lte;
        private List<string> _neq = new List<string>();

        /// <summary>
        /// Gets and sets the property Eq. Represents the equal condition to be applied to a single
        /// field when querying for findings.
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
        /// Gets and sets the property Gt. Represents the greater than condition to be applied
        /// to a single field when querying for findings.
        /// </summary>
        public int Gt
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
        /// Gets and sets the property Gte. Represents the greater than equal condition to be
        /// applied to a single field when querying for findings.
        /// </summary>
        public int Gte
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
        /// Gets and sets the property Lt. Represents the less than condition to be applied to
        /// a single field when querying for findings.
        /// </summary>
        public int Lt
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
        /// Gets and sets the property Lte. Represents the less than equal condition to be applied
        /// to a single field when querying for findings.
        /// </summary>
        public int Lte
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
        /// Gets and sets the property Neq. Represents the not equal condition to be applied to
        /// a single field when querying for findings.
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