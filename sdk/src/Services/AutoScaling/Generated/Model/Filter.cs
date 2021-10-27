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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a filter that is used to return a more specific list of results from a describe
    /// operation.
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are automatically logically joined with
    /// an <code>AND</code>, and the request returns only the results that match all of the
    /// specified filters. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
    /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// The valid values for <code>Name</code> depend on which API operation you're using
        /// with the filter (<a>DescribeAutoScalingGroups</a> or <a>DescribeTags</a>).
        /// </para>
        ///  
        /// <para>
        ///  <b>DescribeAutoScalingGroups</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tag-key</code> - Accepts tag keys. The results only include information about
        /// the Auto Scaling groups associated with these tag keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-value</code> - Accepts tag values. The results only include information
        /// about the Auto Scaling groups associated with these tag values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:&lt;key&gt;</code> - Accepts the key/value combination of the tag. Use
        /// the tag key in the filter name and the tag value as the filter value. The results
        /// only include information about the Auto Scaling groups associated with the specified
        /// key/value combination. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>DescribeTags</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>auto-scaling-group</code> - Accepts the names of Auto Scaling groups. The results
        /// only include information about the tags associated with these Auto Scaling groups.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>key</code> - Accepts tag keys. The results only include information about the
        /// tags associated with these tag keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>value</code> - Accepts tag values. The results only include information about
        /// the tags associated with these tag values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>propagate-at-launch</code> - Accepts a Boolean value, which specifies whether
        /// tags propagate to instances at launch. The results only include information about
        /// the tags associated with the specified Boolean value. 
        /// </para>
        ///  </li> </ul>
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
        /// One or more filter values. Filter values are case-sensitive. 
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple values for a filter, the values are automatically logically
        /// joined with an <code>OR</code>, and the request returns all results that match any
        /// of the specified values. For example, specify "tag:environment" for the filter name
        /// and "production,development" for the filter values to find Auto Scaling groups with
        /// the tag "environment=production" or "environment=development".
        /// </para>
        /// </summary>
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