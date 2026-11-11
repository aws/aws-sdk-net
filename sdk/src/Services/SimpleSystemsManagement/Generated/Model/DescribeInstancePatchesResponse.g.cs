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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeInstancePatches operation.
    /// </summary>
    public partial class DescribeInstancePatchesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. If there are no additional
        /// items to return, the string is empty.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Patches. 
        /// <para>
        /// Each entry in the array is a structure containing:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Title (string)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KBId (string)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classification (string)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Severity (string)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// State (string, such as "INSTALLED" or "FAILED")
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstalledTime (DateTime)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstalledBy (string)
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PatchComplianceData> Patches { get; set; } = AWSConfigs.InitializeCollections ? new List<PatchComplianceData>() : null;

        /// <summary>
        /// Checks to see if the Patches property is set.
        /// </summary>
        internal bool IsSetPatches() => this.Patches != null && (this.Patches.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
