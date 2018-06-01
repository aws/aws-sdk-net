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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetEffectivePolicies operation.
    /// Gets a list of the policies that have an effect on the authorization behavior of the
    /// specified device when it connects to the AWS IoT device gateway.
    /// </summary>
    public partial class GetEffectivePoliciesRequest : AmazonIoTRequest
    {
        private string _cognitoIdentityPoolId;
        private string _principal;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property CognitoIdentityPoolId. 
        /// <para>
        /// The Cognito identity pool ID.
        /// </para>
        /// </summary>
        public string CognitoIdentityPoolId
        {
            get { return this._cognitoIdentityPoolId; }
            set { this._cognitoIdentityPoolId = value; }
        }

        // Check to see if CognitoIdentityPoolId property is set
        internal bool IsSetCognitoIdentityPoolId()
        {
            return this._cognitoIdentityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal.
        /// </para>
        /// </summary>
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing name.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}