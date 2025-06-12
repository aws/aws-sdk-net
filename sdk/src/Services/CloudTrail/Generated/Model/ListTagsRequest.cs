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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the ListTags operation.
    /// Lists the tags for the specified trails, event data stores, dashboards, or channels
    /// in the current Region.
    /// </summary>
    public partial class ListTagsRequest : AmazonCloudTrailRequest
    {
        private string _nextToken;
        private List<string> _resourceIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Reserved for future use.
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

        /// <summary>
        /// Gets and sets the property ResourceIdList. 
        /// <para>
        /// Specifies a list of trail, event data store, dashboard, or channel ARNs whose tags
        /// will be listed. The list has a limit of 20 ARNs.
        /// </para>
        ///  
        /// <para>
        ///  Example trail ARN format: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example event data store ARN format: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example dashboard ARN format: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example channel ARN format: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ResourceIdList
        {
            get { return this._resourceIdList; }
            set { this._resourceIdList = value; }
        }

        // Check to see if ResourceIdList property is set
        internal bool IsSetResourceIdList()
        {
            return this._resourceIdList != null && (this._resourceIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}