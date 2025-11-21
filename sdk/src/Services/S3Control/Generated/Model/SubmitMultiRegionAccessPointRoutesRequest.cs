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
    /// Container for the parameters to the SubmitMultiRegionAccessPointRoutes operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Submits an updated route configuration for a Multi-Region Access Point. This API operation
    /// updates the routing status for the specified Regions from active to passive, or from
    /// passive to active. A value of <c>0</c> indicates a passive status, which means that
    /// traffic won't be routed to the specified Region. A value of <c>100</c> indicates an
    /// active status, which means that traffic will be routed to the specified Region. At
    /// least one Region must be active at all times.
    /// </para>
    ///  
    /// <para>
    /// When the routing configuration is changed, any in-progress operations (uploads, copies,
    /// deletes, and so on) to formerly active Regions will continue to run to their final
    /// completion state (success or failure). The routing configurations of any Regions that
    /// aren’t specified remain unchanged.
    /// </para>
    ///  <note> 
    /// <para>
    /// Updated routing configurations might not be immediately applied. It can take up to
    /// 2 minutes for your changes to take effect.
    /// </para>
    ///  </note> 
    /// <para>
    /// To submit routing control changes and failover requests, use the Amazon S3 failover
    /// control infrastructure endpoints in these five Amazon Web Services Regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>us-east-1</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>us-west-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ap-southeast-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ap-northeast-1</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>eu-west-1</c> 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SubmitMultiRegionAccessPointRoutesRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _mrap;
        private List<MultiRegionAccessPointRoute> _routeUpdates = AWSConfigs.InitializeCollections ? new List<MultiRegionAccessPointRoute>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the Multi-Region Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Mrap. 
        /// <para>
        /// The Multi-Region Access Point ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=200)]
        public string Mrap
        {
            get { return this._mrap; }
            set { this._mrap = value; }
        }

        // Check to see if Mrap property is set
        internal bool IsSetMrap()
        {
            return this._mrap != null;
        }

        /// <summary>
        /// Gets and sets the property RouteUpdates. 
        /// <para>
        /// The different routes that make up the new route configuration. Active routes return
        /// a value of <c>100</c>, and passive routes return a value of <c>0</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MultiRegionAccessPointRoute> RouteUpdates
        {
            get { return this._routeUpdates; }
            set { this._routeUpdates = value; }
        }

        // Check to see if RouteUpdates property is set
        internal bool IsSetRouteUpdates()
        {
            return this._routeUpdates != null && (this._routeUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}