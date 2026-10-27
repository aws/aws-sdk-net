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
    /// This is the response object from the GetQAppSession operation.
    /// </summary>
    public partial class GetQAppSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the Q App used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CardStatus. 
        /// <para>
        /// The current status for each card in the Q App session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, CardStatus> CardStatus { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CardStatus>() : null;

        /// <summary>
        /// Checks to see if the CardStatus property is set.
        /// </summary>
        internal bool IsSetCardStatus() => this.CardStatus != null && (this.CardStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LatestPublishedAppVersion. 
        /// <para>
        /// The latest published version of the Q App used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? LatestPublishedAppVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestPublishedAppVersion property is set.
        /// </summary>
        internal bool IsSetLatestPublishedAppVersion() => this.LatestPublishedAppVersion.HasValue;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserIsHost. 
        /// <para>
        /// Indicates whether the current user is the owner of the Q App data collection session.
        /// </para>
        /// </summary>
        public bool? UserIsHost { get; set; }

        /// <summary>
        /// Checks to see if the UserIsHost property is set.
        /// </summary>
        internal bool IsSetUserIsHost() => this.UserIsHost.HasValue;
    }
}
