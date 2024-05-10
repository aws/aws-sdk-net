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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the ListAccessGrantsLocations operation.
    /// </summary>
    public partial class ListAccessGrantsLocationsResponse : AmazonWebServiceResponse
    {
        private List<ListAccessGrantsLocationsEntry> _accessGrantsLocationsList = AWSConfigs.InitializeCollections ? new List<ListAccessGrantsLocationsEntry>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccessGrantsLocationsList. 
        /// <para>
        /// A container for a list of registered locations in an S3 Access Grants instance.
        /// </para>
        /// </summary>
        public List<ListAccessGrantsLocationsEntry> AccessGrantsLocationsList
        {
            get { return this._accessGrantsLocationsList; }
            set { this._accessGrantsLocationsList = value; }
        }

        // Check to see if AccessGrantsLocationsList property is set
        internal bool IsSetAccessGrantsLocationsList()
        {
            return this._accessGrantsLocationsList != null && (this._accessGrantsLocationsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to request the next page of results. Pass this value into a subsequent
        /// <c>List Access Grants Locations</c> request in order to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
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

    }
}