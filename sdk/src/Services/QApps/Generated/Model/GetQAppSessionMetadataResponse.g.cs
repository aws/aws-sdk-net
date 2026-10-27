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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the GetQAppSessionMetadata operation.
    /// </summary>
    public partial class GetQAppSessionMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The name of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;

        /// <summary>
        /// Gets and sets the property SessionOwner. 
        /// <para>
        /// Indicates whether the current user is the owner of the Q App session.
        /// </para>
        /// </summary>
        public bool? SessionOwner { get; set; }

        /// <summary>
        /// Checks to see if the SessionOwner property is set.
        /// </summary>
        internal bool IsSetSessionOwner() => this.SessionOwner.HasValue;

        /// <summary>
        /// Gets and sets the property SharingConfiguration. 
        /// <para>
        /// The sharing configuration of the Q App data collection session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionSharingConfiguration SharingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SharingConfiguration property is set.
        /// </summary>
        internal bool IsSetSharingConfiguration() => this.SharingConfiguration != null;
    }
}
