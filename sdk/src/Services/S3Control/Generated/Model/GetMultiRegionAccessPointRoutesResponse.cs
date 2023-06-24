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
    /// This is the response object from the GetMultiRegionAccessPointRoutes operation.
    /// </summary>
    public partial class GetMultiRegionAccessPointRoutesResponse : AmazonWebServiceResponse
    {
        private string _mrap;
        private List<MultiRegionAccessPointRoute> _routes = new List<MultiRegionAccessPointRoute>();

        /// <summary>
        /// Gets and sets the property Mrap. 
        /// <para>
        /// The Multi-Region Access Point ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property Routes. 
        /// <para>
        /// The different routes that make up the route configuration. Active routes return a
        /// value of <code>100</code>, and passive routes return a value of <code>0</code>.
        /// </para>
        /// </summary>
        public List<MultiRegionAccessPointRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && this._routes.Count > 0; 
        }

    }
}