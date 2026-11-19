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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ListKeys operation. Gets a list of all KMS keys
    /// in the caller's Amazon Web Services account and Region. <para> You can also use <c>ListKeys</c>
    /// to list KMS keys in the Region that other Amazon Web Services accounts shared with
    /// the caller's Amazon Web Services account through Resource Access Manager (RAM). To
    /// list them, use the <c>ResourceOwners</c> parameter. If you omit <c>ResourceOwners</c>,
    /// <c>ListKeys</c> lists only the KMS keys in the caller's Amazon Web Services account.
    /// </para> <para> When <c>ResourceOwners</c> includes <c>OTHER_ACCOUNTS_VIA_RAM</c>,
    /// <c>ListKeys</c> returns the KMS keys that other Amazon Web Services accounts currently
    /// share with the caller's Amazon Web Services account through RAM. For information about
    /// how and when a resource that another account shares becomes available to your Amazon
    /// Web Services account, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/working-with-shared.html">Access
    /// Amazon Web Services resources shared with you</a> in the <i>RAM User Guide</i>. </para>
    /// <para> <b>Cross-account use</b>: No. This operation doesn't take a KMS key parameter,
    /// so you can't use it to list the KMS keys of a specific Amazon Web Services account.
    /// The only KMS keys in other Amazon Web Services accounts that <c>ListKeys</c> returns
    /// are the ones that other accounts shared with the caller's Amazon Web Services account
    /// through RAM. To list them, set the <c>ResourceOwners</c> parameter to include <c>OTHER_ACCOUNTS_VIA_RAM</c>.
    /// </para> <para> <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeys</a>
    /// (IAM policy) </para> <para> The same <c>kms:ListKeys</c> permission lets you list
    /// the KMS keys that other accounts shared with you through RAM. KMS doesn't evaluate
    /// the key policies of shared KMS keys when it lists them. To use a shared KMS key, you
    /// need permission for each operation on that KMS key. </para> <para> <b>Related operations:</b>
    /// </para> <ul> <li> <para> <a>CreateKey</a> </para> </li> <li> <para> <a>DescribeKey</a>
    /// </para> </li> <li> <para> <a>ListAliases</a> </para> </li> <li> <para> <a>ListResourceTags</a>
    /// </para> </li> </ul> <para> <b>Eventual consistency</b>: The KMS API follows an eventual
    /// consistency model. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>. </para> <para> KMS keys that other Amazon Web Services accounts
    /// share with you can take some time to appear in or disappear from <c>ListKeys</c> results
    /// after changes to resource shares, such as accepting an invitation or deleting a resource
    /// share. </para>
    /// </summary>
    public partial class ListKeysRequest : AmazonKeyManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Use this parameter to specify the maximum number of items to return. When this value
        /// is present, KMS does not return more than the specified number of items, but it might
        /// return fewer.
        /// </para>
        ///  
        /// <para>
        /// This value is optional. If you include a value, it must be between 1 and 1000, inclusive.
        /// If you do not include a value, it defaults to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter in a subsequent request after you receive a response with truncated
        /// results. Set it to the value of <c>NextMarker</c> from the truncated response you
        /// just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property ResourceOwners. 
        /// <para>
        /// Specifies whose KMS keys to list. Use this parameter to list KMS keys that other Amazon
        /// Web Services accounts shared with your Amazon Web Services account through Resource
        /// Access Manager (RAM).
        /// </para>
        ///  
        /// <para>
        /// Specify one or two values. Valid values are:
        /// </para>
        ///  <dl> <dt>SELF</dt> <dd> 
        /// <para>
        /// Lists the KMS keys in your Amazon Web Services account and Region.
        /// </para>
        ///  </dd> <dt>OTHER_ACCOUNTS_VIA_RAM</dt> <dd> 
        /// <para>
        /// Lists the KMS keys in the Region that other Amazon Web Services accounts currently
        /// share with your Amazon Web Services account through RAM. This list doesn't include
        /// KMS keys that your Amazon Web Services account owns. For each of these KMS keys, the
        /// key ARN in the response contains the account ID of the Amazon Web Services account
        /// that owns the KMS key.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If you omit this parameter, <c>ListKeys</c> lists only the KMS keys in your Amazon
        /// Web Services account. If you specify both values, in either order, <c>ListKeys</c>
        /// returns the KMS keys in your Amazon Web Services account first, and then the KMS keys
        /// that other Amazon Web Services accounts shared with you. A single response doesn't
        /// contain both kinds of KMS keys.
        /// </para>
        ///  
        /// <para>
        /// When <c>ResourceOwners</c> includes <c>OTHER_ACCOUNTS_VIA_RAM</c>, a response can
        /// contain fewer KMS keys than the <c>Limit</c> value, or none, even when <c>Truncated</c>
        /// is true. To get all of the KMS keys, continue calling <c>ListKeys</c> with the <c>NextMarker</c>
        /// value from each response until <c>Truncated</c> is false. Use a <c>NextMarker</c>
        /// value only in a request that has the same <c>ResourceOwners</c> value as the request
        /// that returned it. Otherwise, the request can fail with an <c>InvalidMarkerException</c>.
        /// </para>
        ///  
        /// <para>
        /// KMS keys that other Amazon Web Services accounts share with you can take some time
        /// to appear in or disappear from the results after changes to resource shares.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> ResourceOwners { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceOwners property is set.
        /// </summary>
        internal bool IsSetResourceOwners() => this.ResourceOwners != null && (this.ResourceOwners.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
