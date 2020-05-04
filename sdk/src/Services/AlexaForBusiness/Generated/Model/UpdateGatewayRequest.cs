/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGateway operation.
    /// Updates the details of a gateway. If any optional field is not provided, the existing
    /// corresponding value is left unmodified.
    /// </summary>
    public partial class UpdateGatewayRequest : AmazonAlexaForBusinessRequest
    {
        private string _description;
        private string _gatewayArn;
        private string _name;
        private string _softwareVersion;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The ARN of the gateway to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The updated software version of the gateway. The gateway automatically updates its
        /// software version during normal operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string SoftwareVersion
        {
            get { return this._softwareVersion; }
            set { this._softwareVersion = value; }
        }

        // Check to see if SoftwareVersion property is set
        internal bool IsSetSoftwareVersion()
        {
            return this._softwareVersion != null;
        }

    }
}