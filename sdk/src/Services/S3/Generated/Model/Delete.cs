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
    /// Container for the objects to delete.
    /// </summary>
    public partial class Delete
    {
        private List<KeyVersion> _objects = AWSConfigs.InitializeCollections ? new List<KeyVersion>() : null;
        private bool? _quiet;

        /// <summary>
        /// Gets and sets the property Objects. 
        /// <para>
        /// The object to delete.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets, an object that's composed entirely
        /// of whitespace characters is not supported by the <c>DeleteObjects</c> API operation.
        /// The request will receive a <c>400 Bad Request</c> error and none of the objects in
        /// the request will be deleted.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<KeyVersion> Objects
        {
            get { return this._objects; }
            set { this._objects = value; }
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this._objects != null && (this._objects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Quiet. 
        /// <para>
        /// Element to enable quiet mode for the request. When you add this element, you must
        /// set its value to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Quiet
        {
            get { return this._quiet; }
            set { this._quiet = value; }
        }

        // Check to see if Quiet property is set
        internal bool IsSetQuiet()
        {
            return this._quiet.HasValue; 
        }

    }
}