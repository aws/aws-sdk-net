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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing the response for the request.
    /// </summary>
    public partial class ChangeResourceRecordSetsResponse : AmazonWebServiceResponse
    {
        private ChangeInfo _changeInfo;

        /// <summary>
        /// Gets and sets the property ChangeInfo. 
        /// <para>
        /// A complex type that contains information about changes made to your hosted zone.
        /// </para>
        ///  
        /// <para>
        /// This element contains an ID that you use when performing a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html">GetChange</a>
        /// action to get detailed information about the change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeInfo ChangeInfo
        {
            get { return this._changeInfo; }
            set { this._changeInfo = value; }
        }

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this._changeInfo != null;
        }

    }
}