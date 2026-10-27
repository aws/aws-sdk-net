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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// This is the response object from the TestInvokeAuthorizer operation.
    /// </summary>
    public partial class TestInvokeAuthorizerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authorization response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Authorization { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Authorization property is set.
        /// </summary>
        internal bool IsSetAuthorization() => this.Authorization != null && (this.Authorization.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Claims. 
        /// <para>
        /// The open identity claims, with any supported custom attributes, returned from the
        /// Cognito Your User Pool configured for the API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Claims { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Claims property is set.
        /// </summary>
        internal bool IsSetClaims() => this.Claims != null && (this.Claims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientStatus. 
        /// <para>
        /// The HTTP status code that the client would have received. Value is 0 if the authorizer
        /// succeeded.
        /// </para>
        /// </summary>
        public int? ClientStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClientStatus property is set.
        /// </summary>
        internal bool IsSetClientStatus() => this.ClientStatus.HasValue;

        /// <summary>
        /// Gets and sets the property Latency. 
        /// <para>
        /// The execution latency, in ms, of the test authorizer request.
        /// </para>
        /// </summary>
        public long? Latency { get; set; }

        /// <summary>
        /// Checks to see if the Latency property is set.
        /// </summary>
        internal bool IsSetLatency() => this.Latency.HasValue;

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The API Gateway execution log for the test authorizer request.
        /// </para>
        /// </summary>
        public string Log { get; set; }

        /// <summary>
        /// Checks to see if the Log property is set.
        /// </summary>
        internal bool IsSetLog() => this.Log != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The JSON policy document returned by the Authorizer
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal identity returned by the Authorizer
        /// </para>
        /// </summary>
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;
    }
}
