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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Updates to the severity information for a finding.
    /// </summary>
    public partial class SeverityUpdate
    {
        private SeverityLabel _label;
        private int? _normalized;
        private double? _product;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The severity value of the finding. The allowed values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INFORMATIONAL</code> - No issue was found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOW</code> - The issue does not require action on its own.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MEDIUM</code> - The issue must be addressed but not urgently.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HIGH</code> - The issue must be addressed as a priority.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CRITICAL</code> - The issue must be remediated immediately to avoid it escalating.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SeverityLabel Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Normalized. 
        /// <para>
        /// The normalized severity for the finding. This attribute is to be deprecated in favor
        /// of <code>Label</code>.
        /// </para>
        ///  
        /// <para>
        /// If you provide <code>Normalized</code> and do not provide <code>Label</code>, <code>Label</code>
        /// is set automatically as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0 - <code>INFORMATIONAL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1–39 - <code>LOW</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 40–69 - <code>MEDIUM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 70–89 - <code>HIGH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 90–100 - <code>CRITICAL</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The native severity as defined by the AWS service or integrated partner product that
        /// generated the finding.
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