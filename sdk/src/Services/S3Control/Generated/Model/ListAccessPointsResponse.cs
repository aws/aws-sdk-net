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
    /// This is the response object from the ListAccessPoints operation.
    /// </summary>
    public partial class ListAccessPointsResponse : AmazonWebServiceResponse
    {
        private List<AccessPoint> _accessPointList = AWSConfigs.InitializeCollections ? new List<AccessPoint>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccessPointList. 
        /// <para>
        /// Contains identification and configuration information for one or more access points
        /// associated with the specified bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccessPoint> AccessPointList
        {
            get { return this._accessPointList; }
            set { this._accessPointList = value; }
        }

        // Check to see if AccessPointList property is set
        internal bool IsSetAccessPointList()
        {
            return this._accessPointList != null && (this._accessPointList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the specified bucket has more access points than can be returned in one call to
        /// this API, this field contains a continuation token that you can provide in subsequent
        /// calls to this API to retrieve additional access points.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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