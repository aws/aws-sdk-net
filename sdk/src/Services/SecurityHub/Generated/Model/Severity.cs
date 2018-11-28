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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A finding's severity.
    /// </summary>
    public partial class Severity
    {
        private int? _normalized;
        private double? _product;

        /// <summary>
        /// Gets and sets the property Normalized. 
        /// <para>
        /// The normalized severity of a finding.
        /// </para>
        /// </summary>
        public int Normalized
        {
            get { return this._normalized.GetValueOrDefault(); }
            set { this._normalized = value; }
        }

        // Check to see if Normalized property is set
        internal bool IsSetNormalized()
        {
            return this._normalized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The native severity as defined by the security findings provider's solution that generated
        /// the finding.
        /// </para>
        /// </summary>
        public double Product
        {
            get { return this._product.GetValueOrDefault(); }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product.HasValue; 
        }

    }
}