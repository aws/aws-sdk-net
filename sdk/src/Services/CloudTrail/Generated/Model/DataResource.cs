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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The Amazon S3 objects that you specify in your event selectors for your trail to log
    /// data events. Data events are object-level API operations that access S3 objects, such
    /// as <code>GetObject</code>, <code>DeleteObject</code>, and <code>PutObject</code>.
    /// You can specify up to 250 S3 buckets and object prefixes for a trail. 
    /// 
    ///  
    /// <para>
    /// Example
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You create an event selector for a trail and specify an S3 bucket and an empty prefix,
    /// such as <code>arn:aws:s3:::bucket-1/</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You upload an image file to <code>bucket-1</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>PutObject</code> API operation occurs on an object in the S3 bucket that
    /// you specified in the event selector. The trail processes and logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You upload another image file to a different S3 bucket named <code>arn:aws:s3:::bucket-2</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The event occurs on an object in an S3 bucket that you didn't specify in the event
    /// selector. The trail doesn’t log the event.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DataResource
    {
        private string _type;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type in which you want to log data events. You can specify only the following
        /// value: <code>AWS::S3::Object</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// A list of ARN-like strings for the specified S3 objects.
        /// </para>
        ///  
        /// <para>
        /// To log data events for all objects in an S3 bucket, specify the bucket and an empty
        /// object prefix such as <code>arn:aws:s3:::bucket-1/</code>. The trail logs data events
        /// for all objects in this S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// To log data events for specific objects, specify the S3 bucket and object prefix such
        /// as <code>arn:aws:s3:::bucket-1/example-images</code>. The trail logs data events for
        /// objects in this S3 bucket that match the prefix.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}