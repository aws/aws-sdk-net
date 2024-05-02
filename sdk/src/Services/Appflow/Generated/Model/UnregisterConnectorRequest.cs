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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the UnregisterConnector operation.
    /// Unregisters the custom connector registered in your account that matches the connector
    /// label provided in the request.
    /// </summary>
    public partial class UnregisterConnectorRequest : AmazonAppflowRequest
    {
        private string _connectorLabel;
        private bool? _forceDelete;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label of the connector. The label is unique for each <c>ConnectorRegistration</c>
        /// in your Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ConnectorLabel
        {
            get { return this._connectorLabel; }
            set { this._connectorLabel = value; }
        }

        // Check to see if ConnectorLabel property is set
        internal bool IsSetConnectorLabel()
        {
            return this._connectorLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Indicates whether Amazon AppFlow should unregister the connector, even if it is currently
        /// in use in one or more connector profiles. The default value is false.
        /// </para>
        /// </summary>
        public bool? ForceDelete
        {
            get { return this._forceDelete; }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}