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
    /// 
    /// </summary>
    public partial class DescribeAccountAttributesResponse : AmazonWebServiceResponse
    {
        private List<AccountQuota> _accountQuotas = new List<AccountQuota>();
        private string _uniqueAccountIdentifier;

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

        /// <summary>
        /// Gets and sets the property UniqueAccountIdentifier. 
        /// <para>
        /// A unique AWS DMS identifier for an account in a particular AWS Region. The value of
        /// this identifier has the following format: <code>c99999999999</code>. DMS uses this
        /// identifier to name artifacts. For example, DMS uses this identifier to name the default
        /// Amazon S3 bucket for storing task assessment reports in a given AWS Region. The format
        /// of this S3 bucket name is the following: <code>dms-<i>AccountNumber</i>-<i>UniqueAccountIdentifier</i>.</code>
        /// Here is an example name for this default S3 bucket: <code>dms-111122223333-c44445555666</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS DMS supports the <code>UniqueAccountIdentifier</code> parameter in versions 3.1.4
        /// and later.
        /// </para>
        ///  </note>
        /// </summary>
        public string UniqueAccountIdentifier
        {
            get { return this._uniqueAccountIdentifier; }
            set { this._uniqueAccountIdentifier = value; }
        }

        // Check to see if UniqueAccountIdentifier property is set
        internal bool IsSetUniqueAccountIdentifier()
        {
            return this._uniqueAccountIdentifier != null;
        }

    }
}