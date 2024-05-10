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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEndpoint operation.
    /// Returns or creates a unique endpoint specific to the Amazon Web Services account making
    /// the call.
    /// 
    ///  <note> 
    /// <para>
    /// The first time <c>DescribeEndpoint</c> is called, an endpoint is created. All subsequent
    /// calls to <c>DescribeEndpoint</c> return the same endpoint.
    /// </para>
    ///  </note> 
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeEndpoint</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeEndpointRequest : AmazonIoTRequest
    {
        private string _endpointType;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The endpoint type. Valid endpoint types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>iot:Data</c> - Returns a VeriSign signed data endpoint.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>iot:Data-ATS</c> - Returns an ATS signed data endpoint.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>iot:CredentialProvider</c> - Returns an IoT credentials provider API endpoint.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>iot:Jobs</c> - Returns an IoT device management Jobs API endpoint.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// We strongly recommend that customers use the newer <c>iot:Data-ATS</c> endpoint type
        /// to avoid issues related to the widespread distrust of Symantec certificate authorities.
        /// ATS Signed Certificates are more secure and are trusted by most popular browsers.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

    }
}