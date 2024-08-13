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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// This is the response object from the FractionalSeconds operation.
    /// </summary>
    public partial class FractionalSecondsResponse : AmazonWebServiceResponse
    {
        private DateTime? _datetime;

        /// <summary>
        /// Gets and sets the property Datetime.
        /// </summary>
        public DateTime? Datetime
        {
            get { return this._datetime; }
            set { this._datetime = value; }
        }

        // Check to see if Datetime property is set
        internal bool IsSetDatetime()
        {
            return this._datetime.HasValue; 
        }

    }
}