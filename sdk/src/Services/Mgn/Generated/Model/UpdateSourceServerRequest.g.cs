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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSourceServer operation. Update Source Server.
    /// </summary>
    public partial class UpdateSourceServerRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update Source Server request account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property ConnectorAction. 
        /// <para>
        /// Update Source Server request connector action.
        /// </para>
        /// </summary>
        public SourceServerConnectorAction ConnectorAction { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorAction property is set.
        /// </summary>
        internal bool IsSetConnectorAction() => this.ConnectorAction != null;

        /// <summary>
        /// Gets and sets the property FqdnForActionFramework. 
        /// <para>
        /// Update Source Server request FQDN for action framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FqdnForActionFramework { get; set; }

        /// <summary>
        /// Checks to see if the FqdnForActionFramework property is set.
        /// </summary>
        internal bool IsSetFqdnForActionFramework() => this.FqdnForActionFramework != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// Update Source Server request platform operating system.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update Source Server request source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;

        /// <summary>
        /// Gets and sets the property UserProvidedID. 
        /// <para>
        /// Update Source Server request user provided ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserProvidedID { get; set; }

        /// <summary>
        /// Checks to see if the UserProvidedID property is set.
        /// </summary>
        internal bool IsSetUserProvidedID() => this.UserProvidedID != null;
    }
}
