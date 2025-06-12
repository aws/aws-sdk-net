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
    /// Defines which patches should be included in a patch baseline.
    /// 
    ///  
    /// <para>
    /// A patch filter consists of a key and a set of values. The filter key is a patch property.
    /// For example, the available filter keys for <c>WINDOWS</c> are <c>PATCH_SET</c>, <c>PRODUCT</c>,
    /// <c>PRODUCT_FAMILY</c>, <c>CLASSIFICATION</c>, and <c>MSRC_SEVERITY</c>.
    /// </para>
    ///  
    /// <para>
    /// The filter values define a matching criterion for the patch property indicated by
    /// the key. For example, if the filter key is <c>PRODUCT</c> and the filter values are
    /// <c>["Office 2013", "Office 2016"]</c>, then the filter accepts all patches where product
    /// name is either "Office 2013" or "Office 2016". The filter values can be exact values
    /// for the patch property given as a key, or a wildcard (*), which matches all values.
    /// </para>
    ///  
    /// <para>
    /// You can view lists of valid values for the patch properties by running the <c>DescribePatchProperties</c>
    /// command. For information about which patch properties can be used with each major
    /// operating system, see <a>DescribePatchProperties</a>.
    /// </para>
    /// </summary>
    public partial class PatchFilter
    {
        private PatchFilterKey _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the filter.
        /// </para>
        ///  
        /// <para>
        /// Run the <a>DescribePatchProperties</a> command to view lists of valid keys for each
        /// operating system type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PatchFilterKey Key
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
        /// The value for the filter key.
        /// </para>
        ///  
        /// <para>
        /// Run the <a>DescribePatchProperties</a> command to view lists of valid values for each
        /// key based on operating system type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
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