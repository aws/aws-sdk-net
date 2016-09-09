/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <code>S3Resource</code> object represents an Amazon S3 bucket that your transferred
    /// data will be exported from or imported into. For export jobs, this object can have
    /// an optional <code>KeyRange</code> value. The length of the range is defined at job
    /// creation, and has either an inclusive <code>BeginMarker</code>, an inclusive <code>EndMarker</code>,
    /// or both. Ranges are UTF-8 binary sorted.
    /// </summary>
    public partial class S3Resource
    {
        private string _bucketArn;
        private KeyRange _keyRange;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRange. 
        /// <para>
        /// For export jobs, you can provide an optional <code>KeyRange</code> within a specific
        /// Amazon S3 bucket. The length of the range is defined at job creation, and has either
        /// an inclusive <code>BeginMarker</code>, an inclusive <code>EndMarker</code>, or both.
        /// Ranges are UTF-8 binary sorted.
        /// </para>
        /// </summary>
        public KeyRange KeyRange
        {
            get { return this._keyRange; }
            set { this._keyRange = value; }
        }

        // Check to see if KeyRange property is set
        internal bool IsSetKeyRange()
        {
            return this._keyRange != null;
        }

    }
}