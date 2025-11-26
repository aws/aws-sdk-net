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
    /// A repository filter used to determine which repositories have their images automatically
    /// signed on push. Each filter consists of a filter type and filter value.
    /// </summary>
    public partial class SigningRepositoryFilter
    {
        private string _filter;
        private SigningRepositoryFilterType _filterType;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter value used to match repository names. When using <c>WILDCARD_MATCH</c>,
        /// the <c>*</c> character matches any sequence of characters.
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>myapp/*</c> - Matches all repositories starting with <c>myapp/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>*/production</c> - Matches all repositories ending with <c>/production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>*prod*</c> - Matches all repositories containing <c>prod</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The type of filter to apply. Currently, only <c>WILDCARD_MATCH</c> is supported, which
        /// uses wildcard patterns to match repository names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningRepositoryFilterType FilterType
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