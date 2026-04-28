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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Output for the BatchGetTargetDomains operation
    /// </summary>
    public partial class BatchGetTargetDomainsResponse : AmazonWebServiceResponse
    {
        private List<string> _notFound = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TargetDomain> _targetDomains = AWSConfigs.InitializeCollections ? new List<TargetDomain>() : null;

        /// <summary>
        /// Gets and sets the property NotFound. 
        /// <para>
        /// List of target domain IDs that could not be found
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotFound
        {
            get { return this._notFound; }
            set { this._notFound = value; }
        }

        // Check to see if NotFound property is set
        internal bool IsSetNotFound()
        {
            return this._notFound != null && (this._notFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetDomains. 
        /// <para>
        /// List of target domains that were successfully retrieved
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetDomain> TargetDomains
        {
            get { return this._targetDomains; }
            set { this._targetDomains = value; }
        }

        // Check to see if TargetDomains property is set
        internal bool IsSetTargetDomains()
        {
            return this._targetDomains != null && (this._targetDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}