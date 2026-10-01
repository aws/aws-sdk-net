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
    /// A user access logging settings resource that can be associated with a web portal.
    /// </summary>
    public partial class UserAccessLoggingSettings
    {
        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this user access logging settings is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPortalArns property is set.
        /// </summary>
        internal bool IsSetAssociatedPortalArns() => this.AssociatedPortalArns != null && (this.AssociatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KinesisStreamArn. 
        /// <para>
        /// The ARN of the Kinesis stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KinesisStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamArn property is set.
        /// </summary>
        internal bool IsSetKinesisStreamArn() => this.KinesisStreamArn != null;

        /// <summary>
        /// Gets and sets the property UserAccessLoggingSettingsArn. 
        /// <para>
        /// The ARN of the user access logging settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string UserAccessLoggingSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the UserAccessLoggingSettingsArn property is set.
        /// </summary>
        internal bool IsSetUserAccessLoggingSettingsArn() => this.UserAccessLoggingSettingsArn != null;
    }
}
