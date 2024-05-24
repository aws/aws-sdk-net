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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an origin group for the CloudFront distribution.
    /// </summary>
    public partial class AwsCloudFrontDistributionOriginGroup
    {
        private AwsCloudFrontDistributionOriginGroupFailover _failoverCriteria;

        /// <summary>
        /// Gets and sets the property FailoverCriteria. 
        /// <para>
        /// Provides the criteria for an origin group to fail over.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginGroupFailover FailoverCriteria
        {
            get { return this._failoverCriteria; }
            set { this._failoverCriteria = value; }
        }

        // Check to see if FailoverCriteria property is set
        internal bool IsSetFailoverCriteria()
        {
            return this._failoverCriteria != null;
        }

    }
}