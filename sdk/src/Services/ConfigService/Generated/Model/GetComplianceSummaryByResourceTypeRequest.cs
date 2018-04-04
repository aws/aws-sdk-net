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
    /// Container for the parameters to the GetComplianceSummaryByResourceType operation.
    /// Returns the number of resources that are compliant and the number that are noncompliant.
    /// You can specify one or more resource types to get these numbers for each resource
    /// type. The maximum number returned is 100.
    /// </summary>
    public partial class GetComplianceSummaryByResourceTypeRequest : AmazonConfigServiceRequest
    {
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// Specify one or more resource types to get the number of resources that are compliant
        /// and the number that are noncompliant for each resource type.
        /// </para>
        ///  
        /// <para>
        /// For this request, you can specify an AWS resource type such as <code>AWS::EC2::Instance</code>.
        /// You can specify that the resource type is an AWS account by specifying <code>AWS::::Account</code>.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}