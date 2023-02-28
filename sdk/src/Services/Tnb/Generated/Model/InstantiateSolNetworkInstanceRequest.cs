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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Container for the parameters to the InstantiateSolNetworkInstance operation.
    /// Instantiates a network instance.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed.
    /// </para>
    ///  
    /// <para>
    /// Before you can instantiate a network instance, you have to create a network instance.
    /// For more information, see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_CreateSolNetworkInstance.html">CreateSolNetworkInstance</a>.
    /// </para>
    /// </summary>
    public partial class InstantiateSolNetworkInstanceRequest : AmazonTnbRequest
    {
        private Amazon.Runtime.Documents.Document _additionalParamsForNs;
        private bool? _dryRun;
        private string _nsInstanceId;

        /// <summary>
        /// Gets and sets the property AdditionalParamsForNs. 
        /// <para>
        /// Provides values for the configurable properties.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalParamsForNs
        {
            get { return this._additionalParamsForNs; }
            set { this._additionalParamsForNs = value; }
        }

        // Check to see if AdditionalParamsForNs property is set
        internal bool IsSetAdditionalParamsForNs()
        {
            return !this._additionalParamsForNs.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <code>DryRunOperation</code>. Otherwise, it is <code>UnauthorizedOperation</code>.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NsInstanceId. 
        /// <para>
        /// ID of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsInstanceId
        {
            get { return this._nsInstanceId; }
            set { this._nsInstanceId = value; }
        }

        // Check to see if NsInstanceId property is set
        internal bool IsSetNsInstanceId()
        {
            return this._nsInstanceId != null;
        }

    }
}