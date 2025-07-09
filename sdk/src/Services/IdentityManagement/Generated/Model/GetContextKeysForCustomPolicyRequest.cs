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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetContextKeysForCustomPolicy operation.
    /// Gets a list of all of the context keys referenced in the input policies. The policies
    /// are supplied as a list of one or more strings. To get the context keys from policies
    /// associated with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
    /// 
    ///  
    /// <para>
    /// Context keys are variables maintained by Amazon Web Services and its services that
    /// provide details about the context of an API query request. Context keys can be evaluated
    /// by testing against a value specified in an IAM policy. Use <c>GetContextKeysForCustomPolicy</c>
    /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>.
    /// Note that all parameters are shown in unencoded form here for clarity but must be
    /// URL encoded to be included as a part of a real HTML request.
    /// </para>
    /// </summary>
    public partial class GetContextKeysForCustomPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _policyInputList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PolicyInputList. 
        /// <para>
        /// A list of policies for which you want the list of context keys referenced in those
        /// policies. Each document is specified as a string containing the complete, valid JSON
        /// text of an IAM policy.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<c>\u0020</c>) through
        /// the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <c>\u00FF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage
        /// return (<c>\u000D</c>)
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PolicyInputList
        {
            get { return this._policyInputList; }
            set { this._policyInputList = value; }
        }

        // Check to see if PolicyInputList property is set
        internal bool IsSetPolicyInputList()
        {
            return this._policyInputList != null && (this._policyInputList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}