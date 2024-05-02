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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the GetLayout operation.
    /// Returns the details for the requested layout.
    /// </summary>
    public partial class GetLayoutRequest : AmazonConnectCasesRequest
    {
        private string _domainId;
        private string _layoutId;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property LayoutId. 
        /// <para>
        /// The unique identifier of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string LayoutId
        {
            get { return this._layoutId; }
            set { this._layoutId = value; }
        }

        // Check to see if LayoutId property is set
        internal bool IsSetLayoutId()
        {
            return this._layoutId != null;
        }

    }
}