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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents an InvokeApi action.
    /// </summary>
    public partial class RoutingRuleActionInvokeApi
    {
        private string _apiId;
        private string _stage;
        private bool? _stripBasePath;

        /// <summary>
        /// Gets and sets the property ApiId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property Stage.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property StripBasePath. 
        /// <para>
        /// The strip base path setting.
        /// </para>
        /// </summary>
        public bool? StripBasePath
        {
            get { return this._stripBasePath; }
            set { this._stripBasePath = value; }
        }

        // Check to see if StripBasePath property is set
        internal bool IsSetStripBasePath()
        {
            return this._stripBasePath.HasValue; 
        }

    }
}