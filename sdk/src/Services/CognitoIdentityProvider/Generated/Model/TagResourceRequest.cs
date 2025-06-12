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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns a set of tags to an Amazon Cognito user pool. A tag is a label that you can
    /// use to categorize and manage user pools in different ways, such as by purpose, owner,
    /// environment, or other criteria.
    /// 
    ///  
    /// <para>
    /// Each tag consists of a key and value, both of which you define. A key is a general
    /// category for more specific values. For example, if you have two versions of a user
    /// pool, one for testing and another for production, you might assign an <c>Environment</c>
    /// tag key to both user pools. The value of this key might be <c>Test</c> for one user
    /// pool, and <c>Production</c> for the other.
    /// </para>
    ///  
    /// <para>
    /// Tags are useful for cost tracking and access control. You can activate your tags so
    /// that they appear on the Billing and Cost Management console, where you can track the
    /// costs associated with your user pools. In an Identity and Access Management policy,
    /// you can constrain permissions for user pools based on specific tags or tag values.
    /// </para>
    ///  
    /// <para>
    /// You can use this action up to 5 times per second, per account. A user pool can have
    /// as many as 50 tags.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user pool to assign the tags to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tag keys and values that you want to assign to the user pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}