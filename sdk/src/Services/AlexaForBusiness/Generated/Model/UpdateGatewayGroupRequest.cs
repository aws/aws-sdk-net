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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGatewayGroup operation.
    /// Updates the details of a gateway group. If any optional field is not provided, the
    /// existing corresponding value is left unmodified.
    /// </summary>
    public partial class UpdateGatewayGroupRequest : AmazonAlexaForBusinessRequest
    {
        private string _description;
        private string _gatewayGroupArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the gateway group.
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
        /// Gets and sets the property GatewayGroupArn. 
        /// <para>
        /// The ARN of the gateway group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayGroupArn
        {
            get { return this._gatewayGroupArn; }
            set { this._gatewayGroupArn = value; }
        }

        // Check to see if GatewayGroupArn property is set
        internal bool IsSetGatewayGroupArn()
        {
            return this._gatewayGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the gateway group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

    }
}