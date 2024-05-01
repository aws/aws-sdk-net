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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the DescribeApplicationProvider operation.
    /// </summary>
    public partial class DescribeApplicationProviderResponse : AmazonWebServiceResponse
    {
        private string _applicationProviderArn;
        private DisplayData _displayData;
        private FederationProtocol _federationProtocol;
        private ResourceServerConfig _resourceServerConfig;

        /// <summary>
        /// Gets and sets the property ApplicationProviderArn. 
        /// <para>
        /// The ARN of the application provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationProviderArn
        {
            get { return this._applicationProviderArn; }
            set { this._applicationProviderArn = value; }
        }

        // Check to see if ApplicationProviderArn property is set
        internal bool IsSetApplicationProviderArn()
        {
            return this._applicationProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayData. 
        /// <para>
        /// A structure with details about the display data for the application provider.
        /// </para>
        /// </summary>
        public DisplayData DisplayData
        {
            get { return this._displayData; }
            set { this._displayData = value; }
        }

        // Check to see if DisplayData property is set
        internal bool IsSetDisplayData()
        {
            return this._displayData != null;
        }

        /// <summary>
        /// Gets and sets the property FederationProtocol. 
        /// <para>
        /// The protocol used to federate to the application provider.
        /// </para>
        /// </summary>
        public FederationProtocol FederationProtocol
        {
            get { return this._federationProtocol; }
            set { this._federationProtocol = value; }
        }

        // Check to see if FederationProtocol property is set
        internal bool IsSetFederationProtocol()
        {
            return this._federationProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceServerConfig. 
        /// <para>
        /// A structure with details about the receiving application.
        /// </para>
        /// </summary>
        public ResourceServerConfig ResourceServerConfig
        {
            get { return this._resourceServerConfig; }
            set { this._resourceServerConfig = value; }
        }

        // Check to see if ResourceServerConfig property is set
        internal bool IsSetResourceServerConfig()
        {
            return this._resourceServerConfig != null;
        }

    }
}