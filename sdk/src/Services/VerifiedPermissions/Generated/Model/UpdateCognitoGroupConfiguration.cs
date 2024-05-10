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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A list of user groups and entities from an Amazon Cognito user pool identity source.
    /// </summary>
    public partial class UpdateCognitoGroupConfiguration
    {
        private string _groupEntityType;

        /// <summary>
        /// Gets and sets the property GroupEntityType. 
        /// <para>
        /// The name of the schema entity type that's mapped to the user pool group. Defaults
        /// to <c>AWS::CognitoGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string GroupEntityType
        {
            get { return this._groupEntityType; }
            set { this._groupEntityType = value; }
        }

        // Check to see if GroupEntityType property is set
        internal bool IsSetGroupEntityType()
        {
            return this._groupEntityType != null;
        }

    }
}