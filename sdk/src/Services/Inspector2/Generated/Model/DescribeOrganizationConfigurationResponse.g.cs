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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganizationConfiguration operation.
    /// </summary>
    public partial class DescribeOrganizationConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// The scan types are automatically enabled for new members of your organization.
        /// </para>
        /// </summary>
        public AutoEnable AutoEnable { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnable property is set.
        /// </summary>
        internal bool IsSetAutoEnable() => this.AutoEnable != null;

        /// <summary>
        /// Gets and sets the property MaxAccountLimitReached. 
        /// <para>
        /// Represents whether your organization has reached the maximum Amazon Web Services account
        /// limit for Amazon Inspector.
        /// </para>
        /// </summary>
        public bool? MaxAccountLimitReached { get; set; }

        /// <summary>
        /// Checks to see if the MaxAccountLimitReached property is set.
        /// </summary>
        internal bool IsSetMaxAccountLimitReached() => this.MaxAccountLimitReached.HasValue;
    }
}
