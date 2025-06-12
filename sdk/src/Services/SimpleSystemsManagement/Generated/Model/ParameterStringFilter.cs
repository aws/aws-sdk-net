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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more filters. Use a filter to return a more specific list of results.
    /// </summary>
    public partial class ParameterStringFilter
    {
        private string _key;
        private string _option;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// The <c>ParameterStringFilter</c> object is used by the <a>DescribeParameters</a> and
        /// <a>GetParametersByPath</a> API operations. However, not all of the pattern values
        /// listed for <c>Key</c> can be used with both operations.
        /// </para>
        ///  
        /// <para>
        /// For <c>DescribeParameters</c>, all of the listed patterns are valid except <c>Label</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>GetParametersByPath</c>, the following patterns listed for <c>Key</c> aren't
        /// valid: <c>tag</c>, <c>DataType</c>, <c>Name</c>, <c>Path</c>, and <c>Tier</c>.
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
        /// For all filters used with <a>DescribeParameters</a>, valid options include <c>Equals</c>
        /// and <c>BeginsWith</c>. The <c>Name</c> filter additionally supports the <c>Contains</c>
        /// option. (Exception: For filters using the key <c>Path</c>, valid options include <c>Recursive</c>
        /// and <c>OneLevel</c>.)
        /// </para>
        ///  
        /// <para>
        /// For filters used with <a>GetParametersByPath</a>, valid options include <c>Equals</c>
        /// and <c>BeginsWith</c>. (Exception: For filters using <c>Label</c> as the Key name,
        /// the only valid option is <c>Equals</c>.)
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}