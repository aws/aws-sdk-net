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
    /// Container for the parameters to the UpdateAccountPool operation. Updates the account
    /// pool.
    /// </summary>
    public partial class UpdateAccountPoolRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AccountSource. 
        /// <para>
        /// The source of accounts for the account pool. In the current release, it's either a
        /// static list of accounts provided by the customer or a custom Amazon Web Services Lambda
        /// handler. 
        /// </para>
        /// </summary>
        public AccountSource AccountSource { get; set; }

        /// <summary>
        /// Checks to see if the AccountSource property is set.
        /// </summary>
        internal bool IsSetAccountSource() => this.AccountSource != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the account pool that is to be udpated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The domain ID where the account pool that is to be updated lives.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the account pool that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account pool that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResolutionStrategy. 
        /// <para>
        /// The mechanism used to resolve the account selection from the account pool.
        /// </para>
        /// </summary>
        public ResolutionStrategy ResolutionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionStrategy property is set.
        /// </summary>
        internal bool IsSetResolutionStrategy() => this.ResolutionStrategy != null;
    }
}
