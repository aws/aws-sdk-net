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
    /// Configuration of the topic rule destination.
    /// </summary>
    public partial class TopicRuleDestinationConfiguration
    {
        private HttpUrlDestinationConfiguration _httpUrlConfiguration;
        private VpcDestinationConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property HttpUrlConfiguration. 
        /// <para>
        /// Configuration of the HTTP URL.
        /// </para>
        /// </summary>
        public HttpUrlDestinationConfiguration HttpUrlConfiguration
        {
            get { return this._httpUrlConfiguration; }
            set { this._httpUrlConfiguration = value; }
        }

        // Check to see if HttpUrlConfiguration property is set
        internal bool IsSetHttpUrlConfiguration()
        {
            return this._httpUrlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration of the virtual private cloud (VPC) connection.
        /// </para>
        /// </summary>
        public VpcDestinationConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}