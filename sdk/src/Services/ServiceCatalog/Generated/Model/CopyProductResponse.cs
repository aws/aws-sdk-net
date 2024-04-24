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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the CopyProduct operation.
    /// </summary>
    public partial class CopyProductResponse : AmazonWebServiceResponse
    {
        private string _copyProductToken;

        /// <summary>
        /// Gets and sets the property CopyProductToken. 
        /// <para>
        /// The token to use to track the progress of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string CopyProductToken
        {
            get { return this._copyProductToken; }
            set { this._copyProductToken = value; }
        }

        // Check to see if CopyProductToken property is set
        internal bool IsSetCopyProductToken()
        {
            return this._copyProductToken != null;
        }

    }
}