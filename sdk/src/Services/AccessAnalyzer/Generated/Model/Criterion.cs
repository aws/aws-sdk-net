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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The criteria to use in the filter that defines the archive rule. For more information
    /// on available filter keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
    /// Access Analyzer filter keys</a>.
    /// </summary>
    public partial class Criterion
    {
        private List<string> _contains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _eq = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _exists;
        private List<string> _neq = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Contains. 
        /// <para>
        /// A "contains" operator to match for the filter used to create the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> Contains
        {
            get { return this._contains; }
            set { this._contains = value; }
        }

        // Check to see if Contains property is set
        internal bool IsSetContains()
        {
            return this._contains != null && (this._contains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// An "equals" operator to match for the filter used to create the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property Exists. 
        /// <para>
        /// An "exists" operator to match for the filter used to create the rule. 
        /// </para>
        /// </summary>
        public bool? Exists
        {
            get { return this._exists; }
            set { this._exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this._exists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neq. 
        /// <para>
        /// A "not equals" operator to match for the filter used to create the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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

    }
}