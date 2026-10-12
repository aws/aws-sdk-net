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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a trigger for a repository. 
    /// 
    ///  <note> 
    /// <para>
    /// If you want to receive notifications about repository events, consider using notifications
    /// instead of triggers. For more information, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/how-to-repository-email.html">Configuring
    /// notifications for repository events</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RepositoryTrigger
    {
        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The branches to be included in the trigger configuration. If you specify an empty
        /// array, the trigger applies to all branches.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although no content is required in the array, you must include the array itself.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Branches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Branches property is set.
        /// </summary>
        internal bool IsSetBranches() => this.Branches != null && (this.Branches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomData. 
        /// <para>
        /// Any custom data associated with the trigger to be included in the information sent
        /// to the target of the trigger.
        /// </para>
        /// </summary>
        public string CustomData { get; set; }

        /// <summary>
        /// Checks to see if the CustomData property is set.
        /// </summary>
        internal bool IsSetCustomData() => this.CustomData != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the resource that is the target for a trigger (for example, the ARN of
        /// a topic in Amazon SNS).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The repository events that cause the trigger to run actions in another service, such
        /// as sending a notification through Amazon SNS. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The valid value "all" cannot be used with any other values.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
