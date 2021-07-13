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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more filters. Use a filter to return a more specific list of results.
    /// </summary>
    public partial class ParameterStringFilter
    {
        private string _key;
        private string _option;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// The <code>ParameterStringFilter</code> object is used by the <a>DescribeParameters</a>
        /// and <a>GetParametersByPath</a> API operations. However, not all of the pattern values
        /// listed for <code>Key</code> can be used with both operations.
        /// </para>
        ///  
        /// <para>
        /// For <code>DescribeActions</code>, all of the listed patterns are valid, with the exception
        /// of <code>Label</code>.
        /// </para>
        ///  
        /// <para>
        /// For <code>GetParametersByPath</code>, the following patterns listed for <code>Key</code>
        /// aren't valid: <code>tag</code>, <code>Name</code>, <code>Path</code>, and <code>Tier</code>.
        /// </para>
        ///  
        /// <para>
        /// For examples of Amazon Web Services CLI commands demonstrating valid parameter filter
        /// constructions, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-search.html">Searching
        /// for Systems Manager parameters</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=132)]
        public string Key
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
        /// Gets and sets the property Option. 
        /// <para>
        /// For all filters used with <a>DescribeParameters</a>, valid options include <code>Equals</code>
        /// and <code>BeginsWith</code>. The <code>Name</code> filter additionally supports the
        /// <code>Contains</code> option. (Exception: For filters using the key <code>Path</code>,
        /// valid options include <code>Recursive</code> and <code>OneLevel</code>.)
        /// </para>
        ///  
        /// <para>
        /// For filters used with <a>GetParametersByPath</a>, valid options include <code>Equals</code>
        /// and <code>BeginsWith</code>. (Exception: For filters using <code>Label</code> as the
        /// Key name, the only valid option is <code>Equals</code>.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Option
        {
            get { return this._option; }
            set { this._option = value; }
        }

        // Check to see if Option property is set
        internal bool IsSetOption()
        {
            return this._option != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value you want to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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