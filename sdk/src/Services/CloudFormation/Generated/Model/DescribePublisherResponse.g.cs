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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribePublisher operation.
    /// </summary>
    public partial class DescribePublisherResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The type of account used as the identity provider when registering this publisher
        /// with CloudFormation.
        /// </para>
        /// </summary>
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Checks to see if the PublisherId property is set.
        /// </summary>
        internal bool IsSetPublisherId() => this.PublisherId != null;

        /// <summary>
        /// Gets and sets the property PublisherProfile. 
        /// <para>
        /// The URL to the publisher's profile with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PublisherProfile { get; set; }

        /// <summary>
        /// Checks to see if the PublisherProfile property is set.
        /// </summary>
        internal bool IsSetPublisherProfile() => this.PublisherProfile != null;

        /// <summary>
        /// Gets and sets the property PublisherStatus. 
        /// <para>
        /// Whether the publisher is verified. Currently, all registered publishers are verified.
        /// </para>
        /// </summary>
        public PublisherStatus PublisherStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublisherStatus property is set.
        /// </summary>
        internal bool IsSetPublisherStatus() => this.PublisherStatus != null;
    }
}
