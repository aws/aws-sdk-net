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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the GetMultiRegionAccessPointRoutes operation.
    /// Returns the routing configuration for a Multi-Region Access Point, indicating which
    /// Regions are active or passive.
    /// 
    ///  
    /// <para>
    /// To obtain routing control changes and failover requests, use the Amazon S3 failover
    /// control infrastructure endpoints in these five Amazon Web Services Regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>us-east-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>us-west-2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ap-southeast-2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ap-northeast-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>eu-west-1</code> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Your Amazon S3 bucket does not need to be in these five Regions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetMultiRegionAccessPointRoutesRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _mrap;

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

    }
}