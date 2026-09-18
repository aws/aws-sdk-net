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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the authorization configuration for using Amazon Cognito user pools with
    /// your AppSync GraphQL API endpoint.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiUserPoolConfigDetails
    {
        /// <summary>
        /// Gets and sets the property AppIdClientRegex. 
        /// <para>
        ///  A regular expression for validating the incoming Amazon Cognito user pools app client
        /// ID. If this value isn't set, no filtering is applied. 
        /// </para>
        /// </summary>
        public string AppIdClientRegex { get; set; }

        /// <summary>
        /// Checks to see if the AppIdClientRegex property is set.
        /// </summary>
        internal bool IsSetAppIdClientRegex() => this.AppIdClientRegex != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        ///  The Amazon Web Services Region in which the user pool was created. 
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        ///  The action that you want your GraphQL API to take when a request that uses Amazon
        /// Cognito user pools authentication doesn't match the Amazon Cognito user pools configuration.
        /// 
        /// </para>
        /// </summary>
        public string DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        ///  The user pool ID. 
        /// </para>
        /// </summary>
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
