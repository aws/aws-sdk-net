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
    /// A number filter for querying findings.
    /// </summary>
    public partial class NumberFilter
    {
        private double? _eq;
        private double? _gt;
        private double? _gte;
        private double? _lt;
        private double? _lte;

        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// The equal-to condition to be applied to a single field when querying for findings.
        /// </para>
        /// </summary>
        public double? Eq
        {
            get { return this._eq; }
            set { this._eq = value; }
        }

        // Check to see if Eq property is set
        internal bool IsSetEq()
        {
            return this._eq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        ///  The greater-than condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Gt
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
        /// The greater-than-equal condition to be applied to a single field when querying for
        /// findings. 
        /// </para>
        /// </summary>
        public double? Gte
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
        /// Gets and sets the property Lt. 
        /// <para>
        ///  The less-than condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Lt
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
        /// The less-than-equal condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Lte
        {
            get { return this._lte; }
            set { this._lte = value; }
        }

        // Check to see if Lte property is set
        internal bool IsSetLte()
        {
            return this._lte.HasValue; 
        }

    }
}