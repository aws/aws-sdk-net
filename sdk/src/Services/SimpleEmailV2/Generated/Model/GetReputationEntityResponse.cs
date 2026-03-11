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
    /// Information about the requested reputation entity.
    /// </summary>
    public partial class GetReputationEntityResponse : AmazonWebServiceResponse
    {
        private ReputationEntity _reputationEntity;

        /// <summary>
        /// Gets and sets the property ReputationEntity. 
        /// <para>
        /// The reputation entity information, including status records, policy configuration,
        /// and reputation impact.
        /// </para>
        /// </summary>
        public ReputationEntity ReputationEntity
        {
            get { return this._reputationEntity; }
            set { this._reputationEntity = value; }
        }

        // Check to see if ReputationEntity property is set
        internal bool IsSetReputationEntity()
        {
            return this._reputationEntity != null;
        }

    }
}