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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListAddressListImportJobs operation. Lists jobs
    /// for an address list.
    /// </summary>
    public partial class ListAddressListImportJobsRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The unique identifier of the address list for listing import jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AddressListId { get; set; }

        /// <summary>
        /// Checks to see if the AddressListId property is set.
        /// </summary>
        internal bool IsSetAddressListId() => this.AddressListId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you received a pagination token from a previous call to this API, you can provide
        /// it here to continue paginating through the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of import jobs that are returned per call. You can use NextToken
        /// to retrieve the next page of jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}
