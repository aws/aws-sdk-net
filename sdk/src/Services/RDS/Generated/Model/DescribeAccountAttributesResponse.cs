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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Data returned by the <b>DescribeAccountAttributes</b> action.
    /// </summary>
    public partial class DescribeAccountAttributesResponse : AmazonWebServiceResponse
    {
        private List<AccountQuota> _accountQuotas = AWSConfigs.InitializeCollections ? new List<AccountQuota>() : null;

        /// <summary>
        /// Gets and sets the property AccountQuotas. 
        /// <para>
        /// A list of <c>AccountQuota</c> objects. Within this list, each quota has a name, a
        /// count of usage toward the quota maximum, and a maximum value for the quota.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountQuota> AccountQuotas
        {
            get { return this._accountQuotas; }
            set { this._accountQuotas = value; }
        }

        // Check to see if AccountQuotas property is set
        internal bool IsSetAccountQuotas()
        {
            return this._accountQuotas != null && (this._accountQuotas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}