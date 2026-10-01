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
    /// This is the response object from the UpdateDomain operation.
    /// </summary>
    public partial class UpdateDomainResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainExecutionRole. 
        /// <para>
        /// The domain execution role to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string DomainExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the DomainExecutionRole property is set.
        /// </summary>
        internal bool IsSetDomainExecutionRole() => this.DomainExecutionRole != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Specifies the timestamp of when the domain was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateDomain</c> action.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RootDomainUnitId. 
        /// <para>
        /// The ID of the root domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RootDomainUnitId { get; set; }

        /// <summary>
        /// Checks to see if the RootDomainUnitId property is set.
        /// </summary>
        internal bool IsSetRootDomainUnitId() => this.RootDomainUnitId != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role of the domain.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property SingleSignOn. 
        /// <para>
        /// The single sign-on option of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public SingleSignOn SingleSignOn { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOn property is set.
        /// </summary>
        internal bool IsSetSingleSignOn() => this.SingleSignOn != null;
    }
}
