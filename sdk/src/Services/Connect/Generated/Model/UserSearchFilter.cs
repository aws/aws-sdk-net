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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Filters to be applied to search results.
    /// </summary>
    public partial class UserSearchFilter
    {
        private ControlPlaneTagFilter _tagFilter;
        private ControlPlaneUserAttributeFilter _userAttributeFilter;

        /// <summary>
        /// Gets and sets the property TagFilter.
        /// </summary>
        public ControlPlaneTagFilter TagFilter
        {
            get { return this._tagFilter; }
            set { this._tagFilter = value; }
        }

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this._tagFilter != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributeFilter. 
        /// <para>
        /// An object that can be used to specify Tag conditions or Hierarchy Group conditions
        /// inside the SearchFilter.
        /// </para>
        ///  
        /// <para>
        /// This accepts an <c>OR</c> of <c>AND</c> (List of List) input where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The top level list specifies conditions that need to be applied with <c>OR</c> operator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The inner list specifies conditions that need to be applied with <c>AND</c> operator.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Only one field can be populated. This object can’t be used along with TagFilter. Request
        /// can either contain TagFilter or UserAttributeFilter if SearchFilter is specified,
        /// combination of both is not supported and such request will throw AccessDeniedException.
        /// </para>
        ///  </note>
        /// </summary>
        public ControlPlaneUserAttributeFilter UserAttributeFilter
        {
            get { return this._userAttributeFilter; }
            set { this._userAttributeFilter = value; }
        }

        // Check to see if UserAttributeFilter property is set
        internal bool IsSetUserAttributeFilter()
        {
            return this._userAttributeFilter != null;
        }

    }
}