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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListVehicles operation. Retrieves a list of summaries
    /// of created vehicles. <note> <para> This API operation uses pagination. Specify the
    /// <c>nextToken</c> parameter in the request to return more results. </para> </note>
    /// </summary>
    public partial class ListVehiclesRequest : AmazonIoTFleetWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// The fully qualified names of the attributes. You can use this optional parameter to
        /// list the vehicles containing all the attributes in the request. For example, <c>attributeNames</c>
        /// could be "<c>Vehicle.Body.Engine.Type, Vehicle.Color</c>" and the corresponding <c>attributeValues</c>
        /// could be "<c>1.3 L R2, Blue</c>" . In this case, the API will filter vehicles with
        /// an attribute name <c>Vehicle.Body.Engine.Type</c> that contains a value of <c>1.3
        /// L R2</c> AND an attribute name <c>Vehicle.Color</c> that contains a value of "<c>Blue</c>".
        /// A request must contain unique values for the <c>attributeNames</c> filter and the
        /// matching number of <c>attributeValues</c> filters to return the subset of vehicles
        /// that match the attributes filter condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AttributeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeNames property is set.
        /// </summary>
        internal bool IsSetAttributeNames() => this.AttributeNames != null && (this.AttributeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeValues. 
        /// <para>
        /// Static information about a vehicle attribute value in string format. You can use this
        /// optional parameter in conjunction with <c>attributeNames</c> to list the vehicles
        /// containing all the <c>attributeValues</c> corresponding to the <c>attributeNames</c>
        /// filter. For example, <c>attributeValues</c> could be "<c>1.3 L R2, Blue</c>" and the
        /// corresponding <c>attributeNames</c> filter could be "<c>Vehicle.Body.Engine.Type,
        /// Vehicle.Color</c>". In this case, the API will filter vehicles with attribute name
        /// <c>Vehicle.Body.Engine.Type</c> that contains a value of <c>1.3 L R2</c> AND an attribute
        /// name <c>Vehicle.Color</c> that contains a value of "<c>Blue</c>". A request must contain
        /// unique values for the <c>attributeNames</c> filter and the matching number of <c>attributeValues</c>
        /// filter to return the subset of vehicles that match the attributes filter condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AttributeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeValues property is set.
        /// </summary>
        internal bool IsSetAttributeValues() => this.AttributeValues != null && (this.AttributeValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListResponseScope. 
        /// <para>
        /// When you set the <c>listResponseScope</c> parameter to <c>METADATA_ONLY</c>, the list
        /// response includes: vehicle name, Amazon Resource Name (ARN), creation time, and last
        /// modification time.
        /// </para>
        /// </summary>
        public ListResponseScope ListResponseScope { get; set; }

        /// <summary>
        /// Checks to see if the ListResponseScope property is set.
        /// </summary>
        internal bool IsSetListResponseScope() => this.ListResponseScope != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return, between 1 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a vehicle model (model manifest). You can use this
        /// optional parameter to list only the vehicles created from a certain vehicle model.
        /// 
        /// </para>
        /// </summary>
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for the next set of results.
        /// </para>
        ///  
        /// <para>
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next set of results, reissue the search request and include the returned token. When
        /// all results have been returned, the response does not contain a pagination token value.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
