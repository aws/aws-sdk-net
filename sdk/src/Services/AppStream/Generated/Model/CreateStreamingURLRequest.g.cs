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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamingURL operation. Creates a temporary
    /// URL to start an WorkSpaces Applications streaming session for the specified user.
    /// A streaming URL enables application streaming to be tested without user setup.
    /// </summary>
    public partial class CreateStreamingURLRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The name of the application to launch after the session starts. This is the name that
        /// you specified as <b>Name</b> in the Image Assistant. If your fleet is enabled for
        /// the <b>Desktop</b> stream view, you can also choose to launch directly to the operating
        /// system desktop. To do so, specify <b>Desktop</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string FleetName { get; set; }

        /// <summary>
        /// Checks to see if the FleetName property is set.
        /// </summary>
        internal bool IsSetFleetName() => this.FleetName != null;

        /// <summary>
        /// Gets and sets the property SessionContext. 
        /// <para>
        /// The session context. For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/managing-stacks-fleets.html#managing-stacks-fleets-parameters">Session
        /// Context</a> in the <i>Amazon WorkSpaces Applications Administration Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SessionContext { get; set; }

        /// <summary>
        /// Checks to see if the SessionContext property is set.
        /// </summary>
        internal bool IsSetSessionContext() => this.SessionContext != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 32)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// The time that the streaming URL will be valid, in seconds. Specify a value between
        /// 1 and 604800 seconds. The default is 60 seconds.
        /// </para>
        /// </summary>
        public long? Validity { get; set; }

        /// <summary>
        /// Checks to see if the Validity property is set.
        /// </summary>
        internal bool IsSetValidity() => this.Validity.HasValue;
    }
}
