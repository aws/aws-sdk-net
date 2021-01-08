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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for what Amazon S3 Storage Lens will exclude.
    /// </summary>
    public partial class Exclude
    {
        private List<string> _buckets = new List<string>();
        private List<string> _regions = new List<string>();

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// A container for the S3 Storage Lens bucket excludes.
        /// </para>
        /// </summary>
        public List<string> Buckets
        {
            get { return this._buckets; }
            set { this._buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this._buckets != null && this._buckets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A container for the S3 Storage Lens Region excludes.
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

    }
}