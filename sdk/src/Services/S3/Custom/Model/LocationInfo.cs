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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the location where the bucket will be created.
    /// <para>
    /// Specifies the location where the bucket will be created.
    /// </para> 
    /// <para> 
    /// <b>Directory buckets </b> - The location type is Availability Zone or Local Zone. To use the Local Zone location type, your account must be enabled 
    /// for Dedicated Local Zones. Otherwise, you get an HTTP <c>403 Forbidden</c> error with the error code <c>AccessDenied</c>. To learn more, see 
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/opt-in-directory-bucket-lz.html">Enable accounts for Dedicated Local Zones</a> in 
    /// the <i>Amazon S3 User Guide</i>. 
    /// </para> 
    /// <note> 
    /// <para>
    /// This functionality is only supported by directory buckets.
    /// </para> 
    /// </note>
    /// </summary>
    public class LocationInfo
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
        /// For directory buckets, the name of the location is the AZ ID of the Availability Zone
        /// where the bucket will be created. An example AZ ID value is <c>usw2-az1</c>.
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