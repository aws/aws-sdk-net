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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataGrant operation.
    /// This operation returns information about a data grant.
    /// </summary>
    public partial class GetDataGrantRequest : AmazonDataExchangeRequest
    {
        private string _dataGrantId;

        /// <summary>
        /// Gets and sets the property DataGrantId. 
        /// <para>
        /// The ID of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataGrantId
        {
            get { return this._dataGrantId; }
            set { this._dataGrantId = value; }
        }

        // Check to see if DataGrantId property is set
        internal bool IsSetDataGrantId()
        {
            return this._dataGrantId != null;
        }

    }
}