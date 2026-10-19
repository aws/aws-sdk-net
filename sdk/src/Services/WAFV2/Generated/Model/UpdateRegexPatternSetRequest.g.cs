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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegexPatternSet operation. Updates the specified
    /// <a>RegexPatternSet</a>. <note> <para> This operation completely replaces the mutable
    /// specifications that you already have for the regex pattern set with the ones that
    /// you provide to this call. </para> <para> To modify a regex pattern set, do the following:
    /// </para> <ol> <li> <para> Retrieve it by calling <a>GetRegexPatternSet</a> </para>
    /// </li> <li> <para> Update its settings as needed </para> </li> <li> <para> Provide
    /// the complete regex pattern set specification to this call </para> </li> </ol> </note>
    /// <para> <b>Temporary inconsistencies during updates</b> </para> <para> When you create
    /// or change a web ACL or other WAF resources, the changes take a small amount of time
    /// to propagate to all areas where the resources are stored. The propagation time can
    /// be from a few seconds to a number of minutes. </para> <para> The following are examples
    /// of the temporary inconsistencies that you might notice during change propagation:
    /// </para> <ul> <li> <para> After you create a web ACL, if you try to associate it with
    /// a resource, you might get an exception indicating that the web ACL is unavailable.
    /// </para> </li> <li> <para> After you add a rule group to a web ACL, the new rule group
    /// rules might be in effect in one area where the web ACL is used and not in another.
    /// </para> </li> <li> <para> After you change a rule action setting, you might see the
    /// old action in some places and the new action in others. </para> </li> <li> <para>
    /// After you add an IP address to an IP set that is in use in a blocking rule, the new
    /// address might be blocked in one area while still allowed in another. </para> </li>
    /// </ul>
    /// </summary>
    public partial class UpdateRegexPatternSetRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the set that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the set. This ID is returned in the responses to create and
        /// list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string LockToken { get; set; }

        /// <summary>
        /// Checks to see if the LockToken property is set.
        /// </summary>
        internal bool IsSetLockToken() => this.LockToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the set. You cannot change the name after you create the set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegularExpressionList. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Regex> RegularExpressionList { get; set; } = AWSConfigs.InitializeCollections ? new List<Regex>() : null;

        /// <summary>
        /// Checks to see if the RegularExpressionList property is set.
        /// </summary>
        internal bool IsSetRegularExpressionList() => this.RegularExpressionList != null && (this.RegularExpressionList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
