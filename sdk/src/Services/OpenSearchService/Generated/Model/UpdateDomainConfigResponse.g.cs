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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the UpdateDomainConfig operation.
    /// </summary>
    public partial class UpdateDomainConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DomainConfig. 
        /// <para>
        /// The status of the updated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DomainConfig DomainConfig { get; set; }

        /// <summary>
        /// Checks to see if the DomainConfig property is set.
        /// </summary>
        internal bool IsSetDomainConfig() => this.DomainConfig != null;

        /// <summary>
        /// Gets and sets the property DryRunProgressStatus. 
        /// <para>
        /// The status of the dry run being performed on the domain, if any.
        /// </para>
        /// </summary>
        public DryRunProgressStatus DryRunProgressStatus { get; set; }

        /// <summary>
        /// Checks to see if the DryRunProgressStatus property is set.
        /// </summary>
        internal bool IsSetDryRunProgressStatus() => this.DryRunProgressStatus != null;

        /// <summary>
        /// Gets and sets the property DryRunResults. 
        /// <para>
        /// Results of the dry run performed in the update domain request.
        /// </para>
        /// </summary>
        public DryRunResults DryRunResults { get; set; }

        /// <summary>
        /// Checks to see if the DryRunResults property is set.
        /// </summary>
        internal bool IsSetDryRunResults() => this.DryRunResults != null;
    }
}
