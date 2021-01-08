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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnectorEntity operation.
    /// </summary>
    public partial class DescribeConnectorEntityResponse : AmazonWebServiceResponse
    {
        private List<ConnectorEntityField> _connectorEntityFields = new List<ConnectorEntityField>();

        /// <summary>
        /// Gets and sets the property ConnectorEntityFields. 
        /// <para>
        ///  Describes the fields for that connector entity. For example, for an <i>account</i>
        /// entity, the fields would be <i>account name</i>, <i>account ID</i>, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConnectorEntityField> ConnectorEntityFields
        {
            get { return this._connectorEntityFields; }
            set { this._connectorEntityFields = value; }
        }

        // Check to see if ConnectorEntityFields property is set
        internal bool IsSetConnectorEntityFields()
        {
            return this._connectorEntityFields != null && this._connectorEntityFields.Count > 0; 
        }

    }
}