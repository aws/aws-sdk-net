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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
        private IdentityProvider _identityProvider;
        private string _publisherId;
        private string _publisherProfile;
        private PublisherStatus _publisherStatus;

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The type of account used as the identity provider when registering this publisher
        /// with CloudFormation.
        /// </para>
        /// </summary>
        public IdentityProvider IdentityProvider
        {
            get { return this._identityProvider; }
            set { this._identityProvider = value; }
        }

        // Check to see if IdentityProvider property is set
        internal bool IsSetIdentityProvider()
        {
            return this._identityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherProfile. 
        /// <para>
        /// The URL to the publisher's profile with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string PublisherProfile
        {
            get { return this._publisherProfile; }
            set { this._publisherProfile = value; }
        }

        // Check to see if PublisherProfile property is set
        internal bool IsSetPublisherProfile()
        {
            return this._publisherProfile != null;
        }

        /// <summary>
        /// Gets and sets the property PublisherStatus. 
        /// <para>
        /// Whether the publisher is verified. Currently, all registered publishers are verified.
        /// </para>
        /// </summary>
        public PublisherStatus PublisherStatus
        {
            get { return this._publisherStatus; }
            set { this._publisherStatus = value; }
        }

        // Check to see if PublisherStatus property is set
        internal bool IsSetPublisherStatus()
        {
            return this._publisherStatus != null;
        }

    }
}