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
    /// This is the response object from the TestInvokeAuthorizer operation.
    /// </summary>
    public partial class TestInvokeAuthorizerResponse : AmazonWebServiceResponse
    {
        private int? _disconnectAfterInSeconds;
        private bool? _isAuthenticated;
        private List<string> _policyDocuments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _principalId;
        private int? _refreshAfterInSeconds;

        /// <summary>
        /// Gets and sets the property DisconnectAfterInSeconds. 
        /// <para>
        /// The number of seconds after which the connection is terminated.
        /// </para>
        /// </summary>
        public int? DisconnectAfterInSeconds
        {
            get { return this._disconnectAfterInSeconds; }
            set { this._disconnectAfterInSeconds = value; }
        }

        // Check to see if DisconnectAfterInSeconds property is set
        internal bool IsSetDisconnectAfterInSeconds()
        {
            return this._disconnectAfterInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAuthenticated. 
        /// <para>
        /// True if the token is authenticated, otherwise false.
        /// </para>
        /// </summary>
        public bool? IsAuthenticated
        {
            get { return this._isAuthenticated; }
            set { this._isAuthenticated = value; }
        }

        // Check to see if IsAuthenticated property is set
        internal bool IsSetIsAuthenticated()
        {
            return this._isAuthenticated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDocuments. 
        /// <para>
        /// IAM policy documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyDocuments
        {
            get { return this._policyDocuments; }
            set { this._policyDocuments = value; }
        }

        // Check to see if PolicyDocuments property is set
        internal bool IsSetPolicyDocuments()
        {
            return this._policyDocuments != null && (this._policyDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshAfterInSeconds. 
        /// <para>
        /// The number of seconds after which the temporary credentials are refreshed.
        /// </para>
        /// </summary>
        public int? RefreshAfterInSeconds
        {
            get { return this._refreshAfterInSeconds; }
            set { this._refreshAfterInSeconds = value; }
        }

        // Check to see if RefreshAfterInSeconds property is set
        internal bool IsSetRefreshAfterInSeconds()
        {
            return this._refreshAfterInSeconds.HasValue; 
        }

    }
}