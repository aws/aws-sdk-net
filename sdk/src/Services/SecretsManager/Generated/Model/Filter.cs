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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Allows you to add filters when you use the search function in Secrets Manager. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_search-secret.html">Find
    /// secrets in Secrets Manager</a>.
    /// </summary>
    public partial class Filter
    {
        private FilterNameStringType _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The following are keys you can use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>description</b>: Prefix match, not case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>name</b>: Prefix match, case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>tag-key</b>: Prefix match, case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>tag-value</b>: Prefix match, case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>primary-region</b>: Prefix match, case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>owning-service</b>: Prefix match, case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>all</b>: Breaks the filter value string into words and then searches all attributes
        /// for matches. Not case-sensitive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FilterNameStringType Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The keyword to filter for.
        /// </para>
        ///  
        /// <para>
        /// You can prefix your search value with an exclamation mark (<code>!</code>) in order
        /// to perform negation filters. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}