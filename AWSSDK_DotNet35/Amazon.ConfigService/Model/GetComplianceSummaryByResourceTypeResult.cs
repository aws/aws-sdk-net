/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetComplianceSummaryByResourceTypeResult : AmazonWebServiceResponse
    {
        private List<ComplianceSummaryByResourceType> _complianceSummariesByResourceType = new List<ComplianceSummaryByResourceType>();

        /// <summary>
        /// Gets and sets the property ComplianceSummariesByResourceType. 
        /// <para>
        /// The number of resources that are compliant and the number that are noncompliant. If
        /// one or more resource types were provided with the request, the numbers are returned
        /// for each resource type. The maximum number returned is 100.
        /// </para>
        /// </summary>
        public List<ComplianceSummaryByResourceType> ComplianceSummariesByResourceType
        {
            get { return this._complianceSummariesByResourceType; }
            set { this._complianceSummariesByResourceType = value; }
        }

        // Check to see if ComplianceSummariesByResourceType property is set
        internal bool IsSetComplianceSummariesByResourceType()
        {
            return this._complianceSummariesByResourceType != null && this._complianceSummariesByResourceType.Count > 0; 
        }

    }
}