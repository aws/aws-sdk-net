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
    /// Container for the parameters to the StartQAppSession operation. Starts a new session
    /// for an Amazon Q App, allowing inputs to be provided and the app to be run. <note>
    /// <para> Each Q App session will be condensed into a single conversation in the web
    /// experience. </para> </note>
    /// </summary>
    public partial class StartQAppSessionRequest : AmazonQAppsRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique identifier of the Q App to start a session for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the Q App to use for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion.HasValue;

        /// <summary>
        /// Gets and sets the property InitialValues. 
        /// <para>
        /// Optional initial input values to provide for the Q App session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<CardValue> InitialValues { get; set; } = AWSConfigs.InitializeCollections ? new List<CardValue>() : null;

        /// <summary>
        /// Checks to see if the InitialValues property is set.
        /// </summary>
        internal bool IsSetInitialValues() => this.InitialValues != null && (this.InitialValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application environment instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the a Q App session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags to associate with the new Q App session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
