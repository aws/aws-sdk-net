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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Describes the read, write, and delete permissions users have against your storage
    /// S3 bucket.
    /// </summary>
    public partial class BackendStoragePermissions
    {
        private List<string> _authenticated = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _unAuthenticated = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Authenticated. 
        /// <para>
        /// Lists all authenticated user read, write, and delete permissions for your S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Authenticated
        {
            get { return this._authenticated; }
            set { this._authenticated = value; }
        }

        // Check to see if Authenticated property is set
        internal bool IsSetAuthenticated()
        {
            return this._authenticated != null && (this._authenticated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnAuthenticated. 
        /// <para>
        /// Lists all unauthenticated user read, write, and delete permissions for your S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UnAuthenticated
        {
            get { return this._unAuthenticated; }
            set { this._unAuthenticated = value; }
        }

        // Check to see if UnAuthenticated property is set
        internal bool IsSetUnAuthenticated()
        {
            return this._unAuthenticated != null && (this._unAuthenticated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}