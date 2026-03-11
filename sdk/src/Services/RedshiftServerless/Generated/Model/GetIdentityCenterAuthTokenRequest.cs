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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityCenterAuthToken operation.
    /// Returns an Identity Center authentication token for accessing Amazon Redshift Serverless
    /// workgroups.
    /// 
    ///  
    /// <para>
    /// The token provides secure access to data within the specified workgroups using Identity
    /// Center identity propagation. The token expires after a specified duration and must
    /// be refreshed for continued access.
    /// </para>
    ///  
    /// <para>
    /// The Identity and Access Management (IAM) user or role that runs GetIdentityCenterAuthToken
    /// must have appropriate permissions to access the specified workgroups and Identity
    /// Center integration must be configured for the workgroups.
    /// </para>
    /// </summary>
    public partial class GetIdentityCenterAuthTokenRequest : AmazonRedshiftServerlessRequest
    {
        private List<string> _workgroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property WorkgroupNames. 
        /// <para>
        /// A list of workgroup names for which to generate the Identity Center authentication
        /// token.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain between 1 and 20 workgroup names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each workgroup name must be a valid Amazon Redshift Serverless workgroup identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All specified workgroups must have Identity Center integration enabled.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> WorkgroupNames
        {
            get { return this._workgroupNames; }
            set { this._workgroupNames = value; }
        }

        // Check to see if WorkgroupNames property is set
        internal bool IsSetWorkgroupNames()
        {
            return this._workgroupNames != null && (this._workgroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}