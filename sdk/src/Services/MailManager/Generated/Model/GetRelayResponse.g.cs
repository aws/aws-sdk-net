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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetRelay operation.
    /// </summary>
    public partial class GetRelayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// The authentication attribute—contains the secret ARN where the customer relay server
        /// credentials are stored. 
        /// </para>
        /// </summary>
        public RelayAuthentication Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the relay was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The timestamp of when relay was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimestamp() => this.LastModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RelayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the relay.
        /// </para>
        /// </summary>
        public string RelayArn { get; set; }

        /// <summary>
        /// Checks to see if the RelayArn property is set.
        /// </summary>
        internal bool IsSetRelayArn() => this.RelayArn != null;

        /// <summary>
        /// Gets and sets the property RelayId. 
        /// <para>
        /// The unique relay identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RelayId { get; set; }

        /// <summary>
        /// Checks to see if the RelayId property is set.
        /// </summary>
        internal bool IsSetRelayId() => this.RelayId != null;

        /// <summary>
        /// Gets and sets the property RelayName. 
        /// <para>
        /// The unique name of the relay.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RelayName { get; set; }

        /// <summary>
        /// Checks to see if the RelayName property is set.
        /// </summary>
        internal bool IsSetRelayName() => this.RelayName != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The destination relay server address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The destination relay server port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// Checks to see if the ServerPort property is set.
        /// </summary>
        internal bool IsSetServerPort() => this.ServerPort.HasValue;
    }
}
