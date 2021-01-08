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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The container element for an Object Lock rule.
    /// </summary>
    public partial class ObjectLockRule
    {
        private DefaultRetention _defaultRetention;

        /// <summary>
        /// Gets and sets the property DefaultRetention. 
        /// <para>
        /// The default retention period that you want to apply to new objects placed in the specified
        /// bucket.
        /// </para>
        /// </summary>
        public DefaultRetention DefaultRetention
        {
            get { return this._defaultRetention; }
            set { this._defaultRetention = value; }
        }

        // Check to see if DefaultRetention property is set
        internal bool IsSetDefaultRetention()
        {
            return this._defaultRetention != null;
        }

    }
}