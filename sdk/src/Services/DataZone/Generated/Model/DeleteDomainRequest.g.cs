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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDomain operation. Deletes a Amazon DataZone
    /// domain.
    /// </summary>
    public partial class DeleteDomainRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property CascadeDelete. 
        /// <para>
        /// Specifies whether to delete the domain along with all of its associated resources.
        /// When you use this parameter, Amazon DataZone deletes the domain and cleanly removes
        /// its associated resources without leaving orphaned resources behind. Amazon DataZone
        /// reports deletion progress in the <c>deleteProgress</c> field. Amazon DataZone reports
        /// any resources that it can't delete in the <c>failureReasons</c> field of the <c>GetDomain</c>
        /// response. You can't use this parameter together with <c>skipDeletionCheck</c>. If
        /// you don't specify a value, the default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? CascadeDelete { get; set; }

        /// <summary>
        /// Checks to see if the CascadeDelete property is set.
        /// </summary>
        internal bool IsSetCascadeDelete() => this.CascadeDelete.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the Amazon Web Services domain that is to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property SkipDeletionCheck. 
        /// <para>
        /// Specifies whether to skip the check that prevents deletion of a domain that still
        /// contains resources. When you use this parameter, Amazon DataZone deletes the domain
        /// but might not remove its associated resources, which can leave orphaned resources
        /// behind. To delete a domain and fully clean up its associated resources, use <c>cascadeDelete</c>
        /// instead. You can't use this parameter together with <c>cascadeDelete</c>.
        /// </para>
        /// </summary>
        public bool? SkipDeletionCheck { get; set; }

        /// <summary>
        /// Checks to see if the SkipDeletionCheck property is set.
        /// </summary>
        internal bool IsSetSkipDeletionCheck() => this.SkipDeletionCheck.HasValue;
    }
}
