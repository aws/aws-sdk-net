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
    /// Container for the parameters to the RejectPredictions operation. Rejects automatically
    /// generated business-friendly metadata for your Amazon DataZone assets.
    /// </summary>
    public partial class RejectPredictionsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
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
        /// The identifier of the prediction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property RejectChoices. 
        /// <para>
        /// Specifies the prediction (aka, the automatically generated piece of metadata) and
        /// the target (for example, a column name) that can be rejected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RejectChoice> RejectChoices { get; set; } = AWSConfigs.InitializeCollections ? new List<RejectChoice>() : null;

        /// <summary>
        /// Checks to see if the RejectChoices property is set.
        /// </summary>
        internal bool IsSetRejectChoices() => this.RejectChoices != null && (this.RejectChoices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RejectRule. 
        /// <para>
        /// Specifies the rule (or the conditions) under which a prediction can be rejected.
        /// </para>
        /// </summary>
        public RejectRule RejectRule { get; set; }

        /// <summary>
        /// Checks to see if the RejectRule property is set.
        /// </summary>
        internal bool IsSetRejectRule() => this.RejectRule != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision that is to be made to the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;
    }
}
