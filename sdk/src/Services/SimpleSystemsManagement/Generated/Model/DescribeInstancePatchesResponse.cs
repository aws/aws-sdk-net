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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeInstancePatches operation.
    /// </summary>
    public partial class DescribeInstancePatchesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PatchComplianceData> _patches = new List<PatchComplianceData>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. If there are no additional
        /// items to return, the string is empty.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Patches. 
        /// <para>
        /// Each entry in the array is a structure containing:
        /// </para>
        ///  
        /// <para>
        /// Title (string)
        /// </para>
        ///  
        /// <para>
        /// KBId (string)
        /// </para>
        ///  
        /// <para>
        /// Classification (string)
        /// </para>
        ///  
        /// <para>
        /// Severity (string)
        /// </para>
        ///  
        /// <para>
        /// State (string: "INSTALLED", "INSTALLED OTHER", "MISSING", "NOT APPLICABLE", "FAILED")
        /// </para>
        ///  
        /// <para>
        /// InstalledTime (DateTime)
        /// </para>
        ///  
        /// <para>
        /// InstalledBy (string)
        /// </para>
        /// </summary>
        public List<PatchComplianceData> Patches
        {
            get { return this._patches; }
            set { this._patches = value; }
        }

        // Check to see if Patches property is set
        internal bool IsSetPatches()
        {
            return this._patches != null && this._patches.Count > 0; 
        }

    }
}