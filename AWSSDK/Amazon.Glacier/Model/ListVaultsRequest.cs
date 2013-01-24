/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the ListVaults operation.
    /// <para>This operation lists all vaults owned by the calling user's account. The list returned in the response is ASCII-sorted by vault name.
    /// </para> <para>By default, this operation returns up to 1,000 items. If there are more vaults to list, the response <c>marker</c> field
    /// contains the vault Amazon Resource Name (ARN) at which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
    /// field is <c>null</c> . To return a list of vaults that begins at a specific vault, set the <c>marker</c> request parameter to the vault ARN
    /// you obtained from a previous List Vaults request. You can also limit the number of vaults returned in the response by specifying the
    /// <c>limit</c> parameter in the request. </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform
    /// specific actions. For more information, see Access Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual
    /// information and underlying REST API, go to Retrieving Vault Metadata in Amazon Glacier and List Vaults in the <i>Amazon Glacier Developer
    /// Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.ListVaults"/>
    public class ListVaultsRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string marker;
        private int? limit;

        /// <summary>
        /// The <c>AccountId</c> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses
        /// the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it.
        ///  
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        /// <summary>
        /// Sets the AccountId property
        /// </summary>
        /// <param name="accountId">The value to set for the AccountId property </param>
        /// <returns>this instance</returns>
        public ListVaultsRequest WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
        }
            

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this.accountId != null;       
        }

        /// <summary>
        /// A string used for pagination. The marker specifies the vault ARN after which the listing of vaults should begin.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public ListVaultsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }

        /// <summary>
        /// The maximum number of items returned in the response. If you don't specify a value, the List Vaults operation returns up to 1,000 items.
        ///  
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        public ListVaultsRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;       
        }
    }
}
    
