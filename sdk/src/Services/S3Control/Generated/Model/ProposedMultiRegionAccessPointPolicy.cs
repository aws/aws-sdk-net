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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The proposed access control policy for the Multi-Region Access Point.
    /// 
    ///  
    /// <para>
    /// When you update the policy, the update is first listed as the proposed policy. After
    /// the update is finished and all Regions have been updated, the proposed policy is listed
    /// as the established policy. If both policies have the same version number, the proposed
    /// policy is the established policy.
    /// </para>
    /// </summary>
    public partial class ProposedMultiRegionAccessPointPolicy
    {
        private string _policy;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The details of the proposed policy.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}