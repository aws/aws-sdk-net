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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the DescribeImagePermissions operation.
    /// </summary>
    public partial class DescribeImagePermissionsResponse : AmazonWebServiceResponse
    {
        private string _name;
        private string _nextToken;
        private List<SharedImagePermissions> _sharedImagePermissionsList = AWSConfigs.InitializeCollections ? new List<SharedImagePermissions>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private image.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SharedImagePermissionsList. 
        /// <para>
        /// The permissions for a private image that you own. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SharedImagePermissions> SharedImagePermissionsList
        {
            get { return this._sharedImagePermissionsList; }
            set { this._sharedImagePermissionsList = value; }
        }

        // Check to see if SharedImagePermissionsList property is set
        internal bool IsSetSharedImagePermissionsList()
        {
            return this._sharedImagePermissionsList != null && (this._sharedImagePermissionsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}