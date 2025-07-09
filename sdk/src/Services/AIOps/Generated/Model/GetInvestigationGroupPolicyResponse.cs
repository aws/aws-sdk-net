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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
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
namespace Amazon.AIOps.Model
{
    /// <summary>
    /// This is the response object from the GetInvestigationGroupPolicy operation.
    /// </summary>
    public partial class GetInvestigationGroupPolicyResponse : AmazonWebServiceResponse
    {
        private string _investigationGroupArn;
        private string _policy;

        /// <summary>
        /// Gets and sets the property InvestigationGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the investigation group that you want to view the
        /// policy of.
        /// </para>
        /// </summary>
        public string InvestigationGroupArn
        {
            get { return this._investigationGroupArn; }
            set { this._investigationGroupArn = value; }
        }

        // Check to see if InvestigationGroupArn property is set
        internal bool IsSetInvestigationGroupArn()
        {
            return this._investigationGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
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