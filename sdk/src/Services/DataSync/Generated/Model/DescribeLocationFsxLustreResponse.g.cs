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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeLocationFsxLustre operation.
    /// </summary>
    public partial class DescribeLocationFsxLustreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the FSx for Lustre location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the FSx for Lustre location that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI of the FSx for Lustre location that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4360)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups that are configured for the
        /// FSx for Lustre file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> SecurityGroupArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupArns property is set.
        /// </summary>
        internal bool IsSetSecurityGroupArns() => this.SecurityGroupArns != null && (this.SecurityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
