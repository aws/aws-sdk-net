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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the CreateFeaturedResultsSet operation.
    /// </summary>
    public partial class CreateFeaturedResultsSetResponse : AmazonWebServiceResponse
    {
        private FeaturedResultsSet _featuredResultsSet;

        /// <summary>
        /// Gets and sets the property FeaturedResultsSet. 
        /// <para>
        /// Information on the set of featured results. This includes the identifier of the featured
        /// results set, whether the featured results set is active or inactive, when the featured
        /// results set was created, and more.
        /// </para>
        /// </summary>
        public FeaturedResultsSet FeaturedResultsSet
        {
            get { return this._featuredResultsSet; }
            set { this._featuredResultsSet = value; }
        }

        // Check to see if FeaturedResultsSet property is set
        internal bool IsSetFeaturedResultsSet()
        {
            return this._featuredResultsSet != null;
        }

    }
}