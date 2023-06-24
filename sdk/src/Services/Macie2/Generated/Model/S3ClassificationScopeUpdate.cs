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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies changes to the list of S3 buckets that are excluded from automated sensitive
    /// data discovery for an Amazon Macie account.
    /// </summary>
    public partial class S3ClassificationScopeUpdate
    {
        private S3ClassificationScopeExclusionUpdate _excludes;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// The names of the S3 buckets to add or remove from the list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ClassificationScopeExclusionUpdate Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null;
        }

    }
}