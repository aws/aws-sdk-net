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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetReputationEntity operation.
    /// Retrieve information about a specific reputation entity, including its reputation
    /// management policy, customer-managed status, Amazon Web Services Amazon SES-managed
    /// status, and aggregate sending status.
    /// 
    ///  
    /// <para>
    ///  <i>Reputation entities</i> represent resources in your Amazon SES account that have
    /// reputation tracking and management capabilities. The reputation impact reflects the
    /// highest impact reputation finding for the entity. Reputation findings can be retrieved
    /// using the <c>ListRecommendations</c> operation.
    /// </para>
    /// </summary>
    public partial class GetReputationEntityRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _reputationEntityReference;
        private ReputationEntityType _reputationEntityType;

        /// <summary>
        /// Gets and sets the property ReputationEntityReference. 
        /// <para>
        /// The unique identifier for the reputation entity. For resource-type entities, this
        /// is the Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ReputationEntityReference
        {
            get { return this._reputationEntityReference; }
            set { this._reputationEntityReference = value; }
        }

        // Check to see if ReputationEntityReference property is set
        internal bool IsSetReputationEntityReference()
        {
            return this._reputationEntityReference != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationEntityType. 
        /// <para>
        /// The type of reputation entity. Currently, only <c>RESOURCE</c> type entities are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReputationEntityType ReputationEntityType
        {
            get { return this._reputationEntityType; }
            set { this._reputationEntityType = value; }
        }

        // Check to see if ReputationEntityType property is set
        internal bool IsSetReputationEntityType()
        {
            return this._reputationEntityType != null;
        }

    }
}