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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the access log configuration for a bucket in the Amazon Lightsail object
    /// storage service.
    /// 
    ///  
    /// <para>
    /// For more information about bucket access logs, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-bucket-access-logs">Logging
    /// bucket requests using access logging in Amazon Lightsail</a> in the <i>Amazon Lightsail
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class BucketAccessLogConfig
    {
        private string _destination;
        private bool? _enabled;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The name of the bucket where the access logs are saved. The destination can be a Lightsail
        /// bucket in the same account, and in the same Amazon Web Services Region as the source
        /// bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required when enabling the access log for a bucket, and should be
        /// omitted when disabling the access log.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=3, Max=54)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean value that indicates whether bucket access logging is enabled for the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The optional object prefix for the bucket access log.
        /// </para>
        ///  
        /// <para>
        /// The prefix is an optional addition to the object key that organizes your access log
        /// files in the destination bucket. For example, if you specify a <c>logs/</c> prefix,
        /// then each log object will begin with the <c>logs/</c> prefix in its key (for example,
        /// <c>logs/2021-11-01-21-32-16-E568B2907131C0C0</c>).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter can be optionally specified when enabling the access log for a bucket,
        /// and should be omitted when disabling the access log.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}