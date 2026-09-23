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

namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTarget operation. Deletes a specified target
    /// for notifications.
    /// </summary>
    public partial class DeleteTargetRequest : AmazonCodeStarNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property ForceUnsubscribeAll. 
        /// <para>
        /// A Boolean value that can be used to delete all associations with this Amazon Q Developer
        /// in chat applications topic. The default value is FALSE. If set to TRUE, all associations
        /// between that target and every notification rule in your Amazon Web Services account
        /// are deleted.
        /// </para>
        /// </summary>
        public bool? ForceUnsubscribeAll { get; set; }

        /// <summary>
        /// Checks to see if the ForceUnsubscribeAll property is set.
        /// </summary>
        internal bool IsSetForceUnsubscribeAll() => this.ForceUnsubscribeAll.HasValue;

        /// <summary>
        /// Gets and sets the property TargetAddress. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Developer in chat applications topic
        /// or Amazon Q Developer in chat applications client to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 320)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Checks to see if the TargetAddress property is set.
        /// </summary>
        internal bool IsSetTargetAddress() => this.TargetAddress != null;
    }
}
