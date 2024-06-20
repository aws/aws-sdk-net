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
    /// The severity assigned to a finding by the finding provider. This object may include
    /// one or more of the following attributes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>Label</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Normalized</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Original</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Product</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If a <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchImportFindings.html">
    /// <c>BatchImportFindings</c> </a> request for a new finding only provides <c>Label</c>
    /// or only provides <c>Normalized</c>, Security Hub automatically populates the value
    /// of the other field.
    /// </para>
    ///  
    /// <para>
    /// The <c>Normalized</c> and <c>Product</c> attributes are included in the <c>FindingProviderSeverity</c>
    /// structure to preserve the historical information associated with the finding, even
    /// if the top-level <c>Severity</c> object is later modified using the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateFindings.html">
    /// <c>BatchUpdateFindings</c> </a> operation.
    /// </para>
    ///  
    /// <para>
    /// If the top-level <c>Finding.Severity</c> object is present, but <c>Finding.FindingProviderFields</c>
    /// isn't present, Security Hub creates the <c>FindingProviderFields.Severity</c> object
    /// and copies the entire <c>Finding.Severity</c> object into it. This ensures that the
    /// original, provider-supplied details are retained within the <c>FindingProviderFields.Severity</c>
    /// object, even if the top-level <c>Severity</c> object is overwritten. 
    /// </para>
    /// </summary>
    public partial class FindingProviderSeverity
    {
        private SeverityLabel _label;
        private string _original;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The severity label assigned to the finding by the finding provider.
        /// </para>
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
        /// Gets and sets the property Original. 
        /// <para>
        /// The finding provider's original value for the severity.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 64.
        /// </para>
        /// </summary>
        public string Original
        {
            get { return this._original; }
            set { this._original = value; }
        }

        // Check to see if Original property is set
        internal bool IsSetOriginal()
        {
            return this._original != null;
        }

    }
}