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
    /// This is the response object from the VerifyDnsConfiguration operation.
    /// </summary>
    public partial class VerifyDnsConfigurationResponse : AmazonWebServiceResponse
    {
        private List<DnsConfiguration> _dnsConfigurationList = AWSConfigs.InitializeCollections ? new List<DnsConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property DnsConfigurationList. 
        /// <para>
        /// The list of domain names, their statuses, and a description of each status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsConfiguration> DnsConfigurationList
        {
            get { return this._dnsConfigurationList; }
            set { this._dnsConfigurationList = value; }
        }

        // Check to see if DnsConfigurationList property is set
        internal bool IsSetDnsConfigurationList()
        {
            return this._dnsConfigurationList != null && (this._dnsConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}