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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeAccountAttributesResponse : AmazonWebServiceResponse
    {
        private List<AccountQuota> _accountQuotas = AWSConfigs.InitializeCollections ? new List<AccountQuota>() : null;
        private string _uniqueAccountIdentifier;

        /// <summary>
        /// Gets and sets the property AccountQuotas. 
        /// <para>
        /// Account quota information.
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

        /// <summary>
        /// Gets and sets the property UniqueAccountIdentifier. 
        /// <para>
        /// A unique DMS identifier for an account in a particular Amazon Web Services Region.
        /// The value of this identifier has the following format: <c>c99999999999</c>. DMS uses
        /// this identifier to name artifacts. For example, DMS uses this identifier to name the
        /// default Amazon S3 bucket for storing task assessment reports in a given Amazon Web
        /// Services Region. The format of this S3 bucket name is the following: <c>dms-<i>AccountNumber</i>-<i>UniqueAccountIdentifier</i>.</c>
        /// Here is an example name for this default S3 bucket: <c>dms-111122223333-c44445555666</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS supports the <c>UniqueAccountIdentifier</c> parameter in versions 3.1.4 and later.
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