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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
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
namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Represents an application source.
    /// </summary>
    public partial class ApplicationSource
    {
        private string _cloudFormationStackARN;
        private List<TagFilter> _tagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Gets and sets the property CloudFormationStackARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a AWS CloudFormation stack.
        /// </para>
        /// </summary>
        public string CloudFormationStackARN
        {
            get { return this._cloudFormationStackARN; }
            set { this._cloudFormationStackARN = value; }
        }

        // Check to see if CloudFormationStackARN property is set
        internal bool IsSetCloudFormationStackARN()
        {
            return this._cloudFormationStackARN != null;
        }

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// A set of tags (up to 50).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && (this._tagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}