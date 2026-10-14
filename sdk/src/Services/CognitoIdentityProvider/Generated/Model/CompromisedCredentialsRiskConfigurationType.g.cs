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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Settings for compromised-credentials actions and authentication-event sources with
    /// threat protection in full-function <c>ENFORCED</c> mode.
    /// </summary>
    public partial class CompromisedCredentialsRiskConfigurationType
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// Settings for the actions that you want your user pool to take when Amazon Cognito
        /// detects compromised credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CompromisedCredentialsActionsType Actions { get; set; }

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null;

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// Settings for the sign-in activity where you want to configure compromised-credentials
        /// actions. Defaults to all events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventFilter property is set.
        /// </summary>
        internal bool IsSetEventFilter() => this.EventFilter != null && (this.EventFilter.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
