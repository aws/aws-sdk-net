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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplication operation. Returns information
    /// about a specific Managed Service for Apache Flink application. <para> If you want
    /// to retrieve a list of all applications in your account, use the <a>ListApplications</a>
    /// operation. </para>
    /// </summary>
    public partial class DescribeApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property IncludeAdditionalDetails. 
        /// <para>
        /// Displays verbose information about a Managed Service for Apache Flink application,
        /// including the application's job plan.
        /// </para>
        /// </summary>
        public bool? IncludeAdditionalDetails { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAdditionalDetails property is set.
        /// </summary>
        internal bool IsSetIncludeAdditionalDetails() => this.IncludeAdditionalDetails.HasValue;
    }
}
