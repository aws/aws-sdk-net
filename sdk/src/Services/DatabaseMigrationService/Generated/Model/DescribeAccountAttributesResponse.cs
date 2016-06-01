/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountAttributes operation.
    /// </summary>
    public partial class DescribeAccountAttributesResponse : AmazonWebServiceResponse
    {
        private List<AccountQuota> _accountQuotas = new List<AccountQuota>();

        /// <summary>
        /// Gets and sets the property AccountQuotas. 
        /// <para>
        /// Account quota information.
        /// </para>
        /// </summary>
        public List<AccountQuota> AccountQuotas
        {
            get { return this._accountQuotas; }
            set { this._accountQuotas = value; }
        }

        // Check to see if AccountQuotas property is set
        internal bool IsSetAccountQuotas()
        {
            return this._accountQuotas != null && this._accountQuotas.Count > 0; 
        }

    }
}