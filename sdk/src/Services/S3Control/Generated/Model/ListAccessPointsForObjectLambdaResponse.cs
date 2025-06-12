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
    /// This is the response object from the ListAccessPointsForObjectLambda operation.
    /// </summary>
    public partial class ListAccessPointsForObjectLambdaResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ObjectLambdaAccessPoint> _objectLambdaAccessPointList = AWSConfigs.InitializeCollections ? new List<ObjectLambdaAccessPoint>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the list has more access points than can be returned in one call to this API, this
        /// field contains a continuation token that you can provide in subsequent calls to this
        /// API to retrieve additional access points.
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

        /// <summary>
        /// Gets and sets the property ObjectLambdaAccessPointList. 
        /// <para>
        /// Returns list of Object Lambda Access Points.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ObjectLambdaAccessPoint> ObjectLambdaAccessPointList
        {
            get { return this._objectLambdaAccessPointList; }
            set { this._objectLambdaAccessPointList = value; }
        }

        // Check to see if ObjectLambdaAccessPointList property is set
        internal bool IsSetObjectLambdaAccessPointList()
        {
            return this._objectLambdaAccessPointList != null && (this._objectLambdaAccessPointList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}