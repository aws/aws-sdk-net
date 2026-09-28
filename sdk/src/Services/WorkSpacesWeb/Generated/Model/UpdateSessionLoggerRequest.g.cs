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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSessionLogger operation. Updates the details
    /// of a session logger.
    /// </summary>
    public partial class UpdateSessionLoggerRequest : AmazonWorkSpacesWebRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The updated eventFilter.
        /// </para>
        /// </summary>
        public EventFilter EventFilter { get; set; }

        /// <summary>
        /// Checks to see if the EventFilter property is set.
        /// </summary>
        internal bool IsSetEventFilter() => this.EventFilter != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The updated logConfiguration.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionLoggerArn. 
        /// <para>
        /// The ARN of the session logger to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SessionLoggerArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionLoggerArn property is set.
        /// </summary>
        internal bool IsSetSessionLoggerArn() => this.SessionLoggerArn != null;
    }
}
