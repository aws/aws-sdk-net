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
    /// Container for the parameters to the GetHumanReadableSummary operation.
    /// Retrieves a human readable summary for a given entity. At this time, the only supported
    /// entity type is <c>delegation-request</c> 
    /// 
    ///  
    /// <para>
    /// This method uses a Large Language Model (LLM) to generate the summary.
    /// </para>
    ///  
    /// <para>
    ///  If a delegation request has no owner or owner account, <c>GetHumanReadableSummary</c>
    /// for that delegation request can be called by any account. If the owner account is
    /// assigned but there is no owner id, only identities within that owner account can call
    /// <c>GetHumanReadableSummary</c> for the delegation request to retrieve a summary of
    /// that request. Once the delegation request is fully owned, the owner of the request
    /// gets a default permission to get that delegation request. For more details, read <a
    /// href="">default permissions granted to delegation requests</a>. These rules are identical
    /// to <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetDelegationRequest.html">GetDelegationRequest</a>
    /// API behavior, such that a party who has permissions to call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetDelegationRequest.html">GetDelegationRequest</a>
    /// for a given delegation request will always be able to retrieve the human readable
    /// summary for that request. 
    /// </para>
    /// </summary>
    public partial class GetHumanReadableSummaryRequest : AmazonIdentityManagementServiceRequest
    {
        private string _entityArn;
        private string _locale;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// Arn of the entity to be summarized. At this time, the only supported entity type is
        /// <c>delegation-request</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// A string representing the locale to use for the summary generation. The supported
        /// locale strings are based on the <a href="/awsconsolehelpdocs/latest/gsg/change-language.html#supported-languages">
        /// Supported languages of the Amazon Web Services Management Console </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=12)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}