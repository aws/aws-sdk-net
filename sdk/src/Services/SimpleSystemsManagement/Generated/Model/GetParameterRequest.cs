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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetParameter operation.
    /// Get information about a parameter by using the parameter name. Don't confuse this
    /// API action with the <a>GetParameters</a> API action.
    /// </summary>
    public partial class GetParameterRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _name;
        private bool? _withDecryption;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter you want to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property WithDecryption. 
        /// <para>
        /// Return decrypted values for secure string parameters. This flag is ignored for String
        /// and StringList parameter types.
        /// </para>
        /// </summary>
        public bool WithDecryption
        {
            get { return this._withDecryption.GetValueOrDefault(); }
            set { this._withDecryption = value; }
        }

        // Check to see if WithDecryption property is set
        internal bool IsSetWithDecryption()
        {
            return this._withDecryption.HasValue; 
        }

    }
}