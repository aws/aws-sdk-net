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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the CreateNetworkInsightsAccessScope operation.
    /// </summary>
    public partial class CreateNetworkInsightsAccessScopeResponse : AmazonWebServiceResponse
    {
        private NetworkInsightsAccessScope _networkInsightsAccessScope;
        private NetworkInsightsAccessScopeContent _networkInsightsAccessScopeContent;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScope. 
        /// <para>
        /// The Network Access Scope.
        /// </para>
        /// </summary>
        public NetworkInsightsAccessScope NetworkInsightsAccessScope
        {
            get { return this._networkInsightsAccessScope; }
            set { this._networkInsightsAccessScope = value; }
        }

        // Check to see if NetworkInsightsAccessScope property is set
        internal bool IsSetNetworkInsightsAccessScope()
        {
            return this._networkInsightsAccessScope != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeContent. 
        /// <para>
        /// The Network Access Scope content.
        /// </para>
        /// </summary>
        public NetworkInsightsAccessScopeContent NetworkInsightsAccessScopeContent
        {
            get { return this._networkInsightsAccessScopeContent; }
            set { this._networkInsightsAccessScopeContent = value; }
        }

        // Check to see if NetworkInsightsAccessScopeContent property is set
        internal bool IsSetNetworkInsightsAccessScopeContent()
        {
            return this._networkInsightsAccessScopeContent != null;
        }

    }
}