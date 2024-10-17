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
    /// Container for the parameters to the AcceptDataGrant operation.
    /// This operation accepts a data grant.
    /// </summary>
    public partial class AcceptDataGrantRequest : AmazonDataExchangeRequest
    {
        private string _dataGrantArn;

        /// <summary>
        /// Gets and sets the property DataGrantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data grant to accept.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataGrantArn
        {
            get { return this._dataGrantArn; }
            set { this._dataGrantArn = value; }
        }

        // Check to see if DataGrantArn property is set
        internal bool IsSetDataGrantArn()
        {
            return this._dataGrantArn != null;
        }

    }
}