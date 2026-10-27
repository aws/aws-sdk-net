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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSessions operation. Retrieves a list that
    /// describes the streaming sessions for a specified stack and fleet. If a UserId is provided
    /// for the stack and fleet, only streaming sessions for that user are described. If an
    /// authentication type is not provided, the default is to authenticate users using a
    /// streaming URL.
    /// </summary>
    public partial class DescribeSessionsRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication method. Specify <c>API</c> for a user authenticated using a streaming
        /// URL or <c>SAML</c> for a SAML federated user. The default is to authenticate users
        /// using a streaming URL.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet. This value is case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetName { get; set; }

        /// <summary>
        /// Checks to see if the FleetName property is set.
        /// </summary>
        internal bool IsSetFleetName() => this.FleetName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier for the instance hosting the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The size of each page of results. The default value is 20 and the maximum value is
        /// 50.
        /// </para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack. This value is case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user identifier (ID). If you specify a user ID, you must also specify the authentication
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
