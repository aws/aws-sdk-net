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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Overrides the default image tag mutability setting of the repository for image tags
    /// that match the specified filters.
    /// </summary>
    public partial class ImageTagMutabilityExclusionFilter
    {
        private string _filter;
        private ImageTagMutabilityExclusionFilterType _filterType;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The value to use when filtering image tags. Must be either a regular expression pattern
        /// or a tag prefix value based on the specified filter type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// Specifies the type of filter to use for excluding image tags from the repository's
        /// mutability setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageTagMutabilityExclusionFilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

    }
}