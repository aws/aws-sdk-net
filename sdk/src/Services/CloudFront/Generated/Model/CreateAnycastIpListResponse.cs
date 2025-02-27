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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the CreateAnycastIpList operation.
    /// </summary>
    public partial class CreateAnycastIpListResponse : AmazonWebServiceResponse
    {
        private AnycastIpList _anycastIpList;
        private string _eTag;

        /// <summary>
        /// Gets and sets the property AnycastIpList. 
        /// <para>
        /// A response structure that includes the version identifier (ETag) and the created <a>AnycastIpList</a>
        /// structure.
        /// </para>
        /// </summary>
        public AnycastIpList AnycastIpList
        {
            get { return this._anycastIpList; }
            set { this._anycastIpList = value; }
        }

        // Check to see if AnycastIpList property is set
        internal bool IsSetAnycastIpList()
        {
            return this._anycastIpList != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The version identifier for the current version of the Anycast static IP list.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

    }
}