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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A filter name and value pair that is used to return a more specific list of results
    /// from a describe operation. Filters can be used to match a set of resources by specific
    /// criteria, such as tags, attributes, or IDs.
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are joined with an <c>AND</c>, and the
    /// request returns only results that match all of the specified filters.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Filtering.html#Filtering_Resources_CLI">List
    /// and filter using the CLI and API</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Filter() { }

        /// <summary>
        /// Instantiates Filter with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the filter. Filter names are case-sensitive.</param>
        /// <param name="values">The filter values. Filter values are case-sensitive. If you specify multiple values for a filter, the values are joined with an <c>OR</c>, and the request returns all results that match any of the specified values.</param>
        public Filter(string name, List<string> values)
        {
            _name = name;
            _values = values;
        }

        /// <summary>
        /// Instantiates Filter with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the filter. Filter names are case-sensitive.</param>
        public Filter(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter. Filter names are case-sensitive.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The filter values. Filter values are case-sensitive. If you specify multiple values
        /// for a filter, the values are joined with an <c>OR</c>, and the request returns all
        /// results that match any of the specified values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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