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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a filter that is used to return a more specific list of results from a describe
    /// operation.
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are automatically logically joined with
    /// an <c>AND</c>, and the request returns only the results that match all of the specified
    /// filters. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
    /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// The valid values for <c>Name</c> depend on which API operation you're using with the
        /// filter (<a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAutoScalingGroups.html">DescribeAutoScalingGroups</a>
        /// or <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeTags.html">DescribeTags</a>).
        /// </para>
        ///  
        /// <para>
        ///  <b>DescribeAutoScalingGroups</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag-key</c> - Accepts tag keys. The results only include information about the
        /// Auto Scaling groups associated with these tag keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-value</c> - Accepts tag values. The results only include information about
        /// the Auto Scaling groups associated with these tag values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - Accepts the key/value combination of the tag. Use the tag
        /// key in the filter name and the tag value as the filter value. The results only include
        /// information about the Auto Scaling groups associated with the specified key/value
        /// combination. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>DescribeTags</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto-scaling-group</c> - Accepts the names of Auto Scaling groups. The results
        /// only include information about the tags associated with these Auto Scaling groups.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>key</c> - Accepts tag keys. The results only include information about the tags
        /// associated with these tag keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>value</c> - Accepts tag values. The results only include information about the
        /// tags associated with these tag values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>propagate-at-launch</c> - Accepts a Boolean value, which specifies whether tags
        /// propagate to instances at launch. The results only include information about the tags
        /// associated with the specified Boolean value. 
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
        /// joined with an <c>OR</c>, and the request returns all results that match any of the
        /// specified values. For example, specify "tag:environment" for the filter name and "production,development"
        /// for the filter values to find Auto Scaling groups with the tag "environment=production"
        /// or "environment=development".
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