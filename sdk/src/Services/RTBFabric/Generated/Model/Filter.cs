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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the configuration of a filter.
    /// </summary>
    public partial class Filter
    {
        private List<FilterCriterion> _criteria = AWSConfigs.InitializeCollections ? new List<FilterCriterion>() : null;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// Describes the criteria for a filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FilterCriterion> Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null && (this._criteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}