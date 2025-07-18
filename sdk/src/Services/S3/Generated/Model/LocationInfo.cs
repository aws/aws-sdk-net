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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the location where the bucket will be created.
    /// 
    ///  
    /// <para>
    /// For directory buckets, the location type is Availability Zone or Local Zone. For more
    /// information about directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Working
    /// with directory buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is only supported by directory buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LocationInfo
    {
        private string _name;
        private LocationType _type;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the location where the bucket will be created.
        /// </para>
        ///  
        /// <para>
        /// For directory buckets, the name of the location is the Zone ID of the Availability
        /// Zone (AZ) or Local Zone (LZ) where the bucket will be created. An example AZ ID value
        /// is <c>usw2-az1</c>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of location where the bucket will be created.
        /// </para>
        /// </summary>
        public LocationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}