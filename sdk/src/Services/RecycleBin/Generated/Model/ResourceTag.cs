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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Information about the resource tags used to identify resources that are retained by
    /// the retention rule.
    /// </summary>
    public partial class ResourceTag
    {
        private string _resourceTagKey;
        private string _resourceTagValue;

        /// <summary>
        /// Gets and sets the property ResourceTagKey. 
        /// <para>
        /// The tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceTagKey
        {
            get { return this._resourceTagKey; }
            set { this._resourceTagKey = value; }
        }

        // Check to see if ResourceTagKey property is set
        internal bool IsSetResourceTagKey()
        {
            return this._resourceTagKey != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTagValue. 
        /// <para>
        /// The tag value.
        /// </para>
        /// </summary>
        public string ResourceTagValue
        {
            get { return this._resourceTagValue; }
            set { this._resourceTagValue = value; }
        }

        // Check to see if ResourceTagValue property is set
        internal bool IsSetResourceTagValue()
        {
            return this._resourceTagValue != null;
        }

    }
}